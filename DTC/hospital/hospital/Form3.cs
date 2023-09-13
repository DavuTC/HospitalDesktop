using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class Form3 : Form
    {
        string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };//Günleri tanımladık
        string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" }; //Ayları tanımladık
        string[] saat = { "09.00", "10.00", "11.00", "12.00", "13.00", "14.00", "15.00", "16.00", "17.00"}; //saat adında dizi kullnanarak değişkenleri tanımladık 
        Random r1 = new Random(); // rastgele sayı üretmek için
        // string telefon;

        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            // telefon = float.Parse(textBox3.Text);
            if ((textBox1.Text.Length >10))
                MessageBox.Show("T.C. Kimlik No 11 Haneli Olmalıdır...");
            if((textBox1.Text.Length <12))
                MessageBox.Show("T.C. Kimlik Numarası 11 Haneli Olmalıdır...");
            //  textBox3.Text = telefon.ToString("(###)### ## ## ");

            listBox1.Items.Add(textBox1.Text); //Textlere Girilen Bilgileri Listlere Aktardık..
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button2.Enabled = true; // Button2 nın Kullanılması saglandı
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label6.Enabled = true; //label 6.7.8.9 'un Gözükmesını sagladı
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;

            int a, b, c; //a,b,c adında değişken tanımladı
            a = r1.Next(6); // rasgtle sayı ürettırdı
            b = r1.Next(11);
            c = r1.Next(18);
            label7.Text = aylar[b];//Ürettiğimiz Sayıları Labellere Taşıdı
            label8.Text = gunler[a];
            label9.Text = saat[c];

        }
        private void Form3_Load(object sender,EventArgs e)
        {
            button2.Enabled = false; //form başlarken kullanılabilirlikleri kapatır
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled =false;
        }

    }
}
