using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace yazılımproje
{
    public partial class Form1 : Form
    {
         SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H0QR142;Initial Catalog=login;Integrated Security=True");
        public static string tc, adi, soyadi, yetki;

        private void button3_Click(object sender, EventArgs e)
        {
            yenikullanici ac = new yenikullanici();
            ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifreyenile ac = new sifreyenile();
            ac.Show();
        }

        bool drmkontrol = false;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from parola", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read() == true)
            {
                if (oku["kullaniciad"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["yetki"].ToString() == "Ogrenci")
                {
                    drmkontrol = true;
                    yetki = oku[2].ToString();
                    adi = oku[3].ToString();
                    soyadi = oku[4].ToString();
                    tc = oku[5].ToString();
                    ogrenci ac = new ogrenci();
                    ac.Show();
                    break;                   
                }

                if (oku["kullaniciad"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["yetki"].ToString() == "Admin")
                {
                    drmkontrol = true;
                    yetki = oku.GetValue(2).ToString();
                    adi = oku.GetValue(3).ToString();
                    soyadi = oku.GetValue(4).ToString();
                    tc = oku.GetValue(5).ToString();
                    admin ac = new admin();
                    ac.Show();
                    break;
                }
                if (oku["kullaniciad"].ToString() == textBox1.Text && oku["sifre"].ToString() == textBox2.Text && oku["yetki"].ToString() == "Sorumlu")
                {
                    drmkontrol = true;
                    yetki = oku.GetValue(2).ToString();
                    adi = oku.GetValue(3).ToString();
                    soyadi = oku.GetValue(4).ToString();
                    tc = oku.GetValue(5).ToString();
                    sinavsorumlusu ac = new sinavsorumlusu();
                    ac.Show();
                    break;
                }
            }

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş girilemez.");
            }
            else if(drmkontrol==false)
            {
                MessageBox.Show("Veri tabanında böyle bir kullanıcı bulunamadı.");
            }
            baglanti.Close();

        }
    }
}
