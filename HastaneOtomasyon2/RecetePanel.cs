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

namespace HastaneOtomasyon2
{
    public partial class RecetePanel : Form
    {
        public RecetePanel()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage home=new HomePage();
            home.Show();
            this.Hide();
        }
        ConnectionString Mycon = new ConnectionString();
        private void fillHasta()
        {
            SqlConnection baglanti = Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HAd from HastaTBL ", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HAd", typeof(string));
            dt.Load(rdr);
            comboadsoyad.ValueMember = "HAd";
            comboadsoyad.DataSource = dt;
            baglanti.Close();
        }
        private void fillTedavi()
        {
            SqlConnection baglanti = Mycon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from RandevuTBL where Hasta='"+comboadsoyad.SelectedValue.ToString()+"' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txttedaviad.Text = dr["Tedavi"].ToString();
            }
            baglanti.Close();
        }
        private void RecetePanel_Load(object sender, EventArgs e)
        {
            fillHasta();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

        }

        private void comboadsoyad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillTedavi();
        }
    }
}
