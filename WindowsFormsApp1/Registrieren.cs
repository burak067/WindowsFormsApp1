using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Registrieren : Form
    {
        public Registrieren()
        {
            InitializeComponent();
            
        }

        private void Registrieren_Load(object sender, EventArgs e)
        {
            textBox5.Select();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zurueck Button
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = true;
            textBox4.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string vorname = textBox2.Text;
            string email = textBox3.Text;
            string passwort = textBox4.Text;

            String query = "INSERT [User] (Name_User, Vorname_User,Email_User,Passwort_User)" + "VALUES ('" + name + "', '" + vorname + "', '" + email + "', '" + passwort + "')";

            using(SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Semih\Source\Repos\WindowsFormsApp1\WindowsFormsApp1\FManagerDB.mdf; Integrated Security = True"))
            {
                using(SqlCommand sc = new SqlCommand(query, con))
                {
                    con.Open();
                    sc.ExecuteNonQuery();
                }
            }
            
            //sc.CommandType = System.Data.CommandType.Text;
            //sc.CommandText = "INSERT User (Name_User, Vorname_User,Email_User,Passwort_User)" + "VALUES ('" + name + "', '" + vorname + "', '" + email + "', '" + passwort + "')";

            //Registrieren Button
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
