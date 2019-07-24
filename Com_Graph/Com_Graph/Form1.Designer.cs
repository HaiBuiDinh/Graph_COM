namespace Com_Graph
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtCOMPort = new System.Windows.Forms.TextBox();
            this.GR1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.z1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.GR1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // txtCOMPort
            // 
            this.txtCOMPort.Location = new System.Drawing.Point(45, 19);
            this.txtCOMPort.Name = "txtCOMPort";
            this.txtCOMPort.Size = new System.Drawing.Size(100, 20);
            this.txtCOMPort.TabIndex = 0;
            this.txtCOMPort.Text = "COM6";
            this.txtCOMPort.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // GR1
            // 
            this.GR1.Controls.Add(this.btnClear);
            this.GR1.Controls.Add(this.btnExit);
            this.GR1.Controls.Add(this.txtKQ);
            this.GR1.Controls.Add(this.btnDisConn);
            this.GR1.Controls.Add(this.btnConn);
            this.GR1.Controls.Add(this.label2);
            this.GR1.Controls.Add(this.txtBaudrate);
            this.GR1.Controls.Add(this.label1);
            this.GR1.Controls.Add(this.txtCOMPort);
            this.GR1.Location = new System.Drawing.Point(12, 12);
            this.GR1.Name = "GR1";
            this.GR1.Size = new System.Drawing.Size(575, 78);
            this.GR1.TabIndex = 1;
            this.GR1.TabStop = false;
            this.GR1.Text = "Config";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(512, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(236, 19);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKQ.Size = new System.Drawing.Size(270, 45);
            this.txtKQ.TabIndex = 6;
            // 
            // btnDisConn
            // 
            this.btnDisConn.Enabled = false;
            this.btnDisConn.Location = new System.Drawing.Point(163, 44);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(67, 20);
            this.btnDisConn.TabIndex = 5;
            this.btnDisConn.Text = "Disconnect";
            this.btnDisConn.UseVisualStyleBackColor = true;
            this.btnDisConn.Click += new System.EventHandler(this.BtnDisConn_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(163, 19);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(67, 20);
            this.btnConn.TabIndex = 4;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.BtnConn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud:";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(44, 45);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(100, 20);
            this.txtBaudrate.TabIndex = 2;
            this.txtBaudrate.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cổng:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(12, 96);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new System.Drawing.Size(575, 256);
            this.z1.TabIndex = 2;
            this.z1.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(512, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 20);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 363);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.GR1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Graph COM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GR1.ResumeLayout(false);
            this.GR1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtCOMPort;
        private System.Windows.Forms.GroupBox GR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaudrate;
        private ZedGraph.ZedGraphControl z1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
    }
}

