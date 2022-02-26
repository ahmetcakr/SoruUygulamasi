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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 30);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form2.btn_kontrol ==1)
            {
                label2.Text = Form2.hangisitiklandıs1.ToString();
                richTextBox1.Text = Form2.hangisitiklandi1t.ToString();
            }
            else if(Form2.btn_kontrol == 2)
            {
                label2.Text = Form2.hangisitiklandıs2.ToString();
                richTextBox1.Text = Form2.hangisitiklandi2t.ToString();
            }
            else if (Form2.btn_kontrol == 3)
            {
                label2.Text = Form2.hangisitiklandıs3.ToString();
                richTextBox1.Text = Form2.hangisitiklandi3t.ToString();
            }


        }


    }
}
