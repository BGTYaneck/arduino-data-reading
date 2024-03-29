﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ArduinoControls;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Swiatelka
{
    public partial class Form1 : Form
    {
        string indata;
        SerialPort _serialPort;
        bool[] status;
        delegate void SetTextDelegate(string value);
        public string[] portNames = SerialPort.GetPortNames();
        public UdpHelper _udpHelper;

        public Form1()
        {
            InitializeComponent();
            status = new bool[4];
            foreach (var port in portNames)
            {
                comboBox2.Items.Add(port);
            }
            _udpHelper = new UdpHelper("192.168.0.255", 13347);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "115200";
            _serialPort = new SerialPort();
            _serialPort.DtrEnable = true;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedEventHandler);
            System.IO.File.WriteAllText("C:/Temp/log.txt", string.Empty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = comboBox2.Text;
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
                        _= _udpHelper.SendAsync("+1");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[0] = false;
                        button2.BackColor = Color.Red;
                        _serialPort.Write("RELAY1OFF\n");
                        _= _udpHelper.SendAsync("-1");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL2":
                    if (!status[1])
                    {
                        status[1] = true;
                        button3.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY2ON\n");
                        _= _udpHelper.SendAsync("+2");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[1] = false;
                        button3.BackColor = Color.Red;
                        _serialPort.Write("RELAY2OFF\n");
                        _= _udpHelper.SendAsync("-2");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL3":
                    if (!status[2])
                    {
                        status[2] = true;
                        button4.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY3ON\n");
                        _= _udpHelper.SendAsync("+3");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[2] = false;
                        button4.BackColor = Color.Red;
                        _serialPort.Write("RELAY3OFF\n");
                        _= _udpHelper.SendAsync("-3");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL4":
                    if (!status[3])
                    {
                        status[3] = true;
                        button5.BackColor = Color.LimeGreen;
                        _serialPort.Write("RELAY4ON\n");
                        _= _udpHelper.SendAsync("+4");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[3] = false;
                        button5.BackColor = Color.Red;
                        _serialPort.Write("RELAY4OFF\n");
                        _= _udpHelper.SendAsync("-4");
                        History.Items.Add(name + " OFF \n");

                    }
                    break;
            }

        }

        public void turnAllOn(object sender, EventArgs e)
        {
            _serialPort.Write("RELAY3ON\nRELAY4ON\n");
            _= _udpHelper.SendAsync("+5");
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
            _= _udpHelper.SendAsync("-5");
            status = new bool[4];
            History.Items.Add("ALL OFF");
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
        }

        /*Reading data--------------------------------------------------------*/

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
                    
                    label2.Text = $"{data.humidity: 0} [%]";
                    chart7.Series["Humidity"].Points.Add(Convert.ToInt32(data.humidity));
                    if (chart7.Series["Humidity"].Points.Count > 10)
                        chart7.Series["Humidity"].Points.RemoveAt(0);

                    label3.Text = $"{data.temperature: 0} [°C]";
                    chart8.Series["Degrees"].Points.Add(Convert.ToInt32(data.temperature));
                    if (chart8.Series["Degrees"].Points.Count > 10)
                        chart8.Series["Degrees"].Points.RemoveAt(0);

                    label4.Text = $"{Convert.ToInt32(data.pressure) / 100: 0} [hPa]";
                    chart9.Series["Pressure"].Points.Add(Convert.ToInt32(data.pressure) / 100);
                    if (chart9.Series["Pressure"].Points.Count > 10)
                        chart9.Series["Pressure"].Points.RemoveAt(0);

                    label7.Text = $"{data.distance: 0} [cm]";
                    chart11.Series["Distance"].Points.Add(Convert.ToInt32(data.distance));
                    if (chart11.Series["Distance"].Points.Count > 10)
                        chart11.Series["Distance"].Points.RemoveAt(0);

                    label6.Text = $"{data.altitude: 0} [m]";
                    chart13.Series["SeaLevel"].Points.Add(Convert.ToInt32(data.altitude));
                    if (chart13.Series["SeaLevel"].Points.Count > 10)
                        chart13.Series["SeaLevel"].Points.RemoveAt(0);

                    label8.Text = $"{data.light: 0} [lx]";
                    chart12.Series["Illuminance"].Points.Add(Convert.ToInt32(data.light));
                    if (chart12.Series["Illuminance"].Points.Count > 10)
                        chart12.Series["Illuminance"].Points.RemoveAt(0);

                }
                catch (Exception){ return; };
                

            }
        }

        private void DataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            try { 
                indata = _serialPort.ReadLine();
                _= _udpHelper.SendAsync(indata);
                Debug.WriteLine(indata);
                using (StreamWriter writer = new StreamWriter("C:/Temp/log.txt", append: true))
                {
                    writer.WriteLine(indata);
                }
                SetText(indata);
            } catch(Exception) { return; }
            

        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serialPort.Close();
            
        }
    }
}