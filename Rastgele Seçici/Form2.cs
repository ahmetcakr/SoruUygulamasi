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
using System.Threading;
namespace Rastgele_Seçici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int max_item_sayisi = 105;
        int ogrencisayisi = 1;
        bool sart1 = false, sart2 = false;
        string[] soru_dizisi1;
        string[] soru_dizisi2;
        string[] soru_dizisi3;
        string dosyayolu;
        int maxsoru, maxsoru2, maxsoru3;
        int sayfa1, sayfa2, sayfa3;
        bool reset = false;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reset == false)
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
            if (controller == 1 && label2.Text == "Excel Dosyası Seçildi.")
            {
                if (Convert.ToInt32(txtbox_ogrsayi.Text) >= 1 && Convert.ToInt32(txtbox_ogrsayi.Text) <= maxsoru)
                {
                    messagegizle();
                    messagenumbergizle();
                    sart1 = true;
                    ogrencisayisi = Convert.ToInt32(txtbox_ogrsayi.Text);
                    int ogrencisayisi1, ogrencisayisi2, ogrencisayisi3;

                    sayfa1 = listBox1.Items.Count;
                    sayfa2 = listBox2.Items.Count;
                    sayfa3 = listBox3.Items.Count;

                    if (ogrencisayisi > sayfa1)
                    {
                        ogrencisayisi1 = sayfa1;
                    }
                    else
                    {
                        ogrencisayisi1 = ogrencisayisi;
                    }

                    if (ogrencisayisi > sayfa2)
                    {
                        ogrencisayisi2 = sayfa2;
                    }
                    else
                    {
                        ogrencisayisi2 = ogrencisayisi;
                    }

                    if (ogrencisayisi > sayfa3)
                    {
                        ogrencisayisi3 = sayfa3;
                    }
                    else
                    {
                        ogrencisayisi3 = ogrencisayisi;
                    }

                    //labelların gösterilmesi
                    //////////////////
                    ///////////////////
                    ////////////////////

                    //sayfa1
                    List<Label> labellers1 = new List<Label>() { s1n1_txt, s1n2_txt , s1n3_txt , s1n4_txt , s1n5_txt , s1n6_txt, s1n7_txt , s1n8_txt, s1n9_txt, s1n10_txt , s1n11_txt, s1n12_txt, s1n13_txt, s1n14_txt, s1n15_txt, s1n16_txt, s1n17_txt, s1n18_txt, s1n19_txt, s1n20_txt, s1n21_txt, s1n22_txt, s1n23_txt, s1n24_txt, s1n25_txt, s1n26_txt, s1n27_txt, s1n28_txt, s1n29_txt, s1n30_txt, s1n31_txt, s1n32_txt, s1n33_txt, s1n34_txt, s1n35_txt, s1n36_txt, s1n37_txt, s1n38_txt, s1n39_txt, s1n40_txt, s1n41_txt, s1n42_txt, s1n43_txt, s1n44_txt, s1n45_txt, s1n46_txt, s1n47_txt, s1n48_txt, s1n49_txt, s1n50_txt, s1n51_txt, s1n52_txt, s1n53_txt, s1n54_txt, s1n55_txt, s1n56_txt, s1n57_txt,
                s1n58_txt,s1n59_txt,s1n60_txt,s1n61_txt,s1n62_txt,s1n63_txt,s1n64_txt,s1n65_txt,s1n66_txt,s1n67_txt,s1n68_txt,s1n69_txt,s1n70_txt,s1n71_txt,s1n72_txt,s1n73_txt,s1n74_txt,s1n75_txt,s1n76_txt,s1n77_txt,s1n78_txt,s1n79_txt,s1n80_txt,s1n81_txt,s1n82_txt,s1n83_txt,s1n84_txt,s1n85_txt,s1n86_txt,s1n87_txt,s1n88_txt,s1n89_txt,s1n90_txt,s1n91_txt,s1n92_txt,s1n93_txt,s1n94_txt,s1n95_txt,s1n96_txt,s1n97_txt,s1n98_txt,s1n99_txt,s1n100_txt,s1n101_txt,s1n102_txt,s1n103_txt,s1n104_txt,s1n105_txt};



                    for (int i = 0; i < ogrencisayisi1; i++)
                    {
                        labellers1[i].Visible = true;
                    }

                    if (checkBox1.Checked)
                    {
                        //sayfa2
                        List<Label> labellers2 = new List<Label>() { s2n1_txt, s2n2_txt , s2n3_txt , s2n4_txt , s2n5_txt , s2n6_txt, s2n7_txt , s2n8_txt, s2n9_txt, s2n10_txt , s2n11_txt, s2n12_txt, s2n13_txt, s2n14_txt, s2n15_txt, s2n16_txt, s2n17_txt, s2n18_txt, s2n19_txt, s2n20_txt, s2n21_txt, s2n22_txt, s2n23_txt, s2n24_txt, s2n25_txt, s2n26_txt, s2n27_txt, s2n28_txt, s2n29_txt, s2n30_txt, s2n31_txt, s2n32_txt, s2n33_txt, s2n34_txt, s2n35_txt, s2n36_txt, s2n37_txt, s2n38_txt, s2n39_txt, s2n40_txt, s2n41_txt, s2n42_txt, s2n43_txt, s2n44_txt, s2n45_txt, s2n46_txt, s2n47_txt, s2n48_txt, s2n49_txt, s2n50_txt, s2n51_txt, s2n52_txt, s2n53_txt, s2n54_txt, s2n55_txt, s2n56_txt, s2n57_txt,
                s2n58_txt,s2n59_txt,s2n60_txt,s2n61_txt,s2n62_txt,s2n63_txt,s2n64_txt,s2n65_txt,s2n66_txt,s2n67_txt,s2n68_txt,s2n69_txt,s2n70_txt,s2n71_txt,s2n72_txt,s2n73_txt,s2n74_txt,s2n75_txt,s2n76_txt,s2n77_txt,s2n78_txt,s2n79_txt,s2n80_txt,s2n81_txt,s2n82_txt,s2n83_txt,s2n84_txt,s2n85_txt,s2n86_txt,s2n87_txt,s2n88_txt,s2n89_txt,s2n90_txt,s2n91_txt,s2n92_txt,s2n93_txt,s2n94_txt,s2n95_txt,s2n96_txt,s2n97_txt,s2n98_txt,s2n99_txt,s2n100_txt,s2n101_txt,s2n102_txt,s2n103_txt,s2n104_txt,s2n105_txt};


                        for (int i = 0; i < ogrencisayisi2; i++)
                        {
                            labellers2[i].Visible = true;
                        }
                        //sayfa3

                        List<Label> labellers3 = new List<Label>() { s3n1_txt, s3n2_txt , s3n3_txt , s3n4_txt , s3n5_txt , s3n6_txt, s3n7_txt , s3n8_txt, s3n9_txt, s3n10_txt , s3n11_txt, s3n12_txt, s3n13_txt, s3n14_txt, s3n15_txt, s3n16_txt, s3n17_txt, s3n18_txt, s3n19_txt, s3n20_txt, s3n21_txt, s3n22_txt, s3n23_txt, s3n24_txt, s3n25_txt, s3n26_txt, s3n27_txt, s3n28_txt, s3n29_txt, s3n30_txt, s3n31_txt, s3n32_txt, s3n33_txt, s3n34_txt, s3n35_txt, s3n36_txt, s3n37_txt, s3n38_txt, s3n39_txt, s3n40_txt, s3n41_txt, s3n42_txt, s3n43_txt, s3n44_txt, s3n45_txt, s3n46_txt, s3n47_txt, s3n48_txt, s3n49_txt, s3n50_txt, s3n51_txt, s3n52_txt, s3n53_txt, s3n54_txt, s3n55_txt, s3n56_txt, s3n57_txt,
                s3n58_txt,s3n59_txt,s3n60_txt,s3n61_txt,s3n62_txt,s3n63_txt,s3n64_txt,s3n65_txt,s3n66_txt,s3n67_txt,s3n68_txt,s3n69_txt,s3n70_txt,s3n71_txt,s3n72_txt,s3n73_txt,s3n74_txt,s3n75_txt,s3n76_txt,s3n77_txt,s3n78_txt,s3n79_txt,s3n80_txt,s3n81_txt,s3n82_txt,s3n83_txt,s3n84_txt,s3n85_txt,s3n86_txt,s3n87_txt,s3n88_txt,s3n89_txt,s3n90_txt,s3n91_txt,s3n92_txt,s3n93_txt,s3n94_txt,s3n95_txt,s3n96_txt,s3n97_txt,s3n98_txt,s3n99_txt,s3n100_txt,s3n101_txt,s3n102_txt,s3n103_txt,s3n104_txt,s3n105_txt};


                        for (int i = 0; i < ogrencisayisi3; i++)
                        {
                            labellers3[i].Visible = true;
                        }
                    }


                    //butonların gösterilmesi
                    //////////////////
                    //////////////////
                    //////
                    ///
                    //butonların gizlenmesi

                    //sayfa1
                    List<PictureBox> butonlars1 = new List<PictureBox>() { s1n1_btn, s1n2_btn , s1n3_btn , s1n4_btn , s1n5_btn , s1n6_btn, s1n7_btn , s1n8_btn, s1n9_btn, s1n10_btn , s1n11_btn, s1n12_btn, s1n13_btn, s1n14_btn, s1n15_btn, s1n16_btn, s1n17_btn, s1n18_btn, s1n19_btn, s1n20_btn, s1n21_btn, s1n22_btn, s1n23_btn, s1n24_btn, s1n25_btn, s1n26_btn, s1n27_btn, s1n28_btn, s1n29_btn, s1n30_btn, s1n31_btn, s1n32_btn, s1n33_btn, s1n34_btn, s1n35_btn, s1n36_btn, s1n37_btn, s1n38_btn, s1n39_btn, s1n40_btn, s1n41_btn, s1n42_btn, s1n43_btn, s1n44_btn, s1n45_btn, s1n46_btn, s1n47_btn, s1n48_btn, s1n49_btn, s1n50_btn, s1n51_btn, s1n52_btn, s1n53_btn, s1n54_btn, s1n55_btn, s1n56_btn, s1n57_btn,
                s1n58_btn,s1n59_btn,s1n60_btn,s1n61_btn,s1n62_btn,s1n63_btn,s1n64_btn,s1n65_btn,s1n66_btn,s1n67_btn,s1n68_btn,s1n69_btn,s1n70_btn,s1n71_btn,s1n72_btn,s1n73_btn,s1n74_btn,s1n75_btn,s1n76_btn,s1n77_btn,s1n78_btn,s1n79_btn,s1n80_btn,s1n81_btn,s1n82_btn,s1n83_btn,s1n84_btn,s1n85_btn,s1n86_btn,s1n87_btn,s1n88_btn,s1n89_btn,s1n90_btn,s1n91_btn,s1n92_btn,s1n93_btn,s1n94_btn,s1n95_btn,s1n96_btn,s1n97_btn,s1n98_btn,s1n99_btn,s1n100_btn,s1n101_btn,s1n102_btn,s1n103_btn,s1n104_btn,s1n105_btn};
                    for (int i = 0; i < ogrencisayisi1; i++)
                    {
                        butonlars1[i].Visible = true;
                    }

                    if (checkBox1.Checked)
                    {
                        //sayfa2
                        List<PictureBox> butonlars2 = new List<PictureBox>() { s2n1_btn, s2n2_btn , s2n3_btn , s2n4_btn , s2n5_btn , s2n6_btn, s2n7_btn , s2n8_btn, s2n9_btn, s2n10_btn , s2n11_btn, s2n12_btn, s2n13_btn, s2n14_btn, s2n15_btn, s2n16_btn, s2n17_btn, s2n18_btn, s2n19_btn, s2n20_btn, s2n21_btn, s2n22_btn, s2n23_btn, s2n24_btn, s2n25_btn, s2n26_btn, s2n27_btn, s2n28_btn, s2n29_btn, s2n30_btn, s2n31_btn, s2n32_btn, s2n33_btn, s2n34_btn, s2n35_btn, s2n36_btn, s2n37_btn, s2n38_btn, s2n39_btn, s2n40_btn, s2n41_btn, s2n42_btn, s2n43_btn, s2n44_btn, s2n45_btn, s2n46_btn, s2n47_btn, s2n48_btn, s2n49_btn, s2n50_btn, s2n51_btn, s2n52_btn, s2n53_btn, s2n54_btn, s2n55_btn, s2n56_btn, s2n57_btn,
                s2n58_btn,s2n59_btn,s2n60_btn,s2n61_btn,s2n62_btn,s2n63_btn,s2n64_btn,s2n65_btn,s2n66_btn,s2n67_btn,s2n68_btn,s2n69_btn,s2n70_btn,s2n71_btn,s2n72_btn,s2n73_btn,s2n74_btn,s2n75_btn,s2n76_btn,s2n77_btn,s2n78_btn,s2n79_btn,s2n80_btn,s2n81_btn,s2n82_btn,s2n83_btn,s2n84_btn,s2n85_btn,s2n86_btn,s2n87_btn,s2n88_btn,s2n89_btn,s2n90_btn,s2n91_btn,s2n92_btn,s2n93_btn,s2n94_btn,s2n95_btn,s2n96_btn,s2n97_btn,s2n98_btn,s2n99_btn,s2n100_btn,s2n101_btn,s2n102_btn,s2n103_btn,s2n104_btn,s2n105_btn};

                        for (int i = 0; i < ogrencisayisi2; i++)
                        {
                            butonlars2[i].Visible = true;
                        }
                        //sayfa3

                        List<PictureBox> butonlars3 = new List<PictureBox>() { s3n1_btn, s3n2_btn , s3n3_btn , s3n4_btn , s3n5_btn , s3n6_btn, s3n7_btn , s3n8_btn, s3n9_btn, s3n10_btn , s3n11_btn, s3n12_btn, s3n13_btn, s3n14_btn, s3n15_btn, s3n16_btn, s3n17_btn, s3n18_btn, s3n19_btn, s3n20_btn, s3n21_btn, s3n22_btn, s3n23_btn, s3n24_btn, s3n25_btn, s3n26_btn, s3n27_btn, s3n28_btn, s3n29_btn, s3n30_btn, s3n31_btn, s3n32_btn, s3n33_btn, s3n34_btn, s3n35_btn, s3n36_btn, s3n37_btn, s3n38_btn, s3n39_btn, s3n40_btn, s3n41_btn, s3n42_btn, s3n43_btn, s3n44_btn, s3n45_btn, s3n46_btn, s3n47_btn, s3n48_btn, s3n49_btn, s3n50_btn, s3n51_btn, s3n52_btn, s3n53_btn, s3n54_btn, s3n55_btn, s3n56_btn, s3n57_btn,
                s3n58_btn,s3n59_btn,s3n60_btn,s3n61_btn,s3n62_btn,s3n63_btn,s3n64_btn,s3n65_btn,s3n66_btn,s3n67_btn,s3n68_btn,s3n69_btn,s3n70_btn,s3n71_btn,s3n72_btn,s3n73_btn,s3n74_btn,s3n75_btn,s3n76_btn,s3n77_btn,s3n78_btn,s3n79_btn,s3n80_btn,s3n81_btn,s3n82_btn,s3n83_btn,s3n84_btn,s3n85_btn,s3n86_btn,s3n87_btn,s3n88_btn,s3n89_btn,s3n90_btn,s3n91_btn,s3n92_btn,s3n93_btn,s3n94_btn,s3n95_btn,s3n96_btn,s3n97_btn,s3n98_btn,s3n99_btn,s3n100_btn,s3n101_btn,s3n102_btn,s3n103_btn,s3n104_btn,s3n105_btn};
                        for (int i = 0; i < ogrencisayisi3; i++)
                        {
                            butonlars3[i].Visible = true;
                        }
                    }














                    if (sart1 == true && sart2 == true)
                    {
                        tabControl1.Enabled = true;
                    }
                    tanimlandi();
                }
                else
                {
                    MessageBox.Show("Lütfen 1 ila " + maxsoru.ToString() + " arası rakam giriniz.", "Rastgele Seçici");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Excel Dosyası Seçiniz..!");
            }
            load_image.Visible = false;

        }
        int controller = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            controller = 0;
            tabControl1.Enabled = false;
            //  button1.Enabled = false;
            label45.Enabled = false;
            messagegizle();
            messagenumbergizle();
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;

            //txtbox_ogrsayi.ReadOnly = true;
        }
        void messagenumbergizle()
        {
            //labelların gizlenmesi

            //sayfa1
            List<Label> labellers1 = new List<Label>() { s1n1_txt, s1n2_txt , s1n3_txt , s1n4_txt , s1n5_txt , s1n6_txt, s1n7_txt , s1n8_txt, s1n9_txt, s1n10_txt , s1n11_txt, s1n12_txt, s1n13_txt, s1n14_txt, s1n15_txt, s1n16_txt, s1n17_txt, s1n18_txt, s1n19_txt, s1n20_txt, s1n21_txt, s1n22_txt, s1n23_txt, s1n24_txt, s1n25_txt, s1n26_txt, s1n27_txt, s1n28_txt, s1n29_txt, s1n30_txt, s1n31_txt, s1n32_txt, s1n33_txt, s1n34_txt, s1n35_txt, s1n36_txt, s1n37_txt, s1n38_txt, s1n39_txt, s1n40_txt, s1n41_txt, s1n42_txt, s1n43_txt, s1n44_txt, s1n45_txt, s1n46_txt, s1n47_txt, s1n48_txt, s1n49_txt, s1n50_txt, s1n51_txt, s1n52_txt, s1n53_txt, s1n54_txt, s1n55_txt, s1n56_txt, s1n57_txt,
                s1n58_txt,s1n59_txt,s1n60_txt,s1n61_txt,s1n62_txt,s1n63_txt,s1n64_txt,s1n65_txt,s1n66_txt,s1n67_txt,s1n68_txt,s1n69_txt,s1n70_txt,s1n71_txt,s1n72_txt,s1n73_txt,s1n74_txt,s1n75_txt,s1n76_txt,s1n77_txt,s1n78_txt,s1n79_txt,s1n80_txt,s1n81_txt,s1n82_txt,s1n83_txt,s1n84_txt,s1n85_txt,s1n86_txt,s1n87_txt,s1n88_txt,s1n89_txt,s1n90_txt,s1n91_txt,s1n92_txt,s1n93_txt,s1n94_txt,s1n95_txt,s1n96_txt,s1n97_txt,s1n98_txt,s1n99_txt,s1n100_txt,s1n101_txt,s1n102_txt,s1n103_txt,s1n104_txt,s1n105_txt};

            for (int i = 0; i < max_item_sayisi; i++)
            {
                labellers1[i].Visible = false;
            }
            //sayfa2
            List<Label> labellers2 = new List<Label>() { s2n1_txt, s2n2_txt , s2n3_txt , s2n4_txt , s2n5_txt , s2n6_txt, s2n7_txt , s2n8_txt, s2n9_txt, s2n10_txt , s2n11_txt, s2n12_txt, s2n13_txt, s2n14_txt, s2n15_txt, s2n16_txt, s2n17_txt, s2n18_txt, s2n19_txt, s2n20_txt, s2n21_txt, s2n22_txt, s2n23_txt, s2n24_txt, s2n25_txt, s2n26_txt, s2n27_txt, s2n28_txt, s2n29_txt, s2n30_txt, s2n31_txt, s2n32_txt, s2n33_txt, s2n34_txt, s2n35_txt, s2n36_txt, s2n37_txt, s2n38_txt, s2n39_txt, s2n40_txt, s2n41_txt, s2n42_txt, s2n43_txt, s2n44_txt, s2n45_txt, s2n46_txt, s2n47_txt, s2n48_txt, s2n49_txt, s2n50_txt, s2n51_txt, s2n52_txt, s2n53_txt, s2n54_txt, s2n55_txt, s2n56_txt, s2n57_txt,
                s2n58_txt,s2n59_txt,s2n60_txt,s2n61_txt,s2n62_txt,s2n63_txt,s2n64_txt,s2n65_txt,s2n66_txt,s2n67_txt,s2n68_txt,s2n69_txt,s2n70_txt,s2n71_txt,s2n72_txt,s2n73_txt,s2n74_txt,s2n75_txt,s2n76_txt,s2n77_txt,s2n78_txt,s2n79_txt,s2n80_txt,s2n81_txt,s2n82_txt,s2n83_txt,s2n84_txt,s2n85_txt,s2n86_txt,s2n87_txt,s2n88_txt,s2n89_txt,s2n90_txt,s2n91_txt,s2n92_txt,s2n93_txt,s2n94_txt,s2n95_txt,s2n96_txt,s2n97_txt,s2n98_txt,s2n99_txt,s2n100_txt,s2n101_txt,s2n102_txt,s2n103_txt,s2n104_txt,s2n105_txt};

            for (int i = 0; i < max_item_sayisi; i++)
            {
                labellers2[i].Visible = false;
            }
            //sayfa3

            List<Label> labellers3 = new List<Label>() { s3n1_txt, s3n2_txt , s3n3_txt , s3n4_txt , s3n5_txt , s3n6_txt, s3n7_txt , s3n8_txt, s3n9_txt, s3n10_txt , s3n11_txt, s3n12_txt, s3n13_txt, s3n14_txt, s3n15_txt, s3n16_txt, s3n17_txt, s3n18_txt, s3n19_txt, s3n20_txt, s3n21_txt, s3n22_txt, s3n23_txt, s3n24_txt, s3n25_txt, s3n26_txt, s3n27_txt, s3n28_txt, s3n29_txt, s3n30_txt, s3n31_txt, s3n32_txt, s3n33_txt, s3n34_txt, s3n35_txt, s3n36_txt, s3n37_txt, s3n38_txt, s3n39_txt, s3n40_txt, s3n41_txt, s3n42_txt, s3n43_txt, s3n44_txt, s3n45_txt, s3n46_txt, s3n47_txt, s3n48_txt, s3n49_txt, s3n50_txt, s3n51_txt, s3n52_txt, s3n53_txt, s3n54_txt, s3n55_txt, s3n56_txt, s3n57_txt,
                s3n58_txt,s3n59_txt,s3n60_txt,s3n61_txt,s3n62_txt,s3n63_txt,s3n64_txt,s3n65_txt,s3n66_txt,s3n67_txt,s3n68_txt,s3n69_txt,s3n70_txt,s3n71_txt,s3n72_txt,s3n73_txt,s3n74_txt,s3n75_txt,s3n76_txt,s3n77_txt,s3n78_txt,s3n79_txt,s3n80_txt,s3n81_txt,s3n82_txt,s3n83_txt,s3n84_txt,s3n85_txt,s3n86_txt,s3n87_txt,s3n88_txt,s3n89_txt,s3n90_txt,s3n91_txt,s3n92_txt,s3n93_txt,s3n94_txt,s3n95_txt,s3n96_txt,s3n97_txt,s3n98_txt,s3n99_txt,s3n100_txt,s3n101_txt,s3n102_txt,s3n103_txt,s3n104_txt,s3n105_txt};

            for (int i = 0; i < max_item_sayisi; i++)
            {
                labellers3[i].Visible = false;
            }

        }
        void messagegizle()
        {
            //butonların gizlenmesi

            //sayfa1
            List<PictureBox> butonlars1 = new List<PictureBox>() { s1n1_btn, s1n2_btn , s1n3_btn , s1n4_btn , s1n5_btn , s1n6_btn, s1n7_btn , s1n8_btn, s1n9_btn, s1n10_btn , s1n11_btn, s1n12_btn, s1n13_btn, s1n14_btn, s1n15_btn, s1n16_btn, s1n17_btn, s1n18_btn, s1n19_btn, s1n20_btn, s1n21_btn, s1n22_btn, s1n23_btn, s1n24_btn, s1n25_btn, s1n26_btn, s1n27_btn, s1n28_btn, s1n29_btn, s1n30_btn, s1n31_btn, s1n32_btn, s1n33_btn, s1n34_btn, s1n35_btn, s1n36_btn, s1n37_btn, s1n38_btn, s1n39_btn, s1n40_btn, s1n41_btn, s1n42_btn, s1n43_btn, s1n44_btn, s1n45_btn, s1n46_btn, s1n47_btn, s1n48_btn, s1n49_btn, s1n50_btn, s1n51_btn, s1n52_btn, s1n53_btn, s1n54_btn, s1n55_btn, s1n56_btn, s1n57_btn,
                s1n58_btn,s1n59_btn,s1n60_btn,s1n61_btn,s1n62_btn,s1n63_btn,s1n64_btn,s1n65_btn,s1n66_btn,s1n67_btn,s1n68_btn,s1n69_btn,s1n70_btn,s1n71_btn,s1n72_btn,s1n73_btn,s1n74_btn,s1n75_btn,s1n76_btn,s1n77_btn,s1n78_btn,s1n79_btn,s1n80_btn,s1n81_btn,s1n82_btn,s1n83_btn,s1n84_btn,s1n85_btn,s1n86_btn,s1n87_btn,s1n88_btn,s1n89_btn,s1n90_btn,s1n91_btn,s1n92_btn,s1n93_btn,s1n94_btn,s1n95_btn,s1n96_btn,s1n97_btn,s1n98_btn,s1n99_btn,s1n100_btn,s1n101_btn,s1n102_btn,s1n103_btn,s1n104_btn,s1n105_btn};
            for (int i = 0; i < max_item_sayisi; i++)
            {
                butonlars1[i].Visible = false;
            }
            //sayfa2
            List<PictureBox> butonlars2 = new List<PictureBox>() { s2n1_btn, s2n2_btn , s2n3_btn , s2n4_btn , s2n5_btn , s2n6_btn, s2n7_btn , s2n8_btn, s2n9_btn, s2n10_btn , s2n11_btn, s2n12_btn, s2n13_btn, s2n14_btn, s2n15_btn, s2n16_btn, s2n17_btn, s2n18_btn, s2n19_btn, s2n20_btn, s2n21_btn, s2n22_btn, s2n23_btn, s2n24_btn, s2n25_btn, s2n26_btn, s2n27_btn, s2n28_btn, s2n29_btn, s2n30_btn, s2n31_btn, s2n32_btn, s2n33_btn, s2n34_btn, s2n35_btn, s2n36_btn, s2n37_btn, s2n38_btn, s2n39_btn, s2n40_btn, s2n41_btn, s2n42_btn, s2n43_btn, s2n44_btn, s2n45_btn, s2n46_btn, s2n47_btn, s2n48_btn, s2n49_btn, s2n50_btn, s2n51_btn, s2n52_btn, s2n53_btn, s2n54_btn, s2n55_btn, s2n56_btn, s2n57_btn,
                s2n58_btn,s2n59_btn,s2n60_btn,s2n61_btn,s2n62_btn,s2n63_btn,s2n64_btn,s2n65_btn,s2n66_btn,s2n67_btn,s2n68_btn,s2n69_btn,s2n70_btn,s2n71_btn,s2n72_btn,s2n73_btn,s2n74_btn,s2n75_btn,s2n76_btn,s2n77_btn,s2n78_btn,s2n79_btn,s2n80_btn,s2n81_btn,s2n82_btn,s2n83_btn,s2n84_btn,s2n85_btn,s2n86_btn,s2n87_btn,s2n88_btn,s2n89_btn,s2n90_btn,s2n91_btn,s2n92_btn,s2n93_btn,s2n94_btn,s2n95_btn,s2n96_btn,s2n97_btn,s2n98_btn,s2n99_btn,s2n100_btn,s2n101_btn,s2n102_btn,s2n103_btn,s2n104_btn,s2n105_btn};

            for (int i = 0; i < max_item_sayisi; i++)
            {
                butonlars2[i].Visible = false;
            }
            //sayfa3

            List<PictureBox> butonlars3 = new List<PictureBox>() { s3n1_btn, s3n2_btn , s3n3_btn , s3n4_btn , s3n5_btn , s3n6_btn, s3n7_btn , s3n8_btn, s3n9_btn, s3n10_btn , s3n11_btn, s3n12_btn, s3n13_btn, s3n14_btn, s3n15_btn, s3n16_btn, s3n17_btn, s3n18_btn, s3n19_btn, s3n20_btn, s3n21_btn, s3n22_btn, s3n23_btn, s3n24_btn, s3n25_btn, s3n26_btn, s3n27_btn, s3n28_btn, s3n29_btn, s3n30_btn, s3n31_btn, s3n32_btn, s3n33_btn, s3n34_btn, s3n35_btn, s3n36_btn, s3n37_btn, s3n38_btn, s3n39_btn, s3n40_btn, s3n41_btn, s3n42_btn, s3n43_btn, s3n44_btn, s3n45_btn, s3n46_btn, s3n47_btn, s3n48_btn, s3n49_btn, s3n50_btn, s3n51_btn, s3n52_btn, s3n53_btn, s3n54_btn, s3n55_btn, s3n56_btn, s3n57_btn,
                s3n58_btn,s3n59_btn,s3n60_btn,s3n61_btn,s3n62_btn,s3n63_btn,s3n64_btn,s3n65_btn,s3n66_btn,s3n67_btn,s3n68_btn,s3n69_btn,s3n70_btn,s3n71_btn,s3n72_btn,s3n73_btn,s3n74_btn,s3n75_btn,s3n76_btn,s3n77_btn,s3n78_btn,s3n79_btn,s3n80_btn,s3n81_btn,s3n82_btn,s3n83_btn,s3n84_btn,s3n85_btn,s3n86_btn,s3n87_btn,s3n88_btn,s3n89_btn,s3n90_btn,s3n91_btn,s3n92_btn,s3n93_btn,s3n94_btn,s3n95_btn,s3n96_btn,s3n97_btn,s3n98_btn,s3n99_btn,s3n100_btn,s3n101_btn,s3n102_btn,s3n103_btn,s3n104_btn,s3n105_btn};
            for (int i = 0; i < max_item_sayisi; i++)
            {
                butonlars3[i].Visible = false;
            }


        }

        private void txtbox_ogrsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }





        private void button2_Click(object sender, EventArgs e)
        {
            controller = 1;
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
                        yukleniyor();
                        button2.Enabled = false;
                        button2.ForeColor = Color.Red;
                        checkBox1.Enabled = false;
                        checkBox1.ForeColor = Color.Red;
                        checkBox2.Enabled = false;
                        checkBox2.ForeColor = Color.Red;

                        string sFileName = dlg.FileName;
                        dosyayolu = sFileName;
                        label2.Text = "Excel Dosyası Seçildi.";
                        string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                        //
                        string dosya_adres = dosyayolu;
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                        try
                        {
                            con.Open();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Dosya açık olduğundan eylem gerçekleştirilemiyor.");

                        }


                        //sayfa1

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


                        ////
                        ListBox.ObjectCollection list = listBox1.Items;
                        Random rng = new Random();
                        int n = list.Count;
                        while (n > 1)
                        {
                            n--;
                            int k = rng.Next(n + 1);
                            string value = (string)list[k];
                            list[k] = list[n];
                            list[n] = value;
                        }
                        ////



                        soru_dizisi1 = new string[listBox1.Items.Count];
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            soru_dizisi1[i] = listBox1.Items[i].ToString();
                        }

                        //sayfa2


                        //////
                        /////
                        /////
                        ///


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

                        sql = "SELECT * from [Sayfa2$B0:B200] ";
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

                        ListBox.ObjectCollection list1 = listBox2.Items;
                        Random rng1 = new Random();
                        int n1 = list1.Count;
                        while (n1 > 1)
                        {
                            n1--;
                            int k1 = rng1.Next(n1 + 1);
                            string value1 = (string)list1[k1];
                            list1[k1] = list1[n1];
                            list1[n1] = value1;
                        }

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

                        sql = "SELECT * from [Sayfa3$B0:B200] ";
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

                        ListBox.ObjectCollection list3 = listBox3.Items;
                        Random rng3 = new Random();
                        int n3 = list3.Count;
                        while (n3 > 1)
                        {
                            n3--;
                            int k3 = rng3.Next(n3 + 1);
                            string value3 = (string)list3[k3];
                            list3[k3] = list3[n3];
                            list3[n3] = value3;
                        }

                        soru_dizisi3 = new string[listBox3.Items.Count];
                        for (int i = 0; i < listBox3.Items.Count; i++)
                        {
                            soru_dizisi3[i] = listBox3.Items[i].ToString();
                        }





                        /////
                        //////
                        ///








                        con.Close();

                        //







                        int h1 = listBox1.Items.Count;
                        int h2 = listBox2.Items.Count;
                        int h3 = listBox3.Items.Count;
                        int dd = 0;
                        if (h1 > h2 && h1 > h3)
                        {
                            maxsoru = listBox1.Items.Count;
                            dd = maxsoru;
                        }
                        else if (h2 > h1 && h2 > h3)
                        {
                            maxsoru = listBox2.Items.Count;
                            dd = maxsoru;
                        }
                        else
                        {
                            maxsoru = listBox3.Items.Count;
                            dd = maxsoru;
                        }



                        //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                        if (maxsoru <= 105)
                        {
                            maxsoru = dd;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        else
                        {
                            maxsoru = 105;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        //
                        label45.Text = "Dosya Adı : " + fileName;
                        yuklendi();

                    }
                }
            }
            else if (checkBox1.Checked == true)//çoklu olacaksa buradan alır
            {
                using (OpenFileDialog dlg = new OpenFileDialog())

                {
                    dlg.Title = "Excel Dosyasını Seçiniz..";
                    dlg.Filter = "Excel Files (*.xlsx)|*.XLSX";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        yukleniyor();
                        button2.Enabled = false;
                        button2.ForeColor = Color.Red;
                        checkBox1.Enabled = false;
                        checkBox1.ForeColor = Color.Red;
                        checkBox2.Enabled = false;
                        checkBox2.ForeColor = Color.Red;
                        string sFileName = dlg.FileName;
                        dosyayolu = sFileName;
                        label2.Text = "Excel Dosyası Seçildi.";
                        string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                        //
                        string dosya_adres = dosyayolu;
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");

                        try
                        {
                            con.Open();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Dosya açık olduğundan eylem gerçekleştirilemiyor.");
                        }


                        //////////////////////////
                        //////////////////////////
                        //sayfa1
                        string sql = "SELECT * from [Sayfa1$A0:A200]";
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








                        ListBox.ObjectCollection list = listBox1.Items;
                        Random rng = new Random();
                        int n = list.Count;
                        while (n > 1)
                        {
                            n--;
                            int k = rng.Next(n + 1);
                            string value = (string)list[k];
                            list[k] = list[n];
                            list[n] = value;
                        }



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




                        //con.Close();

                        ListBox.ObjectCollection list1 = listBox2.Items;
                        Random rng1 = new Random();
                        int n1 = list1.Count;
                        while (n1 > 1)
                        {
                            n1--;
                            int k1 = rng1.Next(n1 + 1);
                            string value1 = (string)list1[k1];
                            list1[k1] = list1[n1];
                            list1[n1] = value1;
                        }

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
                        ListBox.ObjectCollection list2 = listBox3.Items;
                        Random rng2 = new Random();
                        int n2 = list2.Count;
                        while (n2 > 1)
                        {
                            n2--;
                            int k2 = rng2.Next(n2 + 1);
                            string value2 = (string)list2[k2];
                            list2[k2] = list2[n2];
                            list2[n2] = value2;
                        }

                        soru_dizisi3 = new string[listBox3.Items.Count];
                        for (int i = 0; i < listBox3.Items.Count; i++)
                        {
                            soru_dizisi3[i] = listBox3.Items[i].ToString();
                        }

                        //sayfa4

                        //sayfa5

                        //sayfa6

                        //




                        int h1 = listBox1.Items.Count;
                        int h2 = listBox2.Items.Count;
                        int h3 = listBox3.Items.Count;
                        int dd = 0;
                        if (h1 > h2 && h1 > h3)
                        {
                            maxsoru = listBox1.Items.Count;
                            dd = maxsoru;
                        }
                        else if (h2 > h1 && h2 > h3)
                        {
                            maxsoru = listBox2.Items.Count;
                            dd = maxsoru;
                        }
                        else
                        {
                            maxsoru = listBox3.Items.Count;
                            dd = maxsoru;
                        }




                        //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                        if (maxsoru <= 105)
                        {
                            maxsoru = dd;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        else
                        {
                            maxsoru = 105;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        //
                        label45.Text = "Dosya Adı : " + fileName;
                        yuklendi();
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
                        yukleniyor();
                        button2.Enabled = false;
                        button2.ForeColor = Color.Red;
                        checkBox2.Enabled = false;
                        checkBox2.ForeColor = Color.Red;
                        checkBox1.Enabled = false;
                        checkBox1.ForeColor = Color.Red;
                        string sFileName = dlg.FileName;
                        dosyayolu = sFileName;
                        label2.Text = "Excel Dosyası Seçildi.";
                        string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                        //
                        string dosya_adres = dosyayolu;
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");
                        try
                        {
                            con.Open();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Dosya açık olduğundan eylem gerçekleştirilemiyor.");
                        }


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

                        ListBox.ObjectCollection list1 = listBox1.Items;
                        Random rng1 = new Random();
                        int n1 = list1.Count;
                        while (n1 > 1)
                        {
                            n1--;
                            int k1 = rng1.Next(n1 + 1);
                            string value1 = (string)list1[k1];
                            list1[k1] = list1[n1];
                            list1[n1] = value1;
                        }

                        soru_dizisi1 = new string[listBox1.Items.Count];
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            soru_dizisi1[i] = listBox1.Items[i].ToString();
                        }

                        maxsoru = listBox1.Items.Count;
                        //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                        if (maxsoru <= 105)
                        {
                            maxsoru = listBox1.Items.Count;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        else
                        {
                            maxsoru = 105;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        //
                        label45.Text = "Dosya Adı : " + fileName;
                        yuklendi();
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
                        yukleniyor();
                        button2.Enabled = false;
                        button2.ForeColor = Color.Red;
                        checkBox2.Enabled = false;
                        checkBox2.ForeColor = Color.Red;
                        checkBox1.Enabled = false;
                        checkBox1.ForeColor = Color.Red;
                        string sFileName = dlg.FileName;
                        dosyayolu = sFileName;
                        label2.Text = "Excel Dosyası Seçildi.";
                        string fileName = Path.GetFileNameWithoutExtension(dosyayolu);
                        //



                        string dosya_adres = dosyayolu;

                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosya_adres + ";Extended Properties=Excel 12.0");


                        try
                        {
                            con.Open();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Dosya açık olduğundan eylem gerçekleştirilemiyor.");
                        }

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

                        //Random r = new Random();
                        //int listbox = r.Next(0, listBox1.Items.Count);
                        //listBox1.SelectedIndex += listbox;


                        ListBox.ObjectCollection list1 = listBox1.Items;
                        Random rng1 = new Random();
                        int n1 = list1.Count;
                        while (n1 > 1)
                        {
                            n1--;
                            int k1 = rng1.Next(n1 + 1);
                            string value1 = (string)list1[k1];
                            list1[k1] = list1[n1];
                            list1[n1] = value1;
                        }




                        soru_dizisi1 = new string[listBox1.Items.Count];
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            soru_dizisi1[i] = listBox1.Items[i].ToString();
                        }



                        int h1 = listBox1.Items.Count;
                        int h2 = listBox2.Items.Count;
                        int h3 = listBox3.Items.Count;
                        int dd = 0;
                        if (h1 < h2 && h1 < h3)
                        {
                            maxsoru = listBox1.Items.Count;
                            dd = maxsoru;
                        }
                        else if (h2 < h1 && h2 < h3)
                        {
                            maxsoru = listBox2.Items.Count;
                            dd = maxsoru;
                        }
                        else
                        {
                            maxsoru = listBox3.Items.Count;
                            dd = maxsoru;
                        }



                        //maksimum girilebilecek öğrenci sayısını tanımlarsın.
                        if (maxsoru <= 105)
                        {
                            maxsoru = dd;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        else
                        {
                            maxsoru = 105;
                            button1.Enabled = true;
                            label4.Text = "Lütfen 1 ila " + maxsoru.ToString() + " arası değer giriniz.";
                        }
                        //seçilen dosyanın adını label'a yazar
                        label45.Text = "Dosya Adı : " + fileName;
                        yuklendi();
                    }
                }
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler yanlış gitti!", "Rastgele Seçici");
                reset = true;
                Form2 yeniform = new Form2();
                yeniform.Show();
                this.Close();

            }
            sart2 = true;

            if (sart1 == true && sart2 == true)
            {
                tabControl1.Enabled = true;
            }
            load_image.Visible = false;
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






        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog2 = new DialogResult();
            dialog2 = MessageBox.Show("Her şey sıfırlanacak kabul ediyor musunuz ?", "Sıfırla ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog2 == DialogResult.Yes)
            {
                reset = true;
                Form2 yeniform = new Form2();
                yeniform.Show();
                this.Close();
            }
            else
            {
                //
            }






            txtbox_ogrsayi.Text = "1";
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
                if (listBox1.Items.Count != 0)
                {
                    MessageBox.Show("Üzgünüz soru sayınız yetersiz! Soru sayınız : " + (listBox1.Items.Count) + "'dir. Lütfen soru sayınızı güncelleyiniz.", "Rastgele Seçici");
                }
                else
                {
                    MessageBox.Show("Üzgünüz soru sayınız yetersiz! Soru sayınız : " + (listBox1.Items.Count) + "'dir. Lütfen soru sayınızı güncelleyiniz.", "Rastgele Seçici");
                }
            }


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
                if (listBox2.Items.Count != 0)
                {
                    MessageBox.Show("Üzgünüz soru sayınız yetersiz! Soru sayınız : " + (listBox2.Items.Count) + "'dir. Lütfen soru sayınızı güncelleyiniz.", "Rastgele Seçici");
                }
                else
                {
                    MessageBox.Show("Üzgünüz soru sayınız yetersiz! Soru sayınız : " + (listBox2.Items.Count) + "'dir. Lütfen soru sayınızı güncelleyiniz.", "Rastgele Seçici");
                }

            }


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
                if (listBox3.Items.Count != 0)
                {
                    MessageBox.Show("Üzgünüz soru sayınız yetersiz! Soru sayınız : " + (listBox3.Items.Count) + "'dir. Lütfen soru sayınızı güncelleyiniz.", "Rastgele Seçici");
                }
                else
                {
                    MessageBox.Show("Üzgünüz soru sayınız yetersiz! Soru sayınız : " + (listBox3.Items.Count) + "'dir. Lütfen soru sayınızı güncelleyiniz.", "Rastgele Seçici");
                }
            }


        }






        private void button4_Click(object sender, EventArgs e)
        {
            Form4 y = new Form4();
            y.Show();
        }


        private void txtbox_ogrsayi_TextChanged(object sender, EventArgs e)
        {
            //if (controller != 1 && label2.Text != "Excel Dosyası Seçildi.")
            //{
            //    MessageBox.Show("Lütfen ilk önce Excel dosyanızı seçiniz.", "Rastgele Seçici");
            //}
        }







        private void s1n1_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 1;
            s1n1_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n12_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 12;
            s1n12_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
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
        private void s1n41_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 41;
            s1n41_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n42_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 42;
            s1n42_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n43_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 43;
            s1n43_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n44_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 44;
            s1n44_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n45_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 45;
            s1n45_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n46_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 46;
            s1n46_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n47_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 47;
            s1n47_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n48_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 48;
            s1n48_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n49_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 49;
            s1n49_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n50_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 50;
            s1n50_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n51_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 51;
            s1n51_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n52_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 52;
            s1n52_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n53_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 53;
            s1n53_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n54_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 54;
            s1n54_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n55_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 55;
            s1n55_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n56_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 56;
            s1n56_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n57_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 57;
            s1n57_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n58_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 58;
            s1n58_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n59_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 59;
            s1n59_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n60_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 60;
            s1n60_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n61_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 61;
            s1n61_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n62_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 62;
            s1n62_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n63_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 63;
            s1n63_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n64_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 64;
            s1n64_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n65_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 65;
            s1n65_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n66_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 66;
            s1n66_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n67_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 67;
            s1n67_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n68_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 68;
            s1n68_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n69_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 69;
            s1n69_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n70_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 70;
            s1n70_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n71_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 71;
            s1n71_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n72_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 72;
            s1n72_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n73_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 73;
            s1n73_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n74_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 74;
            s1n74_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n75_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 75;
            s1n75_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n76_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 76;
            s1n76_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n77_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 77;
            s1n77_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n78_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 78;
            s1n78_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n79_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 79;
            s1n79_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n80_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 80;
            s1n80_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n81_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 81;
            s1n81_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n82_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 82;
            s1n82_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n83_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 83;
            s1n83_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n84_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 84;
            s1n84_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n85_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 85;
            s1n85_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n86_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 86;
            s1n86_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n87_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 87;
            s1n87_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n88_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 88;
            s1n88_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n89_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 89;
            s1n89_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n90_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 90;
            s1n90_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n91_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 91;
            s1n91_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n92_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 92;
            s1n92_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n93_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 93;
            s1n93_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n94_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 94;
            s1n94_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n95_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 95;
            s1n95_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n96_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 96;
            s1n96_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n97_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 97;
            s1n97_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n98_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 98;
            s1n98_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n99_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 99;
            s1n99_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n100_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 100;
            s1n100_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n101_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 101;
            s1n101_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n102_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 102;
            s1n102_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n103_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 103;
            s1n103_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n104_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 104;
            s1n104_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }

        private void s1n105_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs1 = 105;
            s1n105_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetot();
        }








        //   S A Y F A    2    B U T T O N    C L I C K 






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

        private void s2n41_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 41;
            s2n41_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n42_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 42;
            s2n42_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n43_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 43;
            s2n43_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n44_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 44;
            s2n44_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n45_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 5;
            s2n45_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n46_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 46;
            s2n46_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n47_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 47;
            s2n47_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n48_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 48;
            s2n48_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n49_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 49;
            s2n49_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n50_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 50;
            s2n50_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n51_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 51;
            s2n51_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n52_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 52;
            s2n52_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n53_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 53;
            s2n53_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n54_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 54;
            s2n54_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n55_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 55;
            s2n55_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n56_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 56;
            s2n56_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n57_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 57;
            s2n57_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n58_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 58;
            s2n58_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n59_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 59;
            s2n59_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n60_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 60;
            s2n60_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n61_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 61;
            s2n61_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();

        }

        private void s2n62_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 62;
            s2n62_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n63_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 63;
            s2n63_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n64_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 64;
            s2n64_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n65_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 65;
            s2n65_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n66_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 66;
            s2n66_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n67_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 67;
            s2n67_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n68_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 68;
            s2n68_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n69_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 69;
            s2n69_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n70_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 70;
            s2n70_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n71_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 71;
            s2n71_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n72_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 72;
            s2n72_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n73_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 73;
            s2n73_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n74_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 74;
            s2n74_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n75_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 75;
            s2n75_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n76_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 76;
            s2n76_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n77_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 77;
            s2n77_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n78_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 78;
            s2n78_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n79_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 79;
            s2n79_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n80_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 80;
            s2n80_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n81_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 81;
            s2n81_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n82_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 82;
            s2n82_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n83_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 83;
            s2n83_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n84_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 84;
            s2n84_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n85_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 85;
            s2n85_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n86_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 86;
            s2n86_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n87_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 87;
            s2n87_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n88_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 88;
            s2n88_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n89_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 89;
            s2n89_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n90_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 90;
            s2n90_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n91_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 91;
            s2n91_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n92_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 92;
            s2n92_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n93_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 93;
            s2n93_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n94_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 94;
            s2n94_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n95_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 95;
            s2n95_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n96_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 96;
            s2n96_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n97_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 97;
            s2n97_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n98_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 98;
            s2n98_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n99_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 99;
            s2n99_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n100_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 100;
            s2n100_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n101_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 101;
            s2n101_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n102_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 102;
            s2n102_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n103_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 103;
            s2n103_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n104_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 104;
            s2n104_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }

        private void s2n105_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs2 = 105;
            s2n105_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots2();
        }








        //   S A Y F A    3    B U T T O N    C L I C K







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


        private void s3n41_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 41;
            s3n41_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n42_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 42;
            s3n42_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n43_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 43;
            s3n43_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n44_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 44;
            s3n44_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n45_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 45;
            s3n45_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n46_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 46;
            s3n46_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n47_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 47;
            s3n47_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n48_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 48;
            s3n48_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n49_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 49;
            s3n49_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n50_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 50;
            s3n50_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n51_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 51;
            s3n51_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n52_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 52;
            s3n52_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n53_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 53;
            s3n53_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n54_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 54;
            s3n54_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n55_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 55;
            s3n55_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n56_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 56;
            s3n56_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n57_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 57;
            s3n57_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n58_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 58;
            s3n58_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n59_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 59;
            s3n59_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n60_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 60;
            s3n60_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n61_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 61;
            s3n61_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n62_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 62;
            s3n62_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n63_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 63;
            s3n63_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n64_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 64;
            s3n64_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n65_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 65;
            s3n65_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n66_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 66;
            s3n66_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n67_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 67;
            s3n67_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n68_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 68;
            s3n68_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n69_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 69;
            s3n69_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n70_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 70;
            s3n70_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n71_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 71;
            s3n71_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n72_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 72;
            s3n72_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n73_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 73;
            s3n73_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n74_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 74;
            s3n74_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n75_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 75;
            s3n75_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n76_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 76;
            s3n76_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n77_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 77;
            s3n77_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n78_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 78;
            s3n78_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n79_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 79;
            s3n79_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n80_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 80;
            s3n80_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n81_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 81;
            s3n81_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n82_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 82;
            s3n82_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n83_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 83;
            s3n83_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n84_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 84;
            s3n84_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n85_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 85;
            s3n85_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n86_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 86;
            s3n86_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n87_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 87;
            s3n87_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n88_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 88;
            s3n88_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n89_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 89;
            s3n89_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n90_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 90;
            s3n90_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n91_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 91;
            s3n91_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n92_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 92;
            s3n92_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n93_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 93;
            s3n93_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n94_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 94;
            s3n94_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n95_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 95;
            s3n95_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n96_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 96;
            s3n96_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n97_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 97;
            s3n97_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n98_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 98;
            s3n98_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n99_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 99;
            s3n99_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n100_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 100;
            s3n100_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n101_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 101;
            s3n101_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n102_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 102;
            s3n102_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n103_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 103;
            s3n103_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void s3n104_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 104;
            s3n104_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            load_image.Visible = true;
        }
        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            say++;
            if (say == 1)
            {

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            load_image.Visible = true;
        }

        private void s3n105_btn_Click(object sender, EventArgs e)
        {
            hangisitiklandıs3 = 105;
            s3n105_btn.Image = Rastgele_Seçici.Properties.Resources.c2;
            sormetots3();
        }


        public void yukleniyor()
        {
            notifyIcon1.Text = "Rastgele Seçici";
            notifyIcon1.BalloonTipTitle = "Yükleniyor";
            notifyIcon1.BalloonTipText = "Excel Dosyası veriler çekiliyor..";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);
        }
        public void yuklendi()
        {
            notifyIcon1.Text = "Rastgele Seçici";
            notifyIcon1.BalloonTipTitle = "Yüklendi";
            notifyIcon1.BalloonTipText = "Excel Dosyası veriler çekildi..";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);
        }
        public void tanimlandi()
        {
            notifyIcon1.Text = "Rastgele Seçici";
            notifyIcon1.BalloonTipTitle = "Tanımlandı";
            notifyIcon1.BalloonTipText = "Öğrenci Sayısı Tanımlandı..";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);
        }


    }
}
