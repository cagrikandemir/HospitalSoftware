using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            string Kullanici;

            string sifre;

            Kullanici = txtkad.Text;

            sifre = txtsifre.Text;

            if (Kullanici == "admin" && sifre == "123456")
            {   

                HomePage home = new HomePage();
                home.Show();
                this.Hide();

            }


                else
            {
                label4.Enabled = true;
                label4.Text = "Kullanıcı Adı Veya Şifre Hatalı";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsifre.PasswordChar = '*';
        }
    }
}
