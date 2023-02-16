using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Xml.Linq;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using ArduinoControls;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Swiatelka
{
    public partial class Form1 : Form
    {
        string indata;
        SerialPort _serialPort;
        bool[] status;
        delegate void SetTextDelegate(string value);

        public Form1()
        {
            InitializeComponent();
            status = new bool[4];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "115200";
            _serialPort = new SerialPort();
            _serialPort.DtrEnable = true;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            /*_serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;*/
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
            System.IO.File.WriteAllText("C:/Temp/log.txt", string.Empty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = textBox1.Text;
                _serialPort.BaudRate = Convert.ToInt32(comboBox1.Text);
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    button14.Enabled = true;
                    button1.Enabled = false;
                    List<Button> btn = groupBox1.Controls.OfType<Button>().ToList();
                    foreach (var b in btn)
                    {
                        b.Enabled = true;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error! - Can't connect to selected Port.");
            }
        }
        
        /*Relays---------------------------------------------------------------*/
        public void lightsControl(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Text;

            switch (name)
            {
                case "RL1":
                    if (!status[0])
                    {
                        status[0] = true;
                        button2.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY1ON\n");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[0] = false;
                        button2.BackColor = Color.Red;
                        _serialPort.Write("RELAY1OFF\n");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL2":
                    if (!status[1])
                    {
                        status[1] = true;
                        button3.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY2ON\n");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[1] = false;
                        button3.BackColor = Color.Red;
                        _serialPort.Write("RELAY2OFF\n");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL3":
                    if (!status[2])
                    {
                        status[2] = true;
                        button4.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY3ON\n");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[2] = false;
                        button4.BackColor = Color.Red;
                        _serialPort.Write("RELAY3OFF\n");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL4":
                    if (!status[3])
                    {
                        status[3] = true;
                        button5.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY4ON\n");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[3] = false;
                        button5.BackColor = Color.Red;
                        _serialPort.Write("RELAY4OFF\n");
                        History.Items.Add(name + " OFF \n");

                    }
                    break;
            }

        }

        public void turnAllOn(object sender, EventArgs e)
        {
            _serialPort.Write("RELAY1ON\nRELAY2ON\nRELAY3ON\nRELAY4ON\n");
            status = new bool[4] { true, true, true, true };
            History.Items.Add("ALL ON");
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;

        }

        public void turnAllOff(object sender, EventArgs e)
        {
            _serialPort.Write("RELAY1OFF\nRELAY2OFF\nRELAY3OFF\nRELAY4OFF\n");
            status = new bool[4];
            History.Items.Add("ALL OFF");
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
        }

        public void SetText(string value)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(SetText), value);
                }
                catch { }

            else
            {
                try { 
                    var data = JsonConvert.DeserializeObject<ArduinoControls.Model>(value);
                    
                    label2.Text = $"{data.humidity: 0}%";
                    chart7.Series["Humidity"].Points.Add(Math.Round(Convert.ToDouble(data.humidity)));
                    
                    label3.Text = $"{data.temperature: 0}°C";
                    chart8.Series["Degrees"].Points.Add(Math.Round(Convert.ToDouble(data.temperature)));

                    label4.Text = $"{Convert.ToInt32(data.pressure) / 100: 0}hPa";
                    chart9.Series["Pressure"].Points.Add(Math.Round(Convert.ToDouble(data.pressure)) / 100);

                    label7.Text = $"{data.distance: 0}cm";
                    chart11.Series["Distance"].Points.Add(Math.Round(Convert.ToDouble(data.distance)));
                    
                    label6.Text = $"{data.altitude}m";
                    chart13.Series["SeaLevel"].Points.Add(Math.Round(Convert.ToDouble(data.altitude)));

                    label8.Text = $"{data.light}lx";
                    chart12.Series["Illuminance"].Points.Add(Math.Round(Convert.ToDouble(data.light)));

                }
                catch (Exception){ return; };
                

            }
        }

        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            try { 
                indata = _serialPort.ReadLine();
                Debug.WriteLine(indata);
                using (StreamWriter writer = new StreamWriter("C:/Temp/log.txt", append: true))
                {
                    writer.WriteLine(indata);
                }
                SetText(indata);
            } catch(Exception) { return; }
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            
            button1.Enabled = true;
            button14.Enabled = false;
            List<Button> btn = groupBox1.Controls.OfType<Button>().ToList();
            foreach (var b in btn)
            {
                b.Enabled = false;
            }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serialPort.Close();
        }
    }
}