using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouse
{
    public partial class Karsilama : Form
    {
        Random rnd = new Random();
        int SiraNo,KasaNo;
        public Karsilama()
        {
            InitializeComponent();
            SiraNo= rnd.Next(0,10);
            KasaNo = rnd.Next(0, 2);
            lblSiraNo.Text= SiraNo.ToString();
            tmrSiraNo.Start();
        }

        private void tmrSiraNo_Tick(object sender, EventArgs e)
        {
            if (SiraNo==0)
            {
                tmrSiraNo.Stop();
                DialogResult dr= MessageBox.Show("Siparişinizi Vermek İçin Tamam 'a Tıklayınız..");
                if (dr==DialogResult.OK)
                {
                    Form1 kasa1 = new Form1();
                    kasa1.Show();
                    this.Hide();
                }
            }
            else
            {
                SiraNo -= 1;
                lblSiraNo.Text = SiraNo.ToString();
            }
        }

        private void lblSiraNo_Click(object sender, EventArgs e)
        {

        }
    }
}
