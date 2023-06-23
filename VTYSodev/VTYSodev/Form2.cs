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

namespace VTYSodev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=nakliye;Integrated Security=True");

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "INSERT INTO konteynerbilgi(konteynerID,aracID,cikistarih,varistarih,agirlik,yukturu,varisyeri) values (@konteynerID,@aracID,@cikistarih,@varistarih,@agirlik,@yukturu,@varisyeri)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@konteynerID", textBox11.Text);
                komut.Parameters.AddWithValue("@aracID", aracID);
                komut.Parameters.AddWithValue("@cikistarih", dateTimePicker3.Value);
                komut.Parameters.AddWithValue("@varistarih", dateTimePicker4.Value);
                komut.Parameters.AddWithValue("@agirlik", textBox13.Text);
                komut.Parameters.AddWithValue("@yukturu", comboBox2.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@varisyeri", textBox17.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");

                sahipsiz_konteyner_getir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }




        }

        int aracID;



        void aracIDgetir()
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
                aracID = Convert.ToInt32(dr["aracID"]);
            }
            baglanti.Close();



        }


        private void Form2_Load(object sender, EventArgs e)
        {
            sahipsiz_konteyner_getir();
            sorumlu_oldugum_konteyner_getir();
            aracIDgetir();
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
                comboBox3.Items.Add(dr["aracadi"]);
            }
            baglanti.Close();

        }

        void sahipsiz_konteyner_getir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=.;Initial Catalog=nakliye;Integrated Security=True";

            string query = "SELECT * FROM konteynerbilgi WHERE kullaniciadi IS NULL";

            SqlDataAdapter da = new SqlDataAdapter(query, baglanti);

            DataSet ds = new DataSet();

            baglanti.Open();

            da.Fill(ds, "konteynerbilgi");

            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        void sorumlu_oldugum_konteyner_getir()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=.;Initial Catalog=nakliye;Integrated Security=True";

            string query = "SELECT * FROM konteynerbilgi WHERE kullaniciadi='" + Form1.kullanici_adi + "'";

            SqlDataAdapter da = new SqlDataAdapter(query, baglanti);

            DataSet ds = new DataSet();

            baglanti.Open();

            da.Fill(ds, "konteynerbilgi");

            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string konteynerid;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                konteynerid = row.Cells["konteynerID"].Value.ToString();

                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Data Source=.;Initial Catalog=nakliye;Integrated Security=True";

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        string kayit = "UPDATE konteynerbilgi SET kullaniciadi = '" + Form1.kullanici_adi + "' WHERE konteynerID =" + konteynerid;
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        DialogResult result = MessageBox.Show("Sorumluluk alındı.", "Başarılı!", MessageBoxButtons.OK);

                        sorumlu_oldugum_konteyner_getir();
                        sahipsiz_konteyner_getir();
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string konteynerid;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                konteynerid = row.Cells["konteynerID2"].Value.ToString();

                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Data Source=.;Initial Catalog=nakliye;Integrated Security=True";

                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        string kayit = "UPDATE konteynerbilgi SET kullaniciadi = NULL WHERE konteynerID =" + konteynerid;
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        DialogResult result = MessageBox.Show("Sorumluluk silindi.", "Başarılı!", MessageBoxButtons.OK);

                        sorumlu_oldugum_konteyner_getir();
                        sahipsiz_konteyner_getir();
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
                }


            }

        }
        }

        
    }

