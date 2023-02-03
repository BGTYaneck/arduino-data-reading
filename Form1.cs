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
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = textBox1.Text;
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    (tabControl1.TabPages[0] as TabPage).Enabled = true;


                }
            }
            catch
            {
                MessageBox.Show("Please enter the correct Port Address");
            }
        }
        
        public void button8_Clicked(object sender, EventArgs e)
        {
            if (tabPage3.Enabled == false)
            {
                tabPage3.Enabled = true;
            }
            else
            {
                tabPage3.Enabled = false;
            }
        }

        public void button9_Clicked(object sender, EventArgs e)
        {
            if (tabPage4.Enabled == false)
            {
                tabPage4.Enabled = true;
            }
            else
            {
                tabPage4.Enabled = false;
            }
    }
        public void button10_Clicked(object sender, EventArgs e)
        {
            if (tabPage5.Enabled == false)
            {
                tabPage5.Enabled = true;
            }
            else
            {
                tabPage5.Enabled = false;
            }
        }
        public void button11_Clicked(object sender, EventArgs e)
        {
            if (tabPage6.Enabled == false)
            {
                tabPage6.Enabled = true;
            }
            else
            {
                tabPage6.Enabled = false;
            }
        }
        public void button12_Clicked(object sender, EventArgs e)
        {
            if (tabPage7.Enabled == false)
            {
                tabPage7.Enabled = true;
            }
            else
            {
                tabPage7.Enabled = false;
            }
        }
        public void button13_Clicked(object sender, EventArgs e)
        {
            if (tabPage8.Enabled == false)
            {
                tabPage8.Enabled = true;
            }
            else
            {
                tabPage8.Enabled = false;
            }
        }
        public void button14_Clicked(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Enabled = false;
            }

        }
        

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
                        _serialPort.Write("1+");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[0] = false;
                        button2.BackColor = Color.Red;
                        _serialPort.Write("1-");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL2":
                    if (!status[1])
                    {
                        status[1] = true;
                        button3.BackColor = Color.LimeGreen;
                        _serialPort.Write("2+");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[1] = false;
                        button3.BackColor = Color.Red;
                        _serialPort.Write("2-");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL3":
                    if (!status[2])
                    {
                        status[2] = true;
                        button4.BackColor = Color.LimeGreen;
                        _serialPort.Write("3+");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[2] = false;
                        button4.BackColor = Color.Red;
                        _serialPort.Write("3-");
                        History.Items.Add(name + " OFF \n");
                    }
                    break;
                case "RL4":
                    if (!status[3])
                    {
                        status[3] = true;
                        button5.BackColor = Color.LimeGreen;
                        _serialPort.Write("4+");
                        History.Items.Add(name + " ON \n");
                    }
                    else
                    {
                        status[3] = false;
                        button5.BackColor = Color.Red;
                        _serialPort.Write("4-");
                        History.Items.Add(name + " OFF \n");

                    }
                    break;
            }

        }

        public void turnAllOn(object sender, EventArgs e)
        {
            _serialPort.Write("1+ 2+ 3+ 4+");
            status = new bool[4] { true, true, true, true };
            History.Items.Add("ALL ON");
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;

        }

        public void turnAllOff(object sender, EventArgs e)
        {
            _serialPort.Write("1- 2- 3- 4-");
            status = new bool[4];
            History.Items.Add("ALL OFF");
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }
    }
}
