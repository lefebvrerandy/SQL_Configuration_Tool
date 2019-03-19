namespace SQL_Configuration_Tool
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_bin = new System.Windows.Forms.TextBox();
            this.tb_refill = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.cb_skill = new System.Windows.Forms.ComboBox();
            this.btn_store = new System.Windows.Forms.Button();
            this.lb_bin = new System.Windows.Forms.Label();
            this.lb_refill = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_skill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bin Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Refill Bin Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Skill Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time Scale";
            // 
            // tb_bin
            // 
            this.tb_bin.Location = new System.Drawing.Point(304, 68);
            this.tb_bin.Name = "tb_bin";
            this.tb_bin.Size = new System.Drawing.Size(199, 31);
            this.tb_bin.TabIndex = 4;
            // 
            // tb_refill
            // 
            this.tb_refill.Location = new System.Drawing.Point(304, 146);
            this.tb_refill.Name = "tb_refill";
            this.tb_refill.Size = new System.Drawing.Size(199, 31);
            this.tb_refill.TabIndex = 5;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(304, 214);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(199, 31);
            this.tb_time.TabIndex = 7;
            // 
            // cb_skill
            // 
            this.cb_skill.FormattingEnabled = true;
            this.cb_skill.Location = new System.Drawing.Point(304, 283);
            this.cb_skill.Name = "cb_skill";
            this.cb_skill.Size = new System.Drawing.Size(199, 33);
            this.cb_skill.TabIndex = 8;
            // 
            // btn_store
            // 
            this.btn_store.Location = new System.Drawing.Point(304, 356);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(148, 52);
            this.btn_store.TabIndex = 9;
            this.btn_store.Text = "Store Data";
            this.btn_store.UseVisualStyleBackColor = true;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // lb_bin
            // 
            this.lb_bin.AutoSize = true;
            this.lb_bin.ForeColor = System.Drawing.Color.Red;
            this.lb_bin.Location = new System.Drawing.Point(524, 68);
            this.lb_bin.Name = "lb_bin";
            this.lb_bin.Size = new System.Drawing.Size(167, 25);
            this.lb_bin.TabIndex = 10;
            this.lb_bin.Text = "Invalid. ( 1 - 20 )";
            // 
            // lb_refill
            // 
            this.lb_refill.AutoSize = true;
            this.lb_refill.ForeColor = System.Drawing.Color.Red;
            this.lb_refill.Location = new System.Drawing.Point(524, 146);
            this.lb_refill.Name = "lb_refill";
            this.lb_refill.Size = new System.Drawing.Size(167, 25);
            this.lb_refill.TabIndex = 11;
            this.lb_refill.Text = "Invalid. ( 1 - 10 )";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ForeColor = System.Drawing.Color.Red;
            this.lb_time.Location = new System.Drawing.Point(524, 214);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(167, 25);
            this.lb_time.TabIndex = 12;
            this.lb_time.Text = "Invalid. ( 1 - 10 )";
            // 
            // lb_skill
            // 
            this.lb_skill.AutoSize = true;
            this.lb_skill.ForeColor = System.Drawing.Color.Red;
            this.lb_skill.Location = new System.Drawing.Point(524, 283);
            this.lb_skill.Name = "lb_skill";
            this.lb_skill.Size = new System.Drawing.Size(234, 25);
            this.lb_skill.TabIndex = 13;
            this.lb_skill.Text = "Invalid. ( No Selection )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 468);
            this.Controls.Add(this.lb_skill);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_refill);
            this.Controls.Add(this.lb_bin);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.cb_skill);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_refill);
            this.Controls.Add(this.tb_bin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Configuration Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bin;
        private System.Windows.Forms.TextBox tb_refill;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.ComboBox cb_skill;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Label lb_bin;
        private System.Windows.Forms.Label lb_refill;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_skill;
    }
}

