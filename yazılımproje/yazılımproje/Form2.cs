using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımproje
{
    public partial class ogrenci : Form
    {
        public ogrenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinav ac = new sinav();
            ac.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayarlar ac = new ayarlar();
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Form1 ac = new Form1();
            ac.Show();
            this.Hide();
            

        }
    }
}
