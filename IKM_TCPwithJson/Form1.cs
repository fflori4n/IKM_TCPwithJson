using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKM_TCPwithJson
{
    
    public partial class Form1 : Form
    {
        public TCPCOM currentTcp;
        public bool isReciever = false;
        public RoomSensor roomSensor = new RoomSensor();
        public static ListBox recvRawListview;
        public static ListBox recvParsedListview;

        public Form1()
        {
            InitializeComponent();
            recvRawListview = listBoxRCVRaw;
            recvParsedListview = listBoxRCVParsed;
        }
        public static void print2RawListbox(string poruka)
        {
            
            if (recvRawListview.InvokeRequired)
            {
                recvRawListview.Invoke((MethodInvoker)(() =>
                {
                    //recvRawListview.Items.Add("InvokeRequired");
                    recvRawListview.Items.Add(poruka);
                }));
            }
            else
            {
                recvRawListview.Items.Add(poruka);
            }
        }

        public static void print2ParsedListbox(string poruka)
        {
            List<string> lineList = poruka.Split('\n').ToList();

            foreach (string line in lineList) {
                if (recvParsedListview.InvokeRequired)
                {
                    recvParsedListview.Invoke((MethodInvoker)(() =>
                    {
                        //recvRawListview.Items.Add("InvokeRequired");
                        recvParsedListview.Items.Add(line);
                    }));
                }
                else
                {
                    recvParsedListview.Items.Add(line);
                }
            }
        }

        private void cBoxIsReciever_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxIsReciever.Checked)
            {
                if (this.currentTcp != null) {
                    this.currentTcp.serverDispose();
                    this.currentTcp = null;
                }
                cBoxIsReciever.Text = "Reciever";
                isReciever = true;
                groupBoxRec.Visible = true;
                groupBoxSend.Visible = false;
                btnStart.Visible = true;
            }
            else {
                cBoxIsReciever.Text = "Sender";
                isReciever = false;
                groupBoxRec.Visible = false;
                groupBoxSend.Visible = true;
                btnStart.Visible = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try {
                roomSensor.tempSensor = new DHT22(Double.Parse(txbTemp.Text.Replace(',', '.')), Double.Parse(txbHum.Text.Replace(',', '.')));
            }
            catch {
                roomSensor.tempSensor = new DHT22();
            }
            roomSensor.isOcupied = cBxIsOcupied.Checked;
            roomSensor.isWindowOpen = cBxIsWindowOpen.Checked;

            string[] words = tXbLastHourOcupied.Text.Split(',');

            roomSensor.ocupiedLastHour = new List<int>();
            for (int i = 0; i < 12; i++) {
                roomSensor.ocupiedLastHour.Add(0); 
            }
            for( int i=0; i< words.Length; i++) {
                roomSensor.ocupiedLastHour[i] = int.Parse(words[i]);
            }

            roomSensor.roomName = tXbRoomName.Text;
            if (tXbRoomName.Text.Length == 0) {
                roomSensor.roomName = null;
            }
            roomSensor.buildingName = tXbBuildingName.Text;
            if (tXbBuildingName.Text.Length == 0)
            {
                roomSensor.buildingName = null;
            }
            roomSensor.lightLevel = trackBarLight.Value;

            
            this.send();
        }

        public void send() {
            TCPCOM clientTcp = new TCPCOM();
            clientTcp.cliConnect(txbIpAddr.Text, txbPort.Text);
            clientTcp.cliSend(JSON.ToJson(roomSensor));
            clientTcp.cliDispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.currentTcp != null && this.currentTcp.serverStopFlg == false) { 
                this.currentTcp.serverDispose();
                print2RawListbox("[ OK ] Server stopped!");
            }
            else if (this.isReciever) {
                TCPCOM server = new TCPCOM();
                server.CreateServer(txbIpAddr.Text, txbPort.Text);
                this.currentTcp = server;
            }
        }

        public static void parsePrintMsg(string rawMsg) {
            try
            {
                RoomSensor msgSensor = JSON.FromJson<RoomSensor>(rawMsg);
                Console.WriteLine(msgSensor.ToString());
                print2ParsedListbox(msgSensor.ToString());
            }
            catch (Exception e){
                Console.WriteLine("[ ER ] failed to parse JSON" + e.Message);
            }
            

        }

        private void btnClrRaw_Click(object sender, EventArgs e)
        {
            listBoxRCVRaw.Items.Clear();
        }

        private void btnClrParsed_Click(object sender, EventArgs e)
        {
            listBoxRCVParsed.Items.Clear();
        }
    }
}
