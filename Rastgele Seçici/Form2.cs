using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Data.OleDb;
namespace Rastgele_Seçici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int ogrencisayisi = 1;
        bool sart1 = false, sart2 = false, sart3 = false;
        string[] soru_dizisi;
        string dosyayolu;
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbox_ogrsayi.Text) >= 1 && Convert.ToInt32(txtbox_ogrsayi.Text) <= 40)
            {
                messagegizle();
                sart1 = true;
                ogrencisayisi = Convert.ToInt32(txtbox_ogrsayi.Text);
                if (ogrencisayisi == 1)
                {
                    s1n1_btn.Visible = true;
                }
                else if (ogrencisayisi == 2)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                }
                else if (ogrencisayisi == 3)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                }
                else if (ogrencisayisi == 4)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                }
                else if (ogrencisayisi == 5)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                }
                else if (ogrencisayisi == 6)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                }
                else if (ogrencisayisi == 7)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                }
                else if (ogrencisayisi == 8)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                }
                else if (ogrencisayisi == 9)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                }
                else if (ogrencisayisi == 10)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                }
                else if (ogrencisayisi == 11)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                }
                else if (ogrencisayisi == 12)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                }
                else if (ogrencisayisi == 13)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                }
                else if (ogrencisayisi == 14)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                }
                else if (ogrencisayisi == 15)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                }
                else if (ogrencisayisi == 16)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                }
                else if (ogrencisayisi == 17)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                }
                else if (ogrencisayisi == 18)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                }
                else if (ogrencisayisi == 19)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                }
                else if (ogrencisayisi == 20)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                }
                else if (ogrencisayisi == 21)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                }
                else if (ogrencisayisi == 22)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                }
                else if (ogrencisayisi == 23)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                }
                else if (ogrencisayisi == 24)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                }
                else if (ogrencisayisi == 25)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                }
                else if (ogrencisayisi == 26)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                }
                else if (ogrencisayisi == 27)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                }
                else if (ogrencisayisi == 28)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                }
                else if (ogrencisayisi == 29)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;

                }
                else if (ogrencisayisi == 30)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                }
                else if (ogrencisayisi == 31)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                }
                else if (ogrencisayisi == 32)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                }
                else if (ogrencisayisi == 33)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                }
                else if (ogrencisayisi == 34)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                }
                else if (ogrencisayisi == 35)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                    s1n35_btn.Visible = true;
                }
                else if (ogrencisayisi == 36)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                    s1n35_btn.Visible = true;
                    s1n36_btn.Visible = true;
                }
                else if (ogrencisayisi == 37)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                    s1n35_btn.Visible = true;
                    s1n36_btn.Visible = true;
                    s1n37_btn.Visible = true;
                }
                else if (ogrencisayisi == 38)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                    s1n35_btn.Visible = true;
                    s1n36_btn.Visible = true;
                    s1n37_btn.Visible = true;
                    s1n38_btn.Visible = true;
                }
                else if (ogrencisayisi == 39)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                    s1n35_btn.Visible = true;
                    s1n36_btn.Visible = true;
                    s1n37_btn.Visible = true;
                    s1n38_btn.Visible = true;
                    s1n39_btn.Visible = true;
                }
                else if (ogrencisayisi == 40)
                {
                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;
                    s1n10_btn.Visible = true;
                    s1n11_btn.Visible = true;
                    s1n12_btn.Visible = true;
                    s1n13_btn.Visible = true;
                    s1n14_btn.Visible = true;
                    s1n15_btn.Visible = true;
                    s1n16_btn.Visible = true;
                    s1n17_btn.Visible = true;
                    s1n18_btn.Visible = true;
                    s1n19_btn.Visible = true;
                    s1n20_btn.Visible = true;
                    s1n21_btn.Visible = true;
                    s1n22_btn.Visible = true;
                    s1n23_btn.Visible = true;
                    s1n24_btn.Visible = true;
                    s1n25_btn.Visible = true;
                    s1n26_btn.Visible = true;
                    s1n27_btn.Visible = true;
                    s1n28_btn.Visible = true;
                    s1n29_btn.Visible = true;
                    s1n30_btn.Visible = true;
                    s1n31_btn.Visible = true;
                    s1n32_btn.Visible = true;
                    s1n33_btn.Visible = true;
                    s1n34_btn.Visible = true;
                    s1n35_btn.Visible = true;
                    s1n36_btn.Visible = true;
                    s1n37_btn.Visible = true;
                    s1n38_btn.Visible = true;
                    s1n39_btn.Visible = true;
                    s1n40_btn.Visible = true;
                }
                if (sart1 == true && sart2 == true && sart3 == true)
                {
                    tabControl1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen 1 ile 40 arası rakam giriniz.", "Rastgele Seçici");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            messagegizle();
        }
        void messagegizle()
        {
            s1n1_btn.Visible = false;
            s1n2_btn.Visible = false;
            s1n3_btn.Visible = false;
            s1n4_btn.Visible = false;
            s1n5_btn.Visible = false;
            s1n6_btn.Visible = false;
            s1n7_btn.Visible = false;
            s1n8_btn.Visible = false;
            s1n9_btn.Visible = false;
            s1n10_btn.Visible = false;
            s1n11_btn.Visible = false;
            s1n12_btn.Visible = false;
            s1n13_btn.Visible = false;
            s1n14_btn.Visible = false;
            s1n15_btn.Visible = false;
            s1n16_btn.Visible = false;
            s1n17_btn.Visible = false;
            s1n18_btn.Visible = false;
            s1n19_btn.Visible = false;
            s1n20_btn.Visible = false;
            s1n21_btn.Visible = false;
            s1n22_btn.Visible = false;
            s1n23_btn.Visible = false;
            s1n24_btn.Visible = false;
            s1n25_btn.Visible = false;
            s1n26_btn.Visible = false;
            s1n27_btn.Visible = false;
            s1n28_btn.Visible = false;
            s1n29_btn.Visible = false;
            s1n30_btn.Visible = false;
            s1n31_btn.Visible = false;
            s1n32_btn.Visible = false;
            s1n33_btn.Visible = false;
            s1n34_btn.Visible = false;
            s1n35_btn.Visible = false;
            s1n36_btn.Visible = false;
            s1n37_btn.Visible = false;
            s1n38_btn.Visible = false;
            s1n39_btn.Visible = false;
            s1n40_btn.Visible = false;
        }

        private void txtbox_ogrsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void s1n1_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 1;       
            s1n1_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();            
        }

        private void s1n9_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 9;
            s1n9_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();
            
        }

        private void s1n17_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 17;
            s1n17_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();
          
        }

        private void s1n5_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 5;
            s1n5_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();      
        }

        private void s1n31_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 31;
            s1n31_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n40_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 40;
            s1n40_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();      
        }

        private void s1n33_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 33;
            s1n33_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n32_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 32;
            s1n32_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n6_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 6;
            s1n6_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n18_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 18;
            s1n18_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n10_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 10;
            s1n10_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n13_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 13;
            s1n13_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();      
        }

        private void s1n19_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 19;
            s1n19_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n25_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 25;
            s1n25_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n35_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 35;
            s1n35_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();      
        }

        private void s1n36_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 36;
            s1n36_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n2_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 2;
            s1n2_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n26_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 26;
            s1n26_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n20_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 20;
            s1n20_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n14_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 14;
            s1n14_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();    
        }

        private void s1n15_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 15;
            s1n15_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n21_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 21;
            s1n21_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n27_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 27;
            s1n27_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n3_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 3;
            s1n3_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();         
        }

        private void s1n37_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 37;
            s1n37_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();  
        }

        private void s1n38_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 38;
            s1n38_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n4_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 4;
            s1n4_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();       
        }

        private void s1n28_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 28;
            s1n28_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n22_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 22;
            s1n22_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();          
        }

        private void s1n16_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 16;
            s1n16_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();   
        }

        private void s1n11_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 11;
            s1n11_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n23_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 23;
            s1n23_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();  
        }

        private void s1n7_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 7;
            s1n7_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n29_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 29;
            s1n29_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();          
        }

        private void s1n39_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 39;
            s1n39_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();   
        }

        private void s1n34_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 34;
            s1n34_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();    
        }

        private void s1n30_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 30;
            s1n30_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();     
        }

        private void s1n8_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 8;
            s1n8_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void s1n24_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 24;
            s1n24_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void s1n12_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 12;
            s1n12_btn.Image = Rastgele_Seçici.Properties.Resources._1;
            sormetot();      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sart3 == true)
            {
                
                    using (OpenFileDialog dlg = new OpenFileDialog())

                    {
                        dlg.Title = "Excel Dosyasını Seçiniz..";
                        dlg.Filter = "Excel Files (*.xlsx)|*.XLSX";
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            string sFileName = dlg.FileName;
                            dosyayolu = sFileName;
                            label2.Text = "Excel Dosyası Seçildi.";
                        //



                        string dosya_adres = dosyayolu; 
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                        con.Open();
                        string sql = "SELECT * from [Sayfa1$A1:A5000] ";
                        OleDbCommand veri2 = new OleDbCommand(sql, con); 
                        OleDbDataReader dr = null;
                        dr = veri2.ExecuteReader();

                        while (dr.Read())
                        {
                            if (dr[0] != "")
                            {
                                listBox1.Items.Add(dr[0].ToString());
                            }
                            else
                            {
                                break;
                            }
                        }
                        con.Close();

                        //

                        Random r = new Random();
                        int listbox = r.Next(0, listBox1.Items.Count);
                        listBox1.SelectedIndex += listbox;

                        soru_dizisi = new string[listBox1.Items.Count];
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            soru_dizisi[i] = listBox1.Items[i].ToString();
                        }

                        //

                    }
                    }
                try
                {
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya Seçilemedi!", "Rastgele Seçici");
                }
                sart2 = true;

                if (sart1 == true && sart2 == true && sart3 == true)
                {
                    tabControl1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce soru adedini tanımlayınız!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sart3 == false)
            {
                sart3 = true;
            }
            else
            {
                sart3=false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(textsoruadedi.Text) < 1 || Convert.ToInt32(textsoruadedi.Text) > 400)
            {
                MessageBox.Show("Soru Adedi 1 ila 400 arası olmalıdır.", "Rastgele Seçici");
            }
            else
            {
                sart3 = true;
                if (sart1 == true && sart2 == true && sart3 == true)
                {
                    tabControl1.Enabled = true;
                }
            }
        }

        //

        static public int hangisitiklandıs1 = 0;
        static public string hangisitiklandi1t= "";
        public void sormetot()
        {
            try
            {
                hangisitiklandi1t = soru_dizisi[hangisitiklandıs1 - 1];
                Form3 y = new Form3();
                y.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Üzgünüz soru sayınız yetersiz! Maksimum soru sayınız : " + (listBox1.Items.Count + 1) +"'dir. Lütfen öğrenci sayınızı bu rakam olacak şekilde güncelleyiniz.","Rastgele Seçici");
                
            }
          

        }
    }
}
