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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); //Form1 e Dönüş Sağlandı
            frm1.Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

