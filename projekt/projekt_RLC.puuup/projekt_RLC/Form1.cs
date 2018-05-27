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

        }

        private void label_counter_Click(object sender, EventArgs e)
        {

        }



        private void button_save_values_Click(object sender, EventArgs e)
        {
            C_value = Convert.ToDouble(textBox_C_value.Text);
            L_value = Convert.ToDouble(textBox_L_value.Text);
            R_value = Convert.ToDouble(textBox_R_value.Text);
        }
    }
}
