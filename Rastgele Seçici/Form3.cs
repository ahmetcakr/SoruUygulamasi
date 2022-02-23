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
            label2.Text = Form2.hangisitiklandıs1.ToString();
            richTextBox1.Text = Form2.hangisitiklandi1t.ToString();
        }
    }
}
