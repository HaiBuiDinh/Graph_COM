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
        int i; //bien thoi gian
        double datas = 0; //bien de luu du lieu

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
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
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
                    //if (DataFromCOM.Trim() != "")
                    //{

                    //    int iDAT = Convert.ToInt32(DataFromCOM);
                    //    //i = (i + 1) % 100;
                    //    i++;
                    //    x[i] = i; 
                    //    y[i] = iDAT;
                    //}
                    double.TryParse(DataFromCOM, out datas); //Chuyen doi sang kieu double
                    i++; 
                }
            }
            catch
            {
                return;
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtKQ.Text = DataFromCOM;   //Hien thi ket qua\
            Draw();                     //Ve do thi
        }

        private void Draw()
        {
            if (z1.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = z1.GraphPane.CurveList[0] as LineItem;

            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;

            if (list == null)
                return;
            list.Add(i, datas); //Them diem tren do thi

            //Neu muon do thi tinh~ thi bo hai dong nay 
            Scale xScale = z1.GraphPane.XAxis.Scale; //chua dung toi
            Scale yScale = z1.GraphPane.YAxis.Scale;    //chua dung toi

            if(i > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = i + xScale.MajorStep;
                xScale.Min = xScale.Max - 50;
            }

            z1.AxisChange();
            z1.Invalidate();
            z1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            z1.IsShowPointValues = true;
            z1.GraphPane.Title.Text = "Do thi thoi gian thuc";
            z1.GraphPane.XAxis.Title.Text = "Thoi gian";
            z1.GraphPane.YAxis.Title.Text = "Du lieu";

            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = z1.GraphPane.AddCurve("Du lieu", list, Color.Red, SymbolType.Circle);
            i = 0;

            z1.GraphPane.XAxis.Scale.Min = 0;
            z1.GraphPane.XAxis.Scale.Max = 50; //?
            z1.GraphPane.XAxis.Scale.MinorStep = 1;
            z1.GraphPane.XAxis.Scale.MajorStep = 5;
            //z1.GraphPane.YAxis.Scale.Min = 0;
            //z1.GraphPane.YAxis.Scale.Max = 100;

            z1.GraphPane.AxisChange();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            z1.GraphPane.CurveList.Clear(); //Xoa duong
            z1.GraphPane.GraphObjList.Clear(); //Xoa doi tuong

            z1.IsShowPointValues = true;
            z1.GraphPane.Title.Text = "Do thi thoi gian thuc";
            z1.GraphPane.XAxis.Title.Text = "Thoi gian";
            z1.GraphPane.YAxis.Title.Text = "Du lieu";

            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = z1.GraphPane.AddCurve("Du lieu", list, Color.Red, SymbolType.Circle);
            i = 0;

            //Neu muon do thi tinh~ thi bo bon dong nay
            z1.GraphPane.XAxis.Scale.Min = 0;
            z1.GraphPane.XAxis.Scale.Max = 50; //?
            z1.GraphPane.XAxis.Scale.MinorStep = 1;
            z1.GraphPane.XAxis.Scale.MajorStep = 5;

            z1.GraphPane.AxisChange();
        }
    }
}
