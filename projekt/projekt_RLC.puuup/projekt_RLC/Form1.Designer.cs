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
            this.SuspendLayout();
            // 
            // timer_main
            // 
            this.timer_main.Interval = 10;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(91, 78);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Location = new System.Drawing.Point(25, 104);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(56, 17);
            this.label_counter.TabIndex = 1;
            this.label_counter.Text = "counter";
            this.label_counter.Click += new System.EventHandler(this.label_counter_Click);
            // 
            // button_save_values
            // 
            this.button_save_values.Location = new System.Drawing.Point(105, 104);
            this.button_save_values.Name = "button_save_values";
            this.button_save_values.Size = new System.Drawing.Size(130, 27);
            this.button_save_values.TabIndex = 2;
            this.button_save_values.Text = "Przepisz dane";
            this.button_save_values.UseVisualStyleBackColor = true;
            this.button_save_values.Click += new System.EventHandler(this.button_save_values_Click);
            // 
            // textBox_R_value
            // 
            this.textBox_R_value.Location = new System.Drawing.Point(137, 12);
            this.textBox_R_value.Name = "textBox_R_value";
            this.textBox_R_value.Size = new System.Drawing.Size(100, 22);
            this.textBox_R_value.TabIndex = 3;
            this.textBox_R_value.Text = "10";
            // 
            // textBox_L_value
            // 
            this.textBox_L_value.Location = new System.Drawing.Point(137, 41);
            this.textBox_L_value.Name = "textBox_L_value";
            this.textBox_L_value.Size = new System.Drawing.Size(100, 22);
            this.textBox_L_value.TabIndex = 4;
            this.textBox_L_value.Text = "10";
            // 
            // textBox_C_value
            // 
            this.textBox_C_value.Location = new System.Drawing.Point(137, 70);
            this.textBox_C_value.Name = "textBox_C_value";
            this.textBox_C_value.Size = new System.Drawing.Size(100, 22);
            this.textBox_C_value.TabIndex = 5;
            this.textBox_C_value.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "R=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "L=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "C=";
            // 
            // RLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_C_value);
            this.Controls.Add(this.textBox_L_value);
            this.Controls.Add(this.textBox_R_value);
            this.Controls.Add(this.button_save_values);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.button_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RLC";
            this.Text = "RLC";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

