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
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;

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
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.LimeGreen;
                    button7.BackColor = Color.Red;

                }
            }
            catch
            {
                MessageBox.Show("Cant connect to port");
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
                    }
                    else
                    {
                        status[0] = false;
                        button2.BackColor = Color.Red;
                        _serialPort.Write("1-");
                    }
                    break;
                case "RL2":
                    if (!status[1])
                    {
                        status[1] = true;
                        button3.BackColor = Color.LimeGreen;
                        _serialPort.Write("2+");
                    }
                    else
                    {
                        status[1] = false;
                        button3.BackColor = Color.Red;
                        _serialPort.Write("2-");
                    }
                    break;
                case "RL3":
                    if (!status[2])
                    {
                        status[2] = true;
                        button4.BackColor = Color.LimeGreen;
                        _serialPort.Write("3+");
                    }
                    else
                    {
                        status[2] = false;
                        button4.BackColor = Color.Red;
                        _serialPort.Write("3-");
                    }
                    break;
                case "RL4":
                    if (!status[3])
                    {
                        status[3] = true;
                        button5.BackColor = Color.LimeGreen;
                        _serialPort.Write("4+");
                    }
                    else
                    {
                        status[3] = false;
                        button5.BackColor = Color.Red;
                        _serialPort.Write("4-");

                    }
                    break;
            } 

        }

        public void turnAllOn(object sender, EventArgs e)
        {
            _serialPort.Write("1+ 2+ 3+ 4+");
            status = new bool[4]{ true,true,true,true};
            button2.BackColor = Color.LimeGreen;
            button3.BackColor = Color.LimeGreen;
            button4.BackColor = Color.LimeGreen;
            button5.BackColor = Color.LimeGreen;

        }
        
        public void turnAllOff(object sender, EventArgs e)
        {
            _serialPort.Write("1- 2- 3- 4-");
            status = new bool[4];
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
