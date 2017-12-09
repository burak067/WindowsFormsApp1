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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Semih\Source\Repos\WindowsFormsApp1\WindowsFormsApp1\FManagerDB.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM [User] WHERE Email_User ='" + textBox1.Text + "' AND Passwort_User ='" + textBox2.Text + "'", con);
            //Falls Email = textbox1 und passwort= textbox2, dann wird Count(*) auf 1 erhöht, falls nicht bleibt es bei 0
            //User ist wohl in c# ein reserviertes Wort, deshalb in []

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("E-Mail oder Passwort falsch eingegeben");
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
        

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "";

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrieren ss = new Registrieren();
            ss.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
