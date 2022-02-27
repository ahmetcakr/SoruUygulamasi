﻿using System;
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
        bool sart1 = false, sart2 = false;
        string[] soru_dizisi1;
        string[] soru_dizisi2;
        string[] soru_dizisi3;
        string dosyayolu;
        int maxsoru;
        bool reset = false;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reset==false)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }

            }
            else
            {

            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbox_ogrsayi.Text) >= 1 && Convert.ToInt32(txtbox_ogrsayi.Text) <= maxsoru)
            {
                messagegizle();
                messagenumbergizle();
                sart1 = true;
                ogrencisayisi = Convert.ToInt32(txtbox_ogrsayi.Text);
                if (ogrencisayisi == 1)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n1_txt.Visible = true;

                    s2n1_btn.Visible = true;
                    s2n1_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n1_txt.Visible = true;
                }
                else if (ogrencisayisi == 2)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;

                    // Sayfa 2 buton ve sayı gizlenmesi

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;

                    // page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                }
                else if (ogrencisayisi == 3)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;

                    // Sayfa 2 buton ve sayı gizlenmesi

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;

                    //page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                }
                else if (ogrencisayisi == 4)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;

                    //
                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;



                }
                else if (ogrencisayisi == 5)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;



                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;


                }
                else if (ogrencisayisi == 6)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;

                    //page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;

                }
                else if (ogrencisayisi == 7)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    //page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                }
                else if (ogrencisayisi == 8)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    //page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n8_txt.Visible = true;

                }
                else if (ogrencisayisi == 9)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

                    s1n1_btn.Visible = true;
                    s1n2_btn.Visible = true;
                    s1n3_btn.Visible = true;
                    s1n4_btn.Visible = true;
                    s1n5_btn.Visible = true;
                    s1n6_btn.Visible = true;
                    s1n7_btn.Visible = true;
                    s1n8_btn.Visible = true;
                    s1n9_btn.Visible = true;

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                }
                else if (ogrencisayisi == 10)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;

                    //page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                }
                else if (ogrencisayisi == 11)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;

                    //page 3 

                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                }
                else if (ogrencisayisi == 12)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;

                }
                else if (ogrencisayisi == 13)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                }
                else if (ogrencisayisi == 14)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                }
                else if (ogrencisayisi == 15)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                }
                else if (ogrencisayisi == 16)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                }
                else if (ogrencisayisi == 17)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;


                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                }
                else if (ogrencisayisi == 18)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                }
                else if (ogrencisayisi == 19)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;


                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                }
                else if (ogrencisayisi == 20)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                }
                else if (ogrencisayisi == 21)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                }
                else if (ogrencisayisi == 22)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;


                }
                else if (ogrencisayisi == 23)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;

                }
                else if (ogrencisayisi == 24)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;

                }
                else if (ogrencisayisi == 25)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;

                }
                else if (ogrencisayisi == 26)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;

                }
                else if (ogrencisayisi == 27)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;

                }
                else if (ogrencisayisi == 28)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;

                    s2n40_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;

                }
                else if (ogrencisayisi == 29)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;

                }
                else if (ogrencisayisi == 30)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;

                }
                else if (ogrencisayisi == 31)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;

                }
                else if (ogrencisayisi == 32)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;

                }
                else if (ogrencisayisi == 33)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;

                }
                else if (ogrencisayisi == 34)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;

                }
                else if (ogrencisayisi == 35)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;
                    s1n35_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;
                    s2n35_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;
                    s2n34_txt.Visible = true;
                    s2n35_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;
                    s3n35_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;
                    s3n35_txt.Visible = true;

                }
                else if (ogrencisayisi == 36)
                {
                    //sayfa1 buton ve sayıların gizlenmesi

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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;
                    s1n35_txt.Visible = true;
                    s1n36_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;
                    s2n35_btn.Visible = true;
                    s2n36_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;
                    s2n34_txt.Visible = true;
                    s2n35_txt.Visible = true;
                    s2n36_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;
                    s3n35_btn.Visible = true;
                    s3n36_btn.Visible = true;

                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;
                    s3n35_txt.Visible = true;
                    s3n36_txt.Visible = true;

                }
                else if (ogrencisayisi == 37)
                {
                    //sayfa1 buton ve sayıların gizlenmesi
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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;
                    s1n35_txt.Visible = true;
                    s1n36_txt.Visible = true;
                    s1n37_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;
                    s2n35_btn.Visible = true;
                    s2n36_btn.Visible = true;
                    s2n37_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;
                    s2n34_txt.Visible = true;
                    s2n35_txt.Visible = true;
                    s2n36_txt.Visible = true;
                    s2n37_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;
                    s3n35_btn.Visible = true;
                    s3n36_btn.Visible = true;
                    s3n37_btn.Visible = true;


                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;
                    s3n35_txt.Visible = true;
                    s3n36_txt.Visible = true;
                    s3n37_txt.Visible = true;

                }
                else if (ogrencisayisi == 38)
                {
                    //sayfa1 buton ve sayıların gizlenmesi
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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;
                    s1n35_txt.Visible = true;
                    s1n36_txt.Visible = true;
                    s1n37_txt.Visible = true;
                    s1n38_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;
                    s2n35_btn.Visible = true;
                    s2n36_btn.Visible = true;
                    s2n37_btn.Visible = true;
                    s2n38_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;
                    s2n34_txt.Visible = true;
                    s2n35_txt.Visible = true;
                    s2n36_txt.Visible = true;
                    s2n37_txt.Visible = true;
                    s2n38_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;
                    s3n35_btn.Visible = true;
                    s3n36_btn.Visible = true;
                    s3n37_btn.Visible = true;
                    s3n38_btn.Visible = true;


                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;
                    s3n35_txt.Visible = true;
                    s3n36_txt.Visible = true;
                    s3n37_txt.Visible = true;
                    s3n38_txt.Visible = true;

                }
                else if (ogrencisayisi == 39)
                {
                    //sayfa1 buton ve sayıların göserilmesi
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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;
                    s1n35_txt.Visible = true;
                    s1n36_txt.Visible = true;
                    s1n37_txt.Visible = true;
                    s1n38_txt.Visible = true;
                    s1n39_txt.Visible = true;

                    //

                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;
                    s2n35_btn.Visible = true;
                    s2n36_btn.Visible = true;
                    s2n37_btn.Visible = true;
                    s2n38_btn.Visible = true;
                    s2n39_btn.Visible = true;


                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;
                    s2n34_txt.Visible = true;
                    s2n35_txt.Visible = true;
                    s2n36_txt.Visible = true;
                    s2n37_txt.Visible = true;
                    s2n38_txt.Visible = true;
                    s2n39_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;
                    s3n35_btn.Visible = true;
                    s3n36_btn.Visible = true;
                    s3n37_btn.Visible = true;
                    s3n38_btn.Visible = true;
                    s3n39_btn.Visible = true;


                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;
                    s3n35_txt.Visible = true;
                    s3n36_txt.Visible = true;
                    s3n37_txt.Visible = true;
                    s3n38_txt.Visible = true;
                    s3n39_txt.Visible = true;

                }
                else if (ogrencisayisi == 40)
                {
                    //sayfa1 buton ve sayıların gösterilmesi
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

                    s1n1_txt.Visible = true;
                    s1n2_txt.Visible = true;
                    s1n3_txt.Visible = true;
                    s1n4_txt.Visible = true;
                    s1n5_txt.Visible = true;
                    s1n6_txt.Visible = true;
                    s1n7_txt.Visible = true;
                    s1n8_txt.Visible = true;
                    s1n9_txt.Visible = true;
                    s1n10_txt.Visible = true;
                    s1n11_txt.Visible = true;
                    s1n12_txt.Visible = true;
                    s1n13_txt.Visible = true;
                    s1n14_txt.Visible = true;
                    s1n15_txt.Visible = true;
                    s1n16_txt.Visible = true;
                    s1n17_txt.Visible = true;
                    s1n18_txt.Visible = true;
                    s1n19_txt.Visible = true;
                    s1n20_txt.Visible = true;
                    s1n21_txt.Visible = true;
                    s1n22_txt.Visible = true;
                    s1n23_txt.Visible = true;
                    s1n24_txt.Visible = true;
                    s1n25_txt.Visible = true;
                    s1n26_txt.Visible = true;
                    s1n27_txt.Visible = true;
                    s1n28_txt.Visible = true;
                    s1n29_txt.Visible = true;
                    s1n30_txt.Visible = true;
                    s1n31_txt.Visible = true;
                    s1n32_txt.Visible = true;
                    s1n33_txt.Visible = true;
                    s1n34_txt.Visible = true;
                    s1n35_txt.Visible = true;
                    s1n36_txt.Visible = true;
                    s1n37_txt.Visible = true;
                    s1n38_txt.Visible = true;
                    s1n39_txt.Visible = true;
                    s1n40_txt.Visible = true;


                    //



                    s2n1_btn.Visible = true;
                    s2n2_btn.Visible = true;
                    s2n3_btn.Visible = true;
                    s2n4_btn.Visible = true;
                    s2n5_btn.Visible = true;
                    s2n6_btn.Visible = true;
                    s2n7_btn.Visible = true;
                    s2n8_btn.Visible = true;
                    s2n9_btn.Visible = true;
                    s2n10_btn.Visible = true;
                    s2n11_btn.Visible = true;
                    s2n12_btn.Visible = true;
                    s2n13_btn.Visible = true;
                    s2n14_btn.Visible = true;
                    s2n15_btn.Visible = true;
                    s2n16_btn.Visible = true;
                    s2n17_btn.Visible = true;
                    s2n18_btn.Visible = true;
                    s2n19_btn.Visible = true;
                    s2n20_btn.Visible = true;
                    s2n21_btn.Visible = true;
                    s2n22_btn.Visible = true;
                    s2n23_btn.Visible = true;
                    s2n24_btn.Visible = true;
                    s2n25_btn.Visible = true;
                    s2n26_btn.Visible = true;
                    s2n27_btn.Visible = true;
                    s2n28_btn.Visible = true;
                    s2n29_btn.Visible = true;
                    s2n30_btn.Visible = true;
                    s2n31_btn.Visible = true;
                    s2n32_btn.Visible = true;
                    s2n33_btn.Visible = true;
                    s2n34_btn.Visible = true;
                    s2n35_btn.Visible = true;
                    s2n36_btn.Visible = true;
                    s2n37_btn.Visible = true;
                    s2n38_btn.Visible = true;
                    s2n39_btn.Visible = true;
                    s2n40_btn.Visible = true;

                    s2n1_txt.Visible = true;
                    s2n2_txt.Visible = true;
                    s2n3_txt.Visible = true;
                    s2n4_txt.Visible = true;
                    s2n5_txt.Visible = true;
                    s2n6_txt.Visible = true;
                    s2n7_txt.Visible = true;
                    s2n8_txt.Visible = true;
                    s2n9_txt.Visible = true;
                    s2n10_txt.Visible = true;
                    s2n11_txt.Visible = true;
                    s2n12_txt.Visible = true;
                    s2n13_txt.Visible = true;
                    s2n14_txt.Visible = true;
                    s2n15_txt.Visible = true;
                    s2n16_txt.Visible = true;
                    s2n17_txt.Visible = true;
                    s2n18_txt.Visible = true;
                    s2n19_txt.Visible = true;
                    s2n20_txt.Visible = true;
                    s2n21_txt.Visible = true;
                    s2n22_txt.Visible = true;
                    s2n23_txt.Visible = true;
                    s2n24_txt.Visible = true;
                    s2n25_txt.Visible = true;
                    s2n26_txt.Visible = true;
                    s2n27_txt.Visible = true;
                    s2n28_txt.Visible = true;
                    s2n29_txt.Visible = true;
                    s2n30_txt.Visible = true;
                    s2n31_txt.Visible = true;
                    s2n32_txt.Visible = true;
                    s2n33_txt.Visible = true;
                    s2n34_txt.Visible = true;
                    s2n35_txt.Visible = true;
                    s2n36_txt.Visible = true;
                    s2n37_txt.Visible = true;
                    s2n38_txt.Visible = true;
                    s2n39_txt.Visible = true;
                    s2n40_txt.Visible = true;

                    // page 3 
                    s3n1_btn.Visible = true;
                    s3n2_btn.Visible = true;
                    s3n3_btn.Visible = true;
                    s3n4_btn.Visible = true;
                    s3n5_btn.Visible = true;
                    s3n6_btn.Visible = true;
                    s3n7_btn.Visible = true;
                    s3n8_btn.Visible = true;
                    s3n9_btn.Visible = true;
                    s3n10_btn.Visible = true;
                    s3n11_btn.Visible = true;
                    s3n12_btn.Visible = true;
                    s3n13_btn.Visible = true;
                    s3n14_btn.Visible = true;
                    s3n15_btn.Visible = true;
                    s3n16_btn.Visible = true;
                    s3n17_btn.Visible = true;
                    s3n18_btn.Visible = true;
                    s3n19_btn.Visible = true;
                    s3n20_btn.Visible = true;
                    s3n21_btn.Visible = true;
                    s3n22_btn.Visible = true;
                    s3n23_btn.Visible = true;
                    s3n24_btn.Visible = true;
                    s3n25_btn.Visible = true;
                    s3n26_btn.Visible = true;
                    s3n27_btn.Visible = true;
                    s3n28_btn.Visible = true;
                    s3n29_btn.Visible = true;
                    s3n30_btn.Visible = true;
                    s3n31_btn.Visible = true;
                    s3n32_btn.Visible = true;
                    s3n33_btn.Visible = true;
                    s3n34_btn.Visible = true;
                    s3n35_btn.Visible = true;
                    s3n36_btn.Visible = true;
                    s3n37_btn.Visible = true;
                    s3n38_btn.Visible = true;
                    s3n39_btn.Visible = true;
                    s3n40_btn.Visible = true;


                    s3n1_txt.Visible = true;
                    s3n2_txt.Visible = true;
                    s3n3_txt.Visible = true;
                    s3n4_txt.Visible = true;
                    s3n5_txt.Visible = true;
                    s3n6_txt.Visible = true;
                    s3n7_txt.Visible = true;
                    s3n8_txt.Visible = true;
                    s3n9_txt.Visible = true;
                    s3n10_txt.Visible = true;
                    s3n11_txt.Visible = true;
                    s3n12_txt.Visible = true;
                    s3n13_txt.Visible = true;
                    s3n14_txt.Visible = true;
                    s3n15_txt.Visible = true;
                    s3n16_txt.Visible = true;
                    s3n17_txt.Visible = true;
                    s3n18_txt.Visible = true;
                    s3n19_txt.Visible = true;
                    s3n20_txt.Visible = true;
                    s3n21_txt.Visible = true;
                    s3n22_txt.Visible = true;
                    s3n23_txt.Visible = true;
                    s3n24_txt.Visible = true;
                    s3n25_txt.Visible = true;
                    s3n26_txt.Visible = true;
                    s3n27_txt.Visible = true;
                    s3n28_txt.Visible = true;
                    s3n29_txt.Visible = true;
                    s3n30_txt.Visible = true;
                    s3n31_txt.Visible = true;
                    s3n32_txt.Visible = true;
                    s3n33_txt.Visible = true;
                    s3n34_txt.Visible = true;
                    s3n35_txt.Visible = true;
                    s3n36_txt.Visible = true;
                    s3n37_txt.Visible = true;
                    s3n38_txt.Visible = true;
                    s3n39_txt.Visible = true;
                    s3n40_txt.Visible = true;


                }
                if (sart1 == true && sart2 == true)
                {
                    tabControl1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen 1 ila " + maxsoru.ToString() + " arası rakam giriniz.", "Rastgele Seçici");
            }
        }
        public void controller()
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            button1.Enabled = false;
            label45.Enabled = false;
            messagegizle();
            messagenumbergizle();
            listBox2.Visible = false;
            listBox3.Visible = false;
            controller();
            txtbox_ogrsayi.ReadOnly = true;
        }
        void messagenumbergizle()
        {
            //sayfa1 butonların sayılarını değiştirmesi
            s1n1_txt.Visible = false;
            s1n2_txt.Visible = false;
            s1n3_txt.Visible = false;
            s1n4_txt.Visible = false;
            s1n5_txt.Visible = false;
            s1n6_txt.Visible = false;
            s1n7_txt.Visible = false;
            s1n8_txt.Visible = false;
            s1n9_txt.Visible = false;
            s1n10_txt.Visible = false;
            s1n11_txt.Visible = false;
            s1n12_txt.Visible = false;
            s1n13_txt.Visible = false;
            s1n14_txt.Visible = false;
            s1n15_txt.Visible = false;
            s1n16_txt.Visible = false;
            s1n17_txt.Visible = false;
            s1n18_txt.Visible = false;
            s1n19_txt.Visible = false;
            s1n20_txt.Visible = false;
            s1n21_txt.Visible = false;
            s1n22_txt.Visible = false;
            s1n23_txt.Visible = false;
            s1n24_txt.Visible = false;
            s1n25_txt.Visible = false;
            s1n26_txt.Visible = false;
            s1n27_txt.Visible = false;
            s1n28_txt.Visible = false;
            s1n29_txt.Visible = false;
            s1n30_txt.Visible = false;
            s1n31_txt.Visible = false;
            s1n32_txt.Visible = false;
            s1n33_txt.Visible = false;
            s1n34_txt.Visible = false;
            s1n35_txt.Visible = false;
            s1n36_txt.Visible = false;
            s1n37_txt.Visible = false;
            s1n38_txt.Visible = false;
            s1n39_txt.Visible = false;
            s1n40_txt.Visible = false;


            s2n1_txt.Visible = false;
            s2n2_txt.Visible = false;
            s2n3_txt.Visible = false;
            s2n4_txt.Visible = false;
            s2n5_txt.Visible = false;
            s2n6_txt.Visible = false;
            s2n7_txt.Visible = false;
            s2n8_txt.Visible = false;
            s2n9_txt.Visible = false;
            s2n10_txt.Visible = false;
            s2n11_txt.Visible = false;
            s2n12_txt.Visible = false;
            s2n13_txt.Visible = false;
            s2n14_txt.Visible = false;
            s2n15_txt.Visible = false;
            s2n16_txt.Visible = false;
            s2n17_txt.Visible = false;
            s2n18_txt.Visible = false;
            s2n19_txt.Visible = false;
            s2n20_txt.Visible = false;
            s2n21_txt.Visible = false;
            s2n22_txt.Visible = false;
            s2n23_txt.Visible = false;
            s2n24_txt.Visible = false;
            s2n25_txt.Visible = false;
            s2n26_txt.Visible = false;
            s2n27_txt.Visible = false;
            s2n28_txt.Visible = false;
            s2n29_txt.Visible = false;
            s2n30_txt.Visible = false;
            s2n31_txt.Visible = false;
            s2n32_txt.Visible = false;
            s2n33_txt.Visible = false;
            s2n34_txt.Visible = false;
            s2n35_txt.Visible = false;
            s2n36_txt.Visible = false;
            s2n37_txt.Visible = false;
            s2n38_txt.Visible = false;
            s2n39_txt.Visible = false;
            s2n40_txt.Visible = false;

            //page 3 txt 

            s3n1_txt.Visible = false;
            s3n2_txt.Visible = false;
            s3n3_txt.Visible = false;
            s3n4_txt.Visible = false;
            s3n5_txt.Visible = false;
            s3n6_txt.Visible = false;
            s3n7_txt.Visible = false;
            s3n8_txt.Visible = false;
            s3n9_txt.Visible = false;
            s3n10_txt.Visible = false;
            s3n11_txt.Visible = false;
            s3n12_txt.Visible = false;
            s3n13_txt.Visible = false;
            s3n14_txt.Visible = false;
            s3n15_txt.Visible = false;
            s3n16_txt.Visible = false;
            s3n17_txt.Visible = false;
            s3n18_txt.Visible = false;
            s3n19_txt.Visible = false;
            s3n20_txt.Visible = false;
            s3n21_txt.Visible = false;
            s3n22_txt.Visible = false;
            s3n23_txt.Visible = false;
            s3n24_txt.Visible = false;
            s3n25_txt.Visible = false;
            s3n26_txt.Visible = false;
            s3n27_txt.Visible = false;
            s3n28_txt.Visible = false;
            s3n29_txt.Visible = false;
            s3n30_txt.Visible = false;
            s3n31_txt.Visible = false;
            s3n32_txt.Visible = false;
            s3n33_txt.Visible = false;
            s3n34_txt.Visible = false;
            s3n35_txt.Visible = false;
            s3n36_txt.Visible = false;
            s3n37_txt.Visible = false;
            s3n38_txt.Visible = false;
            s3n39_txt.Visible = false;
            s3n40_txt.Visible = false;



        }
        void messagegizle()
        {
            //sayfa1 butonlarının gizlenmesi
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

            s2n1_btn.Visible = false;
            s2n2_btn.Visible = false;
            s2n3_btn.Visible = false;
            s2n4_btn.Visible = false;
            s2n5_btn.Visible = false;
            s2n6_btn.Visible = false;
            s2n7_btn.Visible = false;
            s2n8_btn.Visible = false;
            s2n9_btn.Visible = false;
            s2n10_btn.Visible = false;
            s2n11_btn.Visible = false;
            s2n12_btn.Visible = false;
            s2n13_btn.Visible = false;
            s2n14_btn.Visible = false;
            s2n15_btn.Visible = false;
            s2n16_btn.Visible = false;
            s2n17_btn.Visible = false;
            s2n18_btn.Visible = false;
            s2n19_btn.Visible = false;
            s2n20_btn.Visible = false;
            s2n21_btn.Visible = false;
            s2n22_btn.Visible = false;
            s2n23_btn.Visible = false;
            s2n24_btn.Visible = false;
            s2n25_btn.Visible = false;
            s2n26_btn.Visible = false;
            s2n27_btn.Visible = false;
            s2n28_btn.Visible = false;
            s2n29_btn.Visible = false;
            s2n30_btn.Visible = false;
            s2n31_btn.Visible = false;
            s2n32_btn.Visible = false;
            s2n33_btn.Visible = false;
            s2n34_btn.Visible = false;
            s2n35_btn.Visible = false;
            s2n36_btn.Visible = false;
            s2n37_btn.Visible = false;
            s2n38_btn.Visible = false;
            s2n39_btn.Visible = false;
            s2n40_btn.Visible = false;

            //page 3 buttons 
            s3n1_btn.Visible = false;
            s3n2_btn.Visible = false;
            s3n3_btn.Visible = false;
            s3n4_btn.Visible = false;
            s3n5_btn.Visible = false;
            s3n6_btn.Visible = false;
            s3n7_btn.Visible = false;
            s3n8_btn.Visible = false;
            s3n9_btn.Visible = false;
            s3n10_btn.Visible = false;
            s3n11_btn.Visible = false;
            s3n12_btn.Visible = false;
            s3n13_btn.Visible = false;
            s3n14_btn.Visible = false;
            s3n15_btn.Visible = false;
            s3n16_btn.Visible = false;
            s3n17_btn.Visible = false;
            s3n18_btn.Visible = false;
            s3n19_btn.Visible = false;
            s3n20_btn.Visible = false;
            s3n21_btn.Visible = false;
            s3n22_btn.Visible = false;
            s3n23_btn.Visible = false;
            s3n24_btn.Visible = false;
            s3n25_btn.Visible = false;
            s3n26_btn.Visible = false;
            s3n27_btn.Visible = false;
            s3n28_btn.Visible = false;
            s3n29_btn.Visible = false;
            s3n30_btn.Visible = false;
            s3n31_btn.Visible = false;
            s3n32_btn.Visible = false;
            s3n33_btn.Visible = false;
            s3n34_btn.Visible = false;
            s3n35_btn.Visible = false;
            s3n36_btn.Visible = false;
            s3n37_btn.Visible = false;
            s3n38_btn.Visible = false;
            s3n39_btn.Visible = false;
            s3n40_btn.Visible = false;
        }

        private void txtbox_ogrsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void s1n1_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 1;
            s1n1_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n9_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 9;
            s1n9_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();

        }

        private void s1n17_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 17;
            s1n17_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();

        }

        private void s1n5_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 5;
            s1n5_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n31_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 31;
            s1n31_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n40_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 40;
            s1n40_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n33_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 33;
            s1n33_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n32_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 32;
            s1n32_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n6_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 6;
            s1n6_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n18_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 18;
            s1n18_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n10_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 10;
            s1n10_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n13_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 13;
            s1n13_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n19_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 19;
            s1n19_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n25_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 25;
            s1n25_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n35_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 35;
            s1n35_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n36_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 36;
            s1n36_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n2_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 2;
            s1n2_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n26_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 26;
            s1n26_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n20_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 20;
            s1n20_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n14_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 14;
            s1n14_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n15_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 15;
            s1n15_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n21_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 21;
            s1n21_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n27_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 27;
            s1n27_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n3_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 3;
            s1n3_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n37_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 37;
            s1n37_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n38_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 38;
            s1n38_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n4_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 4;
            s1n4_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n28_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 28;
            s1n28_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n22_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 22;
            s1n22_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n16_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 16;
            s1n16_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n11_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 11;
            s1n11_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n23_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 23;
            s1n23_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n7_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 7;
            s1n7_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n29_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 29;
            s1n29_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n39_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 39;
            s1n39_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n34_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 34;
            s1n34_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n30_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 30;
            s1n30_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n8_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 8;
            s1n8_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n24_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 24;
            s1n24_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void s1n12_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 12;
            s1n12_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                txtbox_ogrsayi.ReadOnly = false;
                if (checkBox2.Checked == true && checkBox1.Checked == true)//çıkmış soru olacaksa ve zordan kolaya olacaksa buradan alır
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
                            string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                            //
                            string dosya_adres = dosyayolu;
                            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                            con.Open();
                            //////////////////////////
                            //////////////////////////
                            //normal soruları alır
                            string sql = "SELECT * from [Sayfa1$A0:A200] ";
                            OleDbCommand veri2 = new OleDbCommand(sql, con);
                            OleDbDataReader dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
                                {
                                    listBox1.Items.Add(dr[0].ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //çıkmış soruları alır
                            sql = "SELECT * from [Sayfa1$B0:B200] ";
                            veri2 = new OleDbCommand(sql, con);
                            dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
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

                            soru_dizisi1 = new string[listBox1.Items.Count];
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                soru_dizisi1[i] = listBox1.Items[i].ToString();
                            }


                            maxsoru = listBox1.Items.Count;
                            //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                            if (maxsoru <= 40)
                            {
                                maxsoru = listBox1.Items.Count;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            else
                            {
                                maxsoru = 40;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            //
                            label45.Text = "Dosya Adı : " + fileName;

                        }
                    }
                }
                else if (checkBox1.Checked == true)//zordan kolaya olacaksa buradan alır
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
                            string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                            //
                            string dosya_adres = dosyayolu;
                            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                            con.Open();
                            //////////////////////////
                            //////////////////////////
                            //sayfa1
                            string sql = "SELECT * from [Sayfa1$A0:A200] ";
                            OleDbCommand veri2 = new OleDbCommand(sql, con);
                            OleDbDataReader dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
                                {
                                    listBox1.Items.Add(dr[0].ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }

                            Random r = new Random();
                            int listbox = r.Next(0, listBox1.Items.Count);
                            listBox1.SelectedIndex += listbox;

                            soru_dizisi1 = new string[listBox1.Items.Count];
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                soru_dizisi1[i] = listBox1.Items[i].ToString();
                            }

                              //  s a y f a   2 
                            sql = "SELECT * from [Sayfa2$A0:A200] ";
                            veri2 = new OleDbCommand(sql, con);
                            dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
                                {

                                    listBox2.Items.Add(dr[0].ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }

                          //  con.Close();

                            Random r1 = new Random();
                            int listbox1 = r.Next(0, listBox2.Items.Count);
                            listBox2.SelectedIndex += listbox1;

                            soru_dizisi2 = new string[listBox2.Items.Count];
                            for (int i = 0; i < listBox2.Items.Count; i++)
                            {
                                soru_dizisi2[i] = listBox2.Items[i].ToString();
                            }
                            // s a y f a    3

                            sql = "SELECT * from [Sayfa3$A0:A200] ";
                            veri2 = new OleDbCommand(sql, con);
                            dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
                                {

                                    listBox3.Items.Add(dr[0].ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }

                            con.Close();

                            Random r2 = new Random();
                            int listbox2 = r.Next(0, listBox3.Items.Count);
                            listBox3.SelectedIndex += listbox1;

                            soru_dizisi3 = new string[listBox3.Items.Count];
                            for (int i = 0; i < listBox3.Items.Count; i++)
                            {
                                soru_dizisi3[i] = listBox3.Items[i].ToString();
                            }

                            //sayfa4

                            //sayfa5

                            //sayfa6

                            //






                            maxsoru = listBox1.Items.Count;
                            //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                            if (maxsoru <= 40)
                            {
                                maxsoru = listBox1.Items.Count;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            else
                            {
                                maxsoru = 40;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            //
                            label45.Text = "Dosya Adı : " + fileName;
                        }
                    }
                }
                else if (checkBox2.Checked == true)//çıkmış soru olacaksa
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
                            string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                            //
                            string dosya_adres = dosyayolu;
                            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                            con.Open();
                            //////////////////////////
                            //////////////////////////
                            //normal soruları alır
                            string sql = "SELECT * from [Sayfa1$A0:A200] ";
                            OleDbCommand veri2 = new OleDbCommand(sql, con);
                            OleDbDataReader dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
                                {
                                    listBox1.Items.Add(dr[0].ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }
                            //çıkmış soruları alır
                            sql = "SELECT * from [Sayfa1$B0:B200] ";
                            veri2 = new OleDbCommand(sql, con);
                            dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
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

                            soru_dizisi1 = new string[listBox1.Items.Count];
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                soru_dizisi1[i] = listBox1.Items[i].ToString();
                            }

                            maxsoru = listBox1.Items.Count;
                            //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                            if (maxsoru <= 40)
                            {
                                maxsoru = listBox1.Items.Count;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            else
                            {
                                maxsoru = 40;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            //
                            label45.Text = "Dosya Adı : " + fileName;
                        }
                    }
                }
                else
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
                            string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                            //



                            string dosya_adres = dosyayolu;

                            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                            con.Open();

                            string sql = "SELECT * from [Sayfa1$A1:A200] ";

                            OleDbCommand veri2 = new OleDbCommand(sql, con);
                            OleDbDataReader dr = null;
                            dr = veri2.ExecuteReader();

                            while (dr.Read())
                            {
                                if (dr[0].ToString() != "")
                                {
                                    listBox1.Items.Add(dr[0].ToString());
                                }
                                else
                                {
                                    break;
                                }
                            }
                            con.Close();

                            //listbox1'e aktarılan verileri karıştırıyor ve diziye aktarıyor.

                            Random r = new Random();
                            int listbox = r.Next(0, listBox1.Items.Count);
                            listBox1.SelectedIndex += listbox;

                            soru_dizisi1 = new string[listBox1.Items.Count];
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                soru_dizisi1[i] = listBox1.Items[i].ToString();
                            }



                            maxsoru = listBox1.Items.Count;
                            //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                            if (maxsoru <= 40)
                            {
                                maxsoru = listBox1.Items.Count;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            else
                            {
                                maxsoru = 40;
                                button1.Enabled = true;
                                label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                            }
                            //seçilen dosyanın adını label'a yazar
                            label45.Text = "Dosya Adı : " + fileName;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler yanlış gitti!", "Rastgele Seçici");
            }
            sart2 = true;

            if (sart1 == true && sart2 == true)
            {
                tabControl1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //

        static public int hangisitiklandıs1 = 0;
        static public int hangisitiklandıs2 = 0;
        static public int hangisitiklandıs3 = 0;

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void textsoruadedi_TextChanged(object sender, EventArgs e)
        {

        }

        static public string hangisitiklandi1t = "";

        static public string hangisitiklandi2t = "";

        static public string hangisitiklandi3t = "";

        static public int btn_kontrol = 0;  // form3 deki kontrol için kullanılıyor butonun tıkladığı sayfaya göre değer alıyor. Örneğin sayfa2 deki buton 2 değeri döndürüyor

        private void s2n1_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 1;
            s2n1_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }
        private void s2n2_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 2;
            s2n2_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }
        public void sormetot()
        {

            try
            {
                btn_kontrol = 1;
                hangisitiklandi1t = soru_dizisi1[hangisitiklandıs1 - 1];
                Form3 y = new Form3();
                y.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Üzgünüz soru sayınız yetersiz! Maksimum soru sayınız : " + (listBox1.Items.Count + 1) + "'dir. Lütfen öğrenci sayınızı bu rakam olacak şekilde güncelleyiniz.", "Rastgele Seçici");

            }


        }

        private void s2n3_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 3;
            s2n3_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n4_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 4;
            s2n4_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n5_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 5;
            s2n5_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n6_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 6;
            s2n6_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n7_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 7;
            s2n7_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n8_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 8;
            s2n8_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n9_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 9;
            s2n9_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n10_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 10;
            s2n10_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n11_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 11;
            s2n11_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n12_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 12;
            s2n12_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n13_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 13;
            s2n13_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n14_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 14;
            s2n14_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n15_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 15;
            s2n15_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n16_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 16;
            s2n16_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n17_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 17;
            s2n17_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n18_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 18;
            s2n18_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n19_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 19;
            s2n19_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n20_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 20;
            s2n20_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n21_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 21;
            s2n21_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n22_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 22;
            s2n22_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n23_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 23;
            s2n23_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n24_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 24;
            s2n24_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n25_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 25;
            s2n25_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n26_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 26;
            s2n26_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n27_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 27;
            s2n27_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n28_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 28;
            s2n28_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n29_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 29;
            s2n29_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n30_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 30;
            s2n30_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n31_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 31;
            s2n31_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n32_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 32;
            s2n32_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n33_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 33;
            s2n33_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n34_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 34;
            s2n34_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n35_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 35;
            s2n35_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n36_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 36;
            s2n36_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n37_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 37;
            s2n37_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n38_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 38;
            s2n38_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n39_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 39;
            s2n39_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n40_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 40;
            s2n40_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            reset =true;
            Form2 yeniform = new Form2();
            yeniform.Show();
            this.Close();
            


            txtbox_ogrsayi.Text = "1";
        }

       

        public void sormetots2()
        {

            try
            {
                btn_kontrol = 2;
                hangisitiklandi2t = soru_dizisi2[hangisitiklandıs2 - 1];
                Form3 y = new Form3();
                y.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Üzgünüz soru sayınız yetersiz! Maksimum soru sayınız : " + (listBox2.Items.Count + 1) + "'dir. Lütfen öğrenci sayınızı bu rakam olacak şekilde güncelleyiniz.", "Rastgele Seçici");

            }


        }

        private void s3n9_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 9;
            s3n9_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n17_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 17;
            s3n17_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();

        }

        private void s3n5_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 5;
            s3n5_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n31_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 31;
            s3n31_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n40_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 40;
            s3n40_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n33_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 33;
            s3n33_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n32_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 32;
            s3n32_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n1_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 1;
            s3n1_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n6_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 6;
            s3n6_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n18_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 18;
            s3n18_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n10_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 10;
            s3n10_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n13_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 13;
            s3n13_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n19_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 19;
            s3n19_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n25_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 25;
            s3n25_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n35_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 35;
            s3n35_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n36_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 36;
            s3n36_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n2_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 2;
            s3n2_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n26_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 26;
            s3n26_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n20_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 20;
            s3n20_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n14_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 14;
            s3n14_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n15_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 15;
            s3n15_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n21_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 21;
            s3n21_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n27_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 27;
            s3n27_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n3_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 3;
            s3n3_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n37_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 37;
            s3n37_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();

        }

        private void s3n38_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 38;
            s3n38_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n4_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 4;
            s3n4_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n28_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 28;
            s3n28_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n22_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 22;
            s3n22_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n16_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 16;
            s3n16_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n11_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 11;
            s3n11_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n23_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 23;
            s3n23_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n7_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 7;
            s3n7_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n29_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 29;
            s3n29_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n39_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 39;
            s3n39_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n34_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 34;
            s3n34_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n30_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 30;
            s3n30_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n8_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 8;
            s3n8_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n24_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 24;
            s3n24_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n12_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 12;
            s3n12_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        public void sormetots3()
        {

            try
            {
                btn_kontrol = 3;
                hangisitiklandi3t = soru_dizisi3[hangisitiklandıs3 - 1];
                Form3 y = new Form3();
                y.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Üzgünüz soru sayınız yetersiz! Maksimum soru sayınız : " + (listBox1.Items.Count + 1) + "'dir. Lütfen öğrenci sayınızı bu rakam olacak şekilde güncelleyiniz.", "Rastgele Seçici");

            }


        }




    }
}
