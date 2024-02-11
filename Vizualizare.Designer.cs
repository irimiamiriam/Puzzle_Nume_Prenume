namespace Puzzle_Nume_Prenume
{
    partial class Vizualizare
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clasamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentDataSet = new Puzzle_Nume_Prenume.ClasamentDataSet();
            this.clasamentTableAdapter = new Puzzle_Nume_Prenume.ClasamentDataSetTableAdapters.ClasamentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPatrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Timp,
            this.nrPatrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasamentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(111, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clasamentBindingSource
            // 
            this.clasamentBindingSource.DataMember = "Clasament";
            this.clasamentBindingSource.DataSource = this.clasamentDataSet;
            // 
            // clasamentDataSet
            // 
            this.clasamentDataSet.DataSetName = "ClasamentDataSet";
            this.clasamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasamentTableAdapter
            // 
            this.clasamentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 9.912F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(302, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nume
            // 
            this.Nume.DataPropertyName = "Nume";
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 7;
            this.Nume.Name = "Nume";
            // 
            // Timp
            // 
            this.Timp.DataPropertyName = "Timp";
            this.Timp.HeaderText = "Timp";
            this.Timp.MinimumWidth = 7;
            this.Timp.Name = "Timp";
            this.Timp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nrPatrateDataGridViewTextBoxColumn
            // 
            this.nrPatrateDataGridViewTextBoxColumn.DataPropertyName = "NrPatrate";
            this.nrPatrateDataGridViewTextBoxColumn.HeaderText = "NrPatrate";
            this.nrPatrateDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.nrPatrateDataGridViewTextBoxColumn.Name = "nrPatrateDataGridViewTextBoxColumn";
            // 
            // Vizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(763, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vizualizare";
            this.Text = "Vizualizare";
            this.Load += new System.EventHandler(this.Vizualizare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClasamentDataSet clasamentDataSet;
        private System.Windows.Forms.BindingSource clasamentBindingSource;
        private ClasamentDataSetTableAdapters.ClasamentTableAdapter clasamentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPatrateDataGridViewTextBoxColumn;
    }
}