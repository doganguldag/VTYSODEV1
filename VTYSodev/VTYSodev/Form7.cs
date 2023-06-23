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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=.;Initial Catalog=nakliye;Integrated Security=True";

            string query = "SELECT * FROM konteynerbilgi WHERE aracID="+Form4.aracid;

            SqlDataAdapter da = new SqlDataAdapter(query, baglanti);

            DataSet ds = new DataSet();

            baglanti.Open();

            da.Fill(ds, "konteynerbilgi");

            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
