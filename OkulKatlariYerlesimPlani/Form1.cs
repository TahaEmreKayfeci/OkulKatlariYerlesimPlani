using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKatlariYerlesimPlani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            if (txt_kat.Text == "")
            {
                MessageBox.Show("!! DİKKAT !!");
                MessageBox.Show("Lütfen 1 ve 3 Arasında Bir Sayı Giriniz.");
            }
            if (txt_kat.Text == "1")
            {
                lbx_kat.Items.Clear();
                lbx_kat.Items.Add("9-A Sınıfı");
                lbx_kat.Items.Add("9-B Sınıfı");
                lbx_kat.Items.Add("9-C Sınıfı");
                lbx_kat.Items.Add("9-BT Sınıfı");

            }
            if (txt_kat.Text == "2")
            {
                lbx_kat.Items.Clear();
                lbx_kat.Items.Add("10-A Sınıfı");
                lbx_kat.Items.Add("10-B Sınıfı");
                lbx_kat.Items.Add("10-C Sınıfı");
                lbx_kat.Items.Add("10-BT Sınıfı");

            }
            if (txt_kat.Text == "3")
            {
                lbx_kat.Items.Clear();
                lbx_kat.Items.Add("11-A Sınıfı");
                lbx_kat.Items.Add("11-B Sınıfı");
                lbx_kat.Items.Add("11-C Sınıfı");
                lbx_kat.Items.Add("11-BT Sınıfı");

            }
            if (txt_kat.Text == "4")
            {
                lbx_kat.Items.Clear();
                lbx_kat.Items.Add("12-A Sınıfı");
                lbx_kat.Items.Add("12-B Sınıfı");
                lbx_kat.Items.Add("12-C Sınıfı");
                lbx_kat.Items.Add("12-BT Sınıfı");

            }
            
        }
    }
}
