using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renklerin_Dili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kırmızı") 
            {
                label2.Text = "Dikkat Çekici Bir Renktir.";
                button2.BackColor = Color.Red;
            }
            if(comboBox1.Text == "Beyaz")
            {
                label2.Text = "Temizliği ve Saflığı İfade Eder.";
                button2.BackColor = Color.White;
            }
            if (comboBox1.Text == "Yeşil") 
            {
                label2.Text = "Vejeteryanlığı Temsil Eder.";
                button2.BackColor = Color.Green;
            }
            if (comboBox1.Text == "Kahverengi") 
            {
                label2.Text = "Kahverengi İnsanların Daha Hızlı Hareket Etmelerine Neden Olur.";
                button2.BackColor = Color.Brown;
            }
            if (comboBox1.Text == "Siyah") 
            {
                label2.Text = "Hırsı ve Gücü Temsil Eder.";
                button2.BackColor = Color.Black;
            }
            if (comboBox1.Text == "Gri") 
            {
                label2.Text = "Diplomatik ve Ağır bir Renktir.";
                button2.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Mor") 
            {
                label2.Text = "Mor Renginin İnsanların Bilinç Altlarındaki Korkuyu Açığa Çıkarttığı Tespit Edilmiştir.";
                button2.BackColor = Color.Purple;
            }
            if (comboBox1.Text == "Mavi") 
            {
                label2.Text = "Sakinleştirici bir Renktir.";
                button2.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Sarı") 
            {
                label2.Text = "Geçiciliğin İfadesidir.";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Turuncu") 
            {
                label2.Text = "Kırmızı Gibi Dikkat Çekici bir Renktir.";
                button2.BackColor = Color.Orange;
            }
            if (comboBox1.Text == "Pembe")
            { 
                label2.Text = "Karşı Tarafa Rahatlık Hissi Gönderir.";
                button2.BackColor = Color.Pink;
            }
        }
    }
}
