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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string konteyner_id;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nakliye;Integrated Security=True");
            string query1 = "SELECT * FROM konteynerbilgi WHERE konteynerID=" + textBox1.Text;
            DataTable tbl1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            sda1.Fill(tbl1);

            if (tbl1.Rows.Count == 1)
            {
                konteyner_id = textBox1.Text;
                con.Open();
                Form5 frm5 = new Form5();
                frm5.Show();


            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=.;Initial Catalog=nakliye;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * FROM aractablosu";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["aracID"]);
            }
            baglanti.Close();

        }

        public static int aracid;

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nakliye;Integrated Security=True");
            string query1 = "SELECT * FROM konteynerbilgi WHERE aracID=" + comboBox1.SelectedItem.ToString();
            DataTable tbl1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            sda1.Fill(tbl1);

            if (tbl1.Rows.Count >= 1)
            {
                aracid = Convert.ToInt32(comboBox1.SelectedItem);
                con.Open();
                Form7 frm7 = new Form7();
                frm7.Show();


            }

            else MessageBox.Show("Kayıt Bulunamadı!");
        }
    }
}
