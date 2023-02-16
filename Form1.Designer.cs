using System.Drawing;

namespace Swiatelka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.History = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart12 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.chart11 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.chart13 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.chart9 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.chart8 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart7 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(191)))), ((int)(((byte)(200)))));
            this.groupBox1.Controls.Add(this.History);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(9, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 376);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relays";
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(20, 240);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(174, 95);
            this.History.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button7.Location = new System.Drawing.Point(16, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "ALL OFF";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.turnAllOff);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.Location = new System.Drawing.Point(16, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "ALL ON";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.turnAllOn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(16, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "RL1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.lightsControl);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(107, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "RL4";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.lightsControl);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(107, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "RL2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.lightsControl);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(16, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "RL3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.lightsControl);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(191)))), ((int)(((byte)(200)))));
            this.groupBox3.Controls.Add(this.chart12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chart11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.chart13);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.chart9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.chart8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chart7);
            this.groupBox3.Location = new System.Drawing.Point(224, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1041, 544);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // chart12
            // 
            chartArea19.Name = "ChartArea1";
            this.chart12.ChartAreas.Add(chartArea19);
            this.chart12.Location = new System.Drawing.Point(693, 272);
            this.chart12.Name = "chart12";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
            series19.Name = "Illuminance";
            series19.YValuesPerPoint = 4;
            this.chart12.Series.Add(series19);
            this.chart12.Size = new System.Drawing.Size(332, 200);
            this.chart12.TabIndex = 11;
            this.chart12.Text = "chart12";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label8.Location = new System.Drawing.Point(693, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "000lx";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart11
            // 
            chartArea20.Name = "ChartArea1";
            this.chart11.ChartAreas.Add(chartArea20);
            this.chart11.Location = new System.Drawing.Point(355, 272);
            this.chart11.Name = "chart11";
            this.chart11.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series20.Name = "Distance";
            this.chart11.Series.Add(series20);
            this.chart11.Size = new System.Drawing.Size(332, 200);
            this.chart11.TabIndex = 9;
            this.chart11.Text = "chart11";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label7.Location = new System.Drawing.Point(17, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "000cm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart13
            // 
            chartArea21.Name = "ChartArea1";
            this.chart13.ChartAreas.Add(chartArea21);
            this.chart13.Location = new System.Drawing.Point(17, 272);
            this.chart13.Name = "chart13";
            this.chart13.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Name = "SeaLevel";
            this.chart13.Series.Add(series21);
            this.chart13.Size = new System.Drawing.Size(332, 200);
            this.chart13.TabIndex = 7;
            this.chart13.Text = "chart13";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label6.Location = new System.Drawing.Point(355, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "00m";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart9
            // 
            chartArea22.Name = "ChartArea1";
            this.chart9.ChartAreas.Add(chartArea22);
            this.chart9.Location = new System.Drawing.Point(693, 21);
            this.chart9.Name = "chart9";
            this.chart9.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series22.ChartArea = "ChartArea1";
            series22.Name = "Pressure";
            this.chart9.Series.Add(series22);
            this.chart9.Size = new System.Drawing.Size(332, 200);
            this.chart9.TabIndex = 5;
            this.chart9.Text = "chart9";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label4.Location = new System.Drawing.Point(693, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "0000 hPa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart8
            // 
            chartArea23.Name = "ChartArea1";
            this.chart8.ChartAreas.Add(chartArea23);
            this.chart8.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart8.Location = new System.Drawing.Point(355, 21);
            this.chart8.Name = "chart8";
            this.chart8.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series23.Name = "Degrees";
            this.chart8.Series.Add(series23);
            this.chart8.Size = new System.Drawing.Size(332, 200);
            this.chart8.TabIndex = 3;
            this.chart8.Text = "chart8";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.Location = new System.Drawing.Point(355, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "00°C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(17, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "00%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart7
            // 
            this.chart7.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.chart7.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart7.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            chartArea24.Name = "ChartArea1";
            this.chart7.ChartAreas.Add(chartArea24);
            this.chart7.Location = new System.Drawing.Point(17, 21);
            this.chart7.Name = "chart7";
            this.chart7.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series24.Name = "Humidity";
            series24.YValuesPerPoint = 2;
            this.chart7.Series.Add(series24);
            this.chart7.Size = new System.Drawing.Size(332, 200);
            this.chart7.TabIndex = 2;
            this.chart7.Text = "chart7";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(191)))), ((int)(((byte)(200)))));
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 162);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Connection";
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Location = new System.Drawing.Point(46, 125);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(102, 31);
            this.button14.TabIndex = 12;
            this.button14.Text = "Disconnect";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(15, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Rate:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox1.Location = new System.Drawing.Point(91, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(91, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 30);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Kontrolki Arduino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

