using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace QRCodeCreator
{
    public partial class frmQRCoder : Form
    {
        SerialPort port = null;
        string path = "D:/Data/ELK/datafiles/dht22.csv";
        public frmQRCoder()
        {
            InitializeComponent();
            port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            txtArduino.Text = "Openning Port";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string POT = port.ReadExisting(); //changing between 0-1023
            txtArduino.Text += POT;
            string strDate = DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss");

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(strDate + ";"+POT);
            }
        }

        private void frmQRCoder_FormClosed(object sender, FormClosedEventArgs e)
        {
            port.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            port.Close();
            Application.Exit();
        }
    }
}
