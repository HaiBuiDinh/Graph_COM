using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Com_Graph
{
    public partial class Form1 : Form
    {
        String DataFromCOM;
        double[] x = new double[100];
        double[] y = new double[100];
        int i;

        PointPairList listPointsOne = new PointPairList();
        LineItem myCurveOne;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = txtCOMPort.Text;
            serialPort1.BaudRate = Convert.ToInt32(txtBaudrate.Text);
            if (serialPort1.IsOpen) return;
            serialPort1.Open();
            btnConn.Enabled = false;
            btnDisConn.Enabled = true;  
        }

        private void BtnDisConn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            serialPort1.Close();
            btnConn.Enabled = true;
            btnDisConn.Enabled = false;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialPort1.BytesToRead > 0)
                {
                    DataFromCOM = serialPort1.ReadLine();
                    if (DataFromCOM.Trim() != "")
                    {
                    
                        int iDAT = Convert.ToInt32(DataFromCOM);
                        //i++;
                        i = (i + 1) % 100;
                        x[i] = i; // (double)i / 100.0 * Math.PI * 2.0;
                        y[i] = iDAT;

                        //listPointsOne.Add(i, iDAT);

                        //z1.GraphPane.AddCurve(null, x, y, Color.Black, SymbolType.Square);
                        //z1.GraphPane.AddCurve(null, listPointsOne, Color.Blue);
                        //z1.AxisChange();
                        //z1.Invalidate();
                    
                    }
                }
            }
            catch { }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtKQ.Text = DataFromCOM;

            z1.GraphPane.CurveList.Clear();
            z1.GraphPane.AddCurve(null, x, y, Color.Black, SymbolType.Square);
            //z1.GraphPane.AddCurve(null, listPointsOne, Color.Blue);
            z1.AxisChange();
            z1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            z1.IsShowPointValues = true;
            z1.GraphPane.Title.Text = "Do thi thoi gian thuc";
            i = 0;
        }
    }
}
