namespace Puzzle_Nume_Prenume
{
    partial class Administrator
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
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.OliveDrab;
            this.button_Edit.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button_Edit.ForeColor = System.Drawing.Color.LightGreen;
            this.button_Edit.Location = new System.Drawing.Point(218, 143);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(286, 43);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "EDITARE CLASAMENT";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.OliveDrab;
            this.button_Exit.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button_Exit.ForeColor = System.Drawing.Color.LightGreen;
            this.button_Exit.Location = new System.Drawing.Point(218, 206);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(286, 43);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "IESIRE";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(737, 391);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Edit);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Exit;
    }
}