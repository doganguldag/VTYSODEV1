using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYSodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string kullanici_adi;

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nakliye;Integrated Security=True");
            string query1 = "SELECT * FROM personel WHERE kullaniciadi='" + textBox1.Text.Trim() + "' AND sifre='" + textBox2.Text.Trim() + "'";
            DataTable tbl1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            sda1.Fill(tbl1);
            if (tbl1.Rows.Count == 1)
            {
                kullanici_adi = textBox1.Text;
                con.Open();
                Form2 frm2 = new Form2();
                frm2.Show();
            }

            else MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;

            textBox2.PasswordChar = '•';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            textBox2.PasswordChar = '\0';
        }

       
    }
}
