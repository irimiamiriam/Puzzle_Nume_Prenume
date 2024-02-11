using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Nume_Prenume
{
    public partial class Vizualizare : Form
    {

        public void ToggleButtonVisibility(bool visible)
        {
            button1.Visible = visible;
        }
        public Vizualizare()
        {
            InitializeComponent();
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vizualizare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clasamentDataSet.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.clasamentDataSet.Clasament);
            if (dataGridView1.Columns.Contains("Timp"))
            {
                dataGridView1.Columns["Timp"].SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView1.Sort(dataGridView1.Columns["Timp"], ListSortDirection.Ascending);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\irimiapc2\\OneDrive\\Documente\\GIT\\Git Miriam\\Puzzle_Nume_Prenume\\Clasament.mdf\";Integrated Security=True";
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string num = selectedRow.Cells["Nume"].Value.ToString();
                SqlCommand command = new SqlCommand("DELETE FROM Clasament WHERE CONVERT(NVARCHAR(MAX), Nume) = @nume", conn);
                command.Parameters.AddWithValue("@nume", num);
                conn.Open();
                command.ExecuteNonQuery();
                dataGridView1.Rows.Remove(selectedRow);
                dataGridView1.Refresh();
            }
        }
    }
}
