namespace projekt_RLC
{
    partial class RLC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RLC));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.label_counter = new System.Windows.Forms.Label();
            this.button_save_values = new System.Windows.Forms.Button();
            this.textBox_R_value = new System.Windows.Forms.TextBox();
            this.textBox_L_value = new System.Windows.Forms.TextBox();
            this.textBox_C_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rlc_pic = new System.Windows.Forms.PictureBox();
            this.radioButton_triangle = new System.Windows.Forms.RadioButton();
            this.radioButton_square = new System.Windows.Forms.RadioButton();
            this.radioButton_sine = new System.Windows.Forms.RadioButton();
            this.textBox_freq = new System.Windows.Forms.TextBox();
            this.label_freq = new System.Windows.Forms.Label();
            this.label_ampl = new System.Windows.Forms.Label();
            this.textBox_ampl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_fill = new System.Windows.Forms.Label();
            this.textBox_fill = new System.Windows.Forms.TextBox();
            this.chartInput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVoltages = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.rlc_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltages)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(104, 470);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(172, 244);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Location = new System.Drawing.Point(176, 729);
            this.label_counter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(43, 13);
            this.label_counter.TabIndex = 1;
            this.label_counter.Text = "counter";
            // 
            // button_save_values
            // 
            this.button_save_values.Location = new System.Drawing.Point(327, 207);
            this.button_save_values.Margin = new System.Windows.Forms.Padding(2);
            this.button_save_values.Name = "button_save_values";
            this.button_save_values.Size = new System.Drawing.Size(227, 46);
            this.button_save_values.TabIndex = 2;
            this.button_save_values.Text = "Przepisz dane";
            this.button_save_values.UseVisualStyleBackColor = true;
            this.button_save_values.Click += new System.EventHandler(this.button_save_values_Click);
            // 
            // textBox_R_value
            // 
            this.textBox_R_value.Location = new System.Drawing.Point(208, 66);
            this.textBox_R_value.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_R_value.Name = "textBox_R_value";
            this.textBox_R_value.Size = new System.Drawing.Size(76, 20);
            this.textBox_R_value.TabIndex = 3;
            this.textBox_R_value.Text = "10";
            // 
            // textBox_L_value
            // 
            this.textBox_L_value.Location = new System.Drawing.Point(208, 172);
            this.textBox_L_value.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_L_value.Name = "textBox_L_value";
            this.textBox_L_value.Size = new System.Drawing.Size(76, 20);
            this.textBox_L_value.TabIndex = 4;
            this.textBox_L_value.Text = "10";
            // 
            // textBox_C_value
            // 
            this.textBox_C_value.Location = new System.Drawing.Point(97, 223);
            this.textBox_C_value.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_C_value.Name = "textBox_C_value";
            this.textBox_C_value.Size = new System.Drawing.Size(76, 20);
            this.textBox_C_value.TabIndex = 5;
            this.textBox_C_value.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "R=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "L=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C=";
            // 
            // rlc_pic
            // 
            this.rlc_pic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("rlc_pic.ErrorImage")));
            this.rlc_pic.ImageLocation = "D:\\Materiały\\III semestr\\MMM\\projekt\\projekt_RLC\\projekt_RLC\\Properties\\rlc.PNG";
            this.rlc_pic.Location = new System.Drawing.Point(9, 10);
            this.rlc_pic.Margin = new System.Windows.Forms.Padding(2);
            this.rlc_pic.Name = "rlc_pic";
            this.rlc_pic.Size = new System.Drawing.Size(292, 244);
            this.rlc_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rlc_pic.TabIndex = 9;
            this.rlc_pic.TabStop = false;
            this.rlc_pic.Click += new System.EventHandler(this.rlc_pic_Click);
            // 
            // radioButton_triangle
            // 
            this.radioButton_triangle.AutoSize = true;
            this.radioButton_triangle.Location = new System.Drawing.Point(331, 97);
            this.radioButton_triangle.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_triangle.Name = "radioButton_triangle";
            this.radioButton_triangle.Size = new System.Drawing.Size(125, 17);
            this.radioButton_triangle.TabIndex = 10;
            this.radioButton_triangle.Text = "Pobudzenie trójkątne";
            this.radioButton_triangle.UseVisualStyleBackColor = true;
            // 
            // radioButton_square
            // 
            this.radioButton_square.AutoSize = true;
            this.radioButton_square.Checked = true;
            this.radioButton_square.Location = new System.Drawing.Point(331, 141);
            this.radioButton_square.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_square.Name = "radioButton_square";
            this.radioButton_square.Size = new System.Drawing.Size(140, 17);
            this.radioButton_square.TabIndex = 11;
            this.radioButton_square.TabStop = true;
            this.radioButton_square.Text = "Pobudzenie prostokątne";
            this.radioButton_square.UseVisualStyleBackColor = true;
            // 
            // radioButton_sine
            // 
            this.radioButton_sine.AutoSize = true;
            this.radioButton_sine.Location = new System.Drawing.Point(331, 119);
            this.radioButton_sine.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_sine.Name = "radioButton_sine";
            this.radioButton_sine.Size = new System.Drawing.Size(142, 17);
            this.radioButton_sine.TabIndex = 12;
            this.radioButton_sine.Text = "Pobudzenie sinusoidalne";
            this.radioButton_sine.UseVisualStyleBackColor = true;
            // 
            // textBox_freq
            // 
            this.textBox_freq.Location = new System.Drawing.Point(331, 66);
            this.textBox_freq.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_freq.Name = "textBox_freq";
            this.textBox_freq.Size = new System.Drawing.Size(90, 20);
            this.textBox_freq.TabIndex = 13;
            this.textBox_freq.Text = "1000";
            // 
            // label_freq
            // 
            this.label_freq.AutoSize = true;
            this.label_freq.Location = new System.Drawing.Point(328, 50);
            this.label_freq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_freq.Name = "label_freq";
            this.label_freq.Size = new System.Drawing.Size(41, 13);
            this.label_freq.TabIndex = 14;
            this.label_freq.Text = "delta U";
            // 
            // label_ampl
            // 
            this.label_ampl.AutoSize = true;
            this.label_ampl.Location = new System.Drawing.Point(425, 50);
            this.label_ampl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ampl.Name = "label_ampl";
            this.label_ampl.Size = new System.Drawing.Size(81, 13);
            this.label_ampl.TabIndex = 16;
            this.label_ampl.Text = "Amplituda [Vpp]";
            // 
            // textBox_ampl
            // 
            this.textBox_ampl.Location = new System.Drawing.Point(424, 66);
            this.textBox_ampl.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ampl.Name = "textBox_ampl";
            this.textBox_ampl.Size = new System.Drawing.Size(90, 20);
            this.textBox_ampl.TabIndex = 15;
            this.textBox_ampl.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(327, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sygnał pobudzający u(t)";
            // 
            // label_fill
            // 
            this.label_fill.AutoSize = true;
            this.label_fill.Location = new System.Drawing.Point(371, 164);
            this.label_fill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fill.Name = "label_fill";
            this.label_fill.Size = new System.Drawing.Size(84, 13);
            this.label_fill.TabIndex = 19;
            this.label_fill.Text = "Wypełnienie [%]";
            // 
            // textBox_fill
            // 
            this.textBox_fill.Location = new System.Drawing.Point(370, 180);
            this.textBox_fill.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fill.Name = "textBox_fill";
            this.textBox_fill.Size = new System.Drawing.Size(90, 20);
            this.textBox_fill.TabIndex = 18;
            this.textBox_fill.Text = "50";
            // 
            // chartInput
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.Title = "t";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.Title = "u(t)";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chartInput.ChartAreas.Add(chartArea1);
            this.chartInput.Location = new System.Drawing.Point(22, 286);
            this.chartInput.Margin = new System.Windows.Forms.Padding(2);
            this.chartInput.Name = "chartInput";
            this.chartInput.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Sygnał wejściowy";
            this.chartInput.Series.Add(series1);
            this.chartInput.Size = new System.Drawing.Size(513, 166);
            this.chartInput.TabIndex = 20;
            this.chartInput.Text = "chartInput";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Sygnał pobudzający u(t) ";
            title1.Text = "Sygnał pobudzający u(t)";
            this.chartInput.Titles.Add(title1);
            // 
            // chartVoltages
            // 
            chartArea2.AxisX.Title = "t";
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "x1(t)";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.Name = "ChartX1";
            chartArea3.AxisX.Title = "t";
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "x2(t)";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea3.Name = "ChartX2";
            chartArea4.AxisX.Title = "t";
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.Title = "x3(t)";
            chartArea4.Name = "ChartX3";
            chartArea5.Name = "ChartX4";
            this.chartVoltages.ChartAreas.Add(chartArea2);
            this.chartVoltages.ChartAreas.Add(chartArea3);
            this.chartVoltages.ChartAreas.Add(chartArea4);
            this.chartVoltages.ChartAreas.Add(chartArea5);
            legend1.Name = "Legend1";
            this.chartVoltages.Legends.Add(legend1);
            this.chartVoltages.Location = new System.Drawing.Point(559, 10);
            this.chartVoltages.Margin = new System.Windows.Forms.Padding(2);
            this.chartVoltages.Name = "chartVoltages";
            series2.ChartArea = "ChartX1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SeriesX1";
            series3.ChartArea = "ChartX2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "SeriesX2";
            series4.ChartArea = "ChartX3";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "SeriesX3";
            series5.ChartArea = "ChartX4";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "SeriesX4";
            this.chartVoltages.Series.Add(series2);
            this.chartVoltages.Series.Add(series3);
            this.chartVoltages.Series.Add(series4);
            this.chartVoltages.Series.Add(series5);
            this.chartVoltages.Size = new System.Drawing.Size(875, 733);
            this.chartVoltages.TabIndex = 21;
            this.chartVoltages.Text = "chart1";
            // 
            // RLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.chartVoltages);
            this.Controls.Add(this.chartInput);
            this.Controls.Add(this.label_fill);
            this.Controls.Add(this.textBox_fill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ampl);
            this.Controls.Add(this.textBox_ampl);
            this.Controls.Add(this.label_freq);
            this.Controls.Add(this.textBox_freq);
            this.Controls.Add(this.radioButton_sine);
            this.Controls.Add(this.radioButton_square);
            this.Controls.Add(this.radioButton_triangle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_C_value);
            this.Controls.Add(this.textBox_L_value);
            this.Controls.Add(this.textBox_R_value);
            this.Controls.Add(this.button_save_values);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.rlc_pic);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RLC";
            this.Text = "RLC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rlc_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.Button button_save_values;
        private System.Windows.Forms.TextBox textBox_R_value;
        private System.Windows.Forms.TextBox textBox_L_value;
        private System.Windows.Forms.TextBox textBox_C_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox rlc_pic;
        private System.Windows.Forms.RadioButton radioButton_triangle;
        private System.Windows.Forms.RadioButton radioButton_square;
        private System.Windows.Forms.RadioButton radioButton_sine;
        private System.Windows.Forms.TextBox textBox_freq;
        private System.Windows.Forms.Label label_freq;
        private System.Windows.Forms.Label label_ampl;
        private System.Windows.Forms.TextBox textBox_ampl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_fill;
        private System.Windows.Forms.TextBox textBox_fill;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoltages;
    }
}

