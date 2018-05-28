using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace projekt_RLC
{
    public partial class RLC : Form
    {
        int clock = 0;
        double R_value = 10;
        double L_value = 10;
        double C_value = 10;
        signal input_signal;
        string signal_flag = "square";

        int deltaU = 1000;
        double amplitude = 1;
        int fill = 50;
        public RLC()
        {
            InitializeComponent();
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            clock++;
            label_counter.Text = clock.ToString();
            
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer_main.Enabled = !timer_main.Enabled;
            if (timer_main.Enabled)
                button_start.Text = "Stop";
            else
                button_start.Text = "Start";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            read_data();
            read_signal_data();
        }

        private void button_save_values_Click(object sender, EventArgs e)
        {
            read_signal_data();
            draw_input_chart();
            draw_voltages_chart();
        }

        private void draw_voltages_chart()
        {
            int i=0;
            foreach (var series in chartVoltages.Series)
            {
                chartVoltages.Series[i].Points.Clear();
                i++;
            }

           
            for (int k = 0; k < input_signal.getResistorVoltage().Count; k++)
            {
                chartVoltages.Series[0].Points.AddXY(k + 1, input_signal.getResistorVoltage()[k]);
            }
            for (int k = 0; k < input_signal.getInductorVoltage().Count; k++)
            {
                chartVoltages.Series[1].Points.AddXY(k + 1, input_signal.getInductorVoltage()[k]);
            }
            for (int k = 0; k < input_signal.getCapacitorVoltage().Count; k++)
            {
                chartVoltages.Series[2].Points.AddXY(k + 1, input_signal.getCapacitorVoltage()[k]);
            }

            for (int k = 0; k < input_signal.our_diode.getDiodeVoltage().Count; k++)
            {
                chartVoltages.Series[3].Points.AddXY(k + 1, input_signal.our_diode.getDiodeVoltage()[k]);
            }

        }


    

    private void draw_input_chart()
        {
            chartInput.Series["Sygnał wejściowy"].Points.Clear();

            for (int i = 0; i < input_signal.getVoltageSignal().Count; i++)
            {
                chartInput.Series["Sygnał wejściowy"].Points.AddXY(i + 1, input_signal.getVoltageSignal()[i]);
            }
        }
        private void read_data()
        {
            C_value = Convert.ToDouble(textBox_C_value.Text);
            L_value = Convert.ToDouble(textBox_L_value.Text);
            R_value = Convert.ToDouble(textBox_R_value.Text);
            deltaU = Int32.Parse(textBox_freq.Text);
            amplitude = Convert.ToDouble(textBox_ampl.Text);
            fill = Int32.Parse(textBox_fill.Text);
        }
        private void read_signal_data()
        {
            read_data();
            if (radioButton_triangle.Checked)
            {
                signal_flag = "triangle";
                input_signal = new signal(deltaU, amplitude, 0, signal_flag, R_value,L_value,C_value);
            }else if (radioButton_sine.Checked)
            {
                signal_flag = "sine";
                input_signal = new signal(deltaU, amplitude, 0, signal_flag, R_value, L_value, C_value);
            }else if (radioButton_square.Checked)
            {
                signal_flag = "square";
                label_fill.Visible = radioButton_square.Checked;
                textBox_fill.Visible = radioButton_square.Checked;
                input_signal = new signal(deltaU, amplitude, fill, signal_flag, R_value, L_value, C_value);
            }
        }

        private void rlc_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
