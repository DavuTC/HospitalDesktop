using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false; //Form ba�larkene kullan�l�rl���n� kapat�r
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true; //CheckBox a t�kland���nda kullan�labilir hale gelir
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //form2 �a��rd�m
            frm2.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();//form 3 � �a��rd�m 
            frm3.Show();
            this.Hide();
        }

    }
}