namespace Puzzle_Nume_Prenume
{
    partial class Jucator
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
            this.textBox_NumeJuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Conf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numele jucatorului:";
            // 
            // textBox_NumeJuc
            // 
            this.textBox_NumeJuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumeJuc.Location = new System.Drawing.Point(358, 105);
            this.textBox_NumeJuc.Name = "textBox_NumeJuc";
            this.textBox_NumeJuc.Size = new System.Drawing.Size(273, 29);
            this.textBox_NumeJuc.TabIndex = 1;
            this.textBox_NumeJuc.TextChanged += new System.EventHandler(this.textBox_NumeJuc_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(60, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "JOC NOU";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(60, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "CLASAMENT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(60, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "IESIRE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(236, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Visible = false;
            // 
            // button_Conf
            // 
            this.button_Conf.BackColor = System.Drawing.Color.OliveDrab;
            this.button_Conf.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button_Conf.ForeColor = System.Drawing.Color.LightGreen;
            this.button_Conf.Location = new System.Drawing.Point(236, 156);
            this.button_Conf.Name = "button_Conf";
            this.button_Conf.Size = new System.Drawing.Size(283, 43);
            this.button_Conf.TabIndex = 6;
            this.button_Conf.Text = "Confirma nume";
            this.button_Conf.UseVisualStyleBackColor = false;
            this.button_Conf.Click += new System.EventHandler(this.button4_Click);
            // 
            // Jucator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(747, 416);
            this.Controls.Add(this.button_Conf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_NumeJuc);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Jucator";
            this.Text = "Jucator";
            this.Load += new System.EventHandler(this.Jucator_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NumeJuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Conf;
    }
}