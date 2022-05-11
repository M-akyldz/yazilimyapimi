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
    public partial class sinav : Form
    {
        public sinav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.Hour.ToString();
            label10.Text = DateTime.Now.Minute.ToString();
            if (comboBox2.Text == label10.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("Sınav Süreniz Bitmiştir ");               
            }
        }
        private void sinav_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++) 
            {
                comboBox1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }


    }
}
