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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nakliye;Integrated Security=True");

            string sorgu1 = "SELECT * FROM konteynerbilgi WHERE konteynerID="+Form4.konteyner_id;

            con.Open();

            SqlCommand cmd1 = new SqlCommand(sorgu1, con);

            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                textBox1.Text = read1["konteynerID"].ToString();
                textBox2.Text = read1["aracID"].ToString();
                textBox3.Text = read1["agirlik"].ToString();
                textBox4.Text = read1["yukturu"].ToString();
                dateTimePicker3.Value = Convert.ToDateTime(read1["cikistarih"]);
                dateTimePicker1.Value = Convert.ToDateTime(read1["varistarih"]);
                textBox7.Text = read1["varisyeri"].ToString();
            }
        }

        
    }
}
