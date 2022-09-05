namespace IKM_TCPwithJson
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxIsReciever = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIpAddr = new System.Windows.Forms.TextBox();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRec = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRCVParsed = new System.Windows.Forms.ListBox();
            this.listBoxRCVRaw = new System.Windows.Forms.ListBox();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarLight = new System.Windows.Forms.TrackBar();
            this.tXbBuildingName = new System.Windows.Forms.TextBox();
            this.tXbRoomName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tXbLastHourOcupied = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBxIsOcupied = new System.Windows.Forms.CheckBox();
            this.cBxIsWindowOpen = new System.Windows.Forms.CheckBox();
            this.txbHum = new System.Windows.Forms.TextBox();
            this.txbTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClrParsed = new System.Windows.Forms.Button();
            this.btnClrRaw = new System.Windows.Forms.Button();
            this.groupBoxRec.SuspendLayout();
            this.groupBoxSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLight)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxIsReciever
            // 
            this.cBoxIsReciever.Appearance = System.Windows.Forms.Appearance.Button;
            this.cBoxIsReciever.AutoSize = true;
            this.cBoxIsReciever.Location = new System.Drawing.Point(135, 21);
            this.cBoxIsReciever.Name = "cBoxIsReciever";
            this.cBoxIsReciever.Size = new System.Drawing.Size(61, 26);
            this.cBoxIsReciever.TabIndex = 0;
            this.cBoxIsReciever.Text = "Sender";
            this.cBoxIsReciever.UseVisualStyleBackColor = true;
            this.cBoxIsReciever.CheckedChanged += new System.EventHandler(this.cBoxIsReciever_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "App works as:";
            // 
            // txbIpAddr
            // 
            this.txbIpAddr.Location = new System.Drawing.Point(41, 67);
            this.txbIpAddr.Name = "txbIpAddr";
            this.txbIpAddr.Size = new System.Drawing.Size(155, 22);
            this.txbIpAddr.TabIndex = 2;
            this.txbIpAddr.Text = "127.0.0.1";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(218, 67);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(100, 22);
            this.txbPort.TabIndex = 3;
            this.txbPort.Text = "5000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // groupBoxRec
            // 
            this.groupBoxRec.Controls.Add(this.btnClrRaw);
            this.groupBoxRec.Controls.Add(this.btnClrParsed);
            this.groupBoxRec.Controls.Add(this.label4);
            this.groupBoxRec.Controls.Add(this.label3);
            this.groupBoxRec.Controls.Add(this.listBoxRCVParsed);
            this.groupBoxRec.Controls.Add(this.listBoxRCVRaw);
            this.groupBoxRec.Location = new System.Drawing.Point(41, 95);
            this.groupBoxRec.Name = "groupBoxRec";
            this.groupBoxRec.Size = new System.Drawing.Size(1003, 420);
            this.groupBoxRec.TabIndex = 5;
            this.groupBoxRec.TabStop = false;
            this.groupBoxRec.Text = "Recieve";
            this.groupBoxRec.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tags and Values:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raw incoming string:";
            // 
            // listBoxRCVParsed
            // 
            this.listBoxRCVParsed.FormattingEnabled = true;
            this.listBoxRCVParsed.ItemHeight = 16;
            this.listBoxRCVParsed.Location = new System.Drawing.Point(576, 69);
            this.listBoxRCVParsed.Name = "listBoxRCVParsed";
            this.listBoxRCVParsed.Size = new System.Drawing.Size(408, 292);
            this.listBoxRCVParsed.TabIndex = 1;
            // 
            // listBoxRCVRaw
            // 
            this.listBoxRCVRaw.FormattingEnabled = true;
            this.listBoxRCVRaw.ItemHeight = 16;
            this.listBoxRCVRaw.Location = new System.Drawing.Point(6, 69);
            this.listBoxRCVRaw.Name = "listBoxRCVRaw";
            this.listBoxRCVRaw.Size = new System.Drawing.Size(534, 292);
            this.listBoxRCVRaw.TabIndex = 0;
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.label10);
            this.groupBoxSend.Controls.Add(this.trackBarLight);
            this.groupBoxSend.Controls.Add(this.tXbBuildingName);
            this.groupBoxSend.Controls.Add(this.tXbRoomName);
            this.groupBoxSend.Controls.Add(this.label9);
            this.groupBoxSend.Controls.Add(this.label8);
            this.groupBoxSend.Controls.Add(this.tXbLastHourOcupied);
            this.groupBoxSend.Controls.Add(this.label7);
            this.groupBoxSend.Controls.Add(this.cBxIsOcupied);
            this.groupBoxSend.Controls.Add(this.cBxIsWindowOpen);
            this.groupBoxSend.Controls.Add(this.txbHum);
            this.groupBoxSend.Controls.Add(this.txbTemp);
            this.groupBoxSend.Controls.Add(this.label6);
            this.groupBoxSend.Controls.Add(this.label5);
            this.groupBoxSend.Controls.Add(this.btnSend);
            this.groupBoxSend.Location = new System.Drawing.Point(41, 95);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(1003, 420);
            this.groupBoxSend.TabIndex = 6;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "Send";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Light";
            // 
            // trackBarLight
            // 
            this.trackBarLight.Location = new System.Drawing.Point(143, 282);
            this.trackBarLight.Name = "trackBarLight";
            this.trackBarLight.Size = new System.Drawing.Size(219, 56);
            this.trackBarLight.TabIndex = 18;
            // 
            // tXbBuildingName
            // 
            this.tXbBuildingName.Location = new System.Drawing.Point(143, 243);
            this.tXbBuildingName.Name = "tXbBuildingName";
            this.tXbBuildingName.Size = new System.Drawing.Size(100, 22);
            this.tXbBuildingName.TabIndex = 17;
            this.tXbBuildingName.Text = "building0";
            // 
            // tXbRoomName
            // 
            this.tXbRoomName.Location = new System.Drawing.Point(143, 207);
            this.tXbRoomName.Name = "tXbRoomName";
            this.tXbRoomName.Size = new System.Drawing.Size(100, 22);
            this.tXbRoomName.TabIndex = 16;
            this.tXbRoomName.Text = "room0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Building name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Room name:";
            // 
            // tXbLastHourOcupied
            // 
            this.tXbLastHourOcupied.Location = new System.Drawing.Point(143, 173);
            this.tXbLastHourOcupied.Name = "tXbLastHourOcupied";
            this.tXbLastHourOcupied.Size = new System.Drawing.Size(255, 22);
            this.tXbLastHourOcupied.TabIndex = 13;
            this.tXbLastHourOcupied.Text = "0,0,0,0,0,0,0,0,0,0,0,0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last hour ocupied:";
            // 
            // cBxIsOcupied
            // 
            this.cBxIsOcupied.Appearance = System.Windows.Forms.Appearance.Button;
            this.cBxIsOcupied.AutoSize = true;
            this.cBxIsOcupied.Location = new System.Drawing.Point(24, 129);
            this.cBxIsOcupied.Name = "cBxIsOcupied";
            this.cBxIsOcupied.Size = new System.Drawing.Size(100, 26);
            this.cBxIsOcupied.TabIndex = 11;
            this.cBxIsOcupied.Text = "room ocupied";
            this.cBxIsOcupied.UseVisualStyleBackColor = true;
            // 
            // cBxIsWindowOpen
            // 
            this.cBxIsWindowOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cBxIsWindowOpen.AutoSize = true;
            this.cBxIsWindowOpen.Location = new System.Drawing.Point(24, 97);
            this.cBxIsWindowOpen.Name = "cBxIsWindowOpen";
            this.cBxIsWindowOpen.Size = new System.Drawing.Size(95, 26);
            this.cBxIsWindowOpen.TabIndex = 10;
            this.cBxIsWindowOpen.Text = "window open";
            this.cBxIsWindowOpen.UseVisualStyleBackColor = true;
            // 
            // txbHum
            // 
            this.txbHum.Location = new System.Drawing.Point(298, 65);
            this.txbHum.Name = "txbHum";
            this.txbHum.Size = new System.Drawing.Size(100, 22);
            this.txbHum.TabIndex = 9;
            // 
            // txbTemp
            // 
            this.txbTemp.Location = new System.Drawing.Point(192, 65);
            this.txbTemp.Name = "txbTemp";
            this.txbTemp.Size = new System.Drawing.Size(100, 22);
            this.txbTemp.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "DHT22: TEMP, HUMIDITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "[ TAG NAME ] - [  VALUE ]";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(22, 377);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 26);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send it";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClrParsed
            // 
            this.btnClrParsed.Location = new System.Drawing.Point(909, 377);
            this.btnClrParsed.Name = "btnClrParsed";
            this.btnClrParsed.Size = new System.Drawing.Size(75, 23);
            this.btnClrParsed.TabIndex = 5;
            this.btnClrParsed.Text = "Clear";
            this.btnClrParsed.UseVisualStyleBackColor = true;
            this.btnClrParsed.Click += new System.EventHandler(this.btnClrParsed_Click);
            // 
            // btnClrRaw
            // 
            this.btnClrRaw.Location = new System.Drawing.Point(465, 377);
            this.btnClrRaw.Name = "btnClrRaw";
            this.btnClrRaw.Size = new System.Drawing.Size(75, 23);
            this.btnClrRaw.TabIndex = 6;
            this.btnClrRaw.Text = "Clear";
            this.btnClrRaw.UseVisualStyleBackColor = true;
            this.btnClrRaw.Click += new System.EventHandler(this.btnClrRaw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.groupBoxRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txbIpAddr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxIsReciever);
            this.Name = "Form1";
            this.Text = "IKM_TCPandJSON";
            this.groupBoxRec.ResumeLayout(false);
            this.groupBoxRec.PerformLayout();
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxIsReciever;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIpAddr;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRec;
        private System.Windows.Forms.ListBox listBoxRCVParsed;
        public System.Windows.Forms.ListBox listBoxRCVRaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txbHum;
        private System.Windows.Forms.TextBox txbTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cBxIsOcupied;
        private System.Windows.Forms.CheckBox cBxIsWindowOpen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tXbLastHourOcupied;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tXbBuildingName;
        private System.Windows.Forms.TextBox tXbRoomName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarLight;
        private System.Windows.Forms.Button btnClrRaw;
        private System.Windows.Forms.Button btnClrParsed;
    }
}

