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
using System.Net;
using Newtonsoft.Json.Linq;
using SimpleTCP;

namespace QRCodeCreator
{
    public partial class frmQRCoder : Form
    {
        SerialPort port = null;
        string path = "D:/Data/ELK/datafiles/dht/dht22.csv";
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
            var json = "";
            var theUrl = "http://api.openweathermap.org/data/2.5/weather?q=Colombo,lk&APPID=eae8ded85c06e6fe4053e79c0affdd0e";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(theUrl);
            }

            JObject o = JObject.Parse(json);
            string temp = (string)o.SelectToken("main.temp");
            string humid = (string)o.SelectToken("main.humidity");
            float cTemp = float.Parse(temp);  // Convert Kelvin to Celsius
            txtArduino.Text += "Temperature " + Math.Round(cTemp - 273.15,2) + "\r\n";
            string colTemp = (Math.Round(((cTemp-273.15)*100f)/100f,2)).ToString();
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(strDate + ";"+POT+";"+colTemp+";"+humid+";");
            }

            using (SimpleTcpClient client = new SimpleTcpClient().Connect("127.0.0.1", 12001))
            {
                LogJson log = new LogJson(1001, DateTime.Now, strDate + ";" + POT + ";" + colTemp + ";" + humid + ";");
                client.WriteLine(log.ToString());
                client.Disconnect();
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
