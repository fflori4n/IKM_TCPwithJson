using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;


namespace IKM_TCPwithJson
{
    public class TCPCOM
    {

        public TcpClient tCPclient;
        public NetworkStream stream;
        private Timer timer;
        private Thread listeningThread;

        public TcpListener tcpListener;

        public bool serverStopFlg = true;
       // public static ManualResetEvent tcpClientConnected =new ManualResetEvent(false);

        public void cliConnect(string iP, string port)
        {
            try
            {
                this.tCPclient = new TcpClient();
                this.tCPclient.Connect(iP, int.Parse(port));

                this.stream = this.tCPclient.GetStream();
                this.timer = new Timer();
                this.timer.Tick += new EventHandler(timerCallback);
                this.timer.Interval = 100; // in miliseconds
                this.timer.Start();

                Console.WriteLine("[ OK ] TCP client connected");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void cliSend(String msg)
        {
            if (this.stream is null)
            {
                Console.WriteLine("[ER] TCP not connected!");
                return;
            }
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(msg + "\r\n");
                this.stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void cliDispose()
        {
            if (!(this.stream is null)) {
                this.stream.Dispose();
            }
            if (!(this.tCPclient is null))
            {
                try
                {
                    this.tCPclient.Close();
                    this.tCPclient.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("TCP_DISPOSE:" + ex.Message);
                }
            }
            
        }

        private void timerCallback(object sender, EventArgs e)
        {
            try
            {
                if (this.stream.DataAvailable)
                {
                    byte[] recivedData = new byte[tCPclient.ReceiveBufferSize];
                    this.stream.Read(recivedData, 0, recivedData.Length);

                    string txt = Encoding.UTF8.GetString(recivedData);

                    Console.WriteLine("TCP>>" + txt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Form1.print2list(ex.Message);
            }

        }

        public void CreateServer(string iP, string port)
        {
            this.tcpListener = new TcpListener(System.Net.IPAddress.Parse(iP), int.Parse(port));
            try
            {
                this.tcpListener.Start();
            }
            catch
            {
                Console.WriteLine("failed to create server!");
                return;
            }
            Console.WriteLine("Server started [ OK ]");
            Form1.print2RawListbox("Server started[OK]");

            this.listeningThread = new Thread(() =>
            {
                this.serverStopFlg = false;
                while (!this.serverStopFlg)
                {
                    TcpClient tcpClient;
                    try
                    {
                        tcpClient = this.tcpListener.AcceptTcpClient();
                        Console.WriteLine("client connected!");
                        Form1.print2RawListbox("client connected!");
                    }
                    catch {
                        Console.WriteLine("Thread was stopped while waiting for client");
                        return ;
                    }
                    if (tcpClient == null) { 
                        return ;
                    }
                    
                    ThreadPool.QueueUserWorkItem(param =>
                    {
                        NetworkStream stream = tcpClient.GetStream();
                        string incomming;
                        byte[] bytes = new byte[1024];
                        int i = stream.Read(bytes, 0, bytes.Length);
                        incomming = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine(incomming);
                        Form1.print2RawListbox("rcvd: " + incomming);
                        Form1.parsePrintMsg(incomming);
                        stream.Close();
                        tcpClient.Close();
                        Form1.print2RawListbox("client disconected!");
                    });
                }
            });

            this.listeningThread.IsBackground = true;
            this.listeningThread.Start();
        }

        public void serverDispose() {
            this.serverStopFlg = true;
            this.listeningThread = null ;
            this.tcpListener.Stop();
            this.tcpListener = null;
        }
    }
}
