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
    public partial class sinavhazirlama : Form
    {
        public sinavhazirlama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sinavsorumlusu ac = new sinavsorumlusu();
            ac.Show();
            this.Hide();
        }
    }
}
