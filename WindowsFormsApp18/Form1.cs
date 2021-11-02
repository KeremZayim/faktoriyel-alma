using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0, faktoriyel = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(tbSayi.Text);
            label1.Text = "";

            if (sayi >= 1)
            {
                if (sayi == 0 || sayi == 1)
                {
                    tbSayi.Text = "1";
                }

                while (sayi >= 1)
                {
                    label1.Text = label1.Text + sayi + "*";
                    faktoriyel = faktoriyel * sayi;
                    sayi--;
                    
                }

                label1.Text += ("=" + faktoriyel);
                listBox1.Items.Clear();
                listBox1.Items.Add(Convert.ToString(faktoriyel));
            }
            else
            {
                MessageBox.Show("Sayı 0'dan Küçük Olamaz!");
            }
        }
    }
}
