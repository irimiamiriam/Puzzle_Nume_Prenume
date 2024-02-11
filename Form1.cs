using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlTypes;

namespace Puzzle_Nume_Prenume
{
    public partial class Form1 : Form
    {  
        SqlConnection conn= new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\irimiapc2\\OneDrive\\Documente\\GIT\\Git Miriam\\Puzzle_Nume_Prenume\\Clasament.mdf\";Integrated Security=True";
            conn.Open();
            
            SqlCommand cmmd = new SqlCommand("TRUNCATE TABLE Clasament", conn);
            cmmd.ExecuteNonQuery();
            
            string line;
            int id = 1;
            using (FileStream fs = new FileStream("C:\\Users\\irimiapc2\\OneDrive\\Documente\\GIT\\Git Miriam\\Puzzle_Nume_Prenume\\Resurse\\Data\\Clasament.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader file = new StreamReader(@"C:\Users\irimiapc2\OneDrive\Documente\GIT\Git Miriam\Puzzle_Nume_Prenume\Resurse\Data\Clasament.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] fields = line.Split(' ');

                        SqlCommand cmd = new SqlCommand("INSERT INTO Clasament(Id, Nume, Timp, NrPatrate) VALUES (@id, @nume, @timp, @nrpatrate)", conn);
                        cmd.Parameters.AddWithValue("@id", id++);
                        cmd.Parameters.AddWithValue("@nume", fields[0].ToString());
                        cmd.Parameters.AddWithValue("@timp", fields[1].ToString());
                        cmd.Parameters.AddWithValue("@nrpatrate", fields[2].ToString());
                        cmd.ExecuteNonQuery();
                    }
                    file.Close();
                }
            }

            conn.Close();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            if (textBox_Nume.Text == "jucator" && textBox_Parola.Text == "jucator")
            {
                Jucator jucator = new Jucator();
                this.Hide();
                jucator.ShowDialog();
                this.Close();
            }
            else if (textBox_Nume.Text == "administrator" && textBox_Parola.Text == "administrator")
            {
                Administrator administrator = new Administrator();
                this.Hide();
                administrator.ShowDialog();
                this.Close();

            }
            else MessageBox.Show("Introdu date valide");
        }
    }
}
