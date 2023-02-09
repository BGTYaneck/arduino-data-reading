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
using Newtonsoft.Json.Linq;

namespace Swiatelka
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        bool[] status;
        public Form1()
        {
            InitializeComponent();
            status = new bool[4];
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage2);
            //---------------------------------------
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "57600";
            _serialPort = new SerialPort();
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
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
                    tabControl1.TabPages.Add(tabPage9);
                    tabControl1.TabPages.Add(tabPage2);

                    List<Button> btn = groupBox3.Controls.OfType<Button>().ToList();
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
        
        public void tab3_Control(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage3))
            {
                tabControl1.TabPages.Add(tabPage3);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
        }

        public void tab4_Control(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage4))
            {
                tabControl1.TabPages.Add(tabPage4);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
        }
        public void tab5_Control(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage5))
            {
                tabControl1.TabPages.Add(tabPage5);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage5);
            }
        }
        public void tab6_Control(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage6))
            {
                tabControl1.TabPages.Add(tabPage6);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage6);
            }
        }
        public void tab7_Control(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage7))
            {
                tabControl1.TabPages.Add(tabPage7);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage7);
            }
        }
        public void tab8_Control(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage8))
            {
                tabControl1.TabPages.Add(tabPage8);
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage8);
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
       
        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = _serialPort.ReadLine();
            var data = JsonConvert.DeserializeObject<ArduinoControls.Model>(indata);
            label2.Text = $"{data.humidity}%";
            label3.Text = $"{data.temperature}°C";
            label4.Text = $"{data.pressure / 100}hPa";
            label5.Text = $"{data.temperature: 0.00}°C";
            label7.Text = $"{data.distance: 0.0}cm";
            label8.Text = $"{data.light: 0.00}lx";

        }
    }
}