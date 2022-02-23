using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Seçici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ana forma geçmeden önce ki intronun kapanması için gerekli süreyi
        //tutan değerdir.
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 2)
            {
                timer1.Enabled = false;
                Form2 y = new Form2();
                y.Show();
                this.Hide();
            }
            else
            {
                sayac++;
            }
        }
    }
}
