using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string ad;
        public string soyad;

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.

        //Kayıt olma formunu açar.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Giriş ekranında girdiği bilgiler doğru olma veya yanlış olma durumunda yapacağı işlemler.(if,else bloklarında)
            try
            {
                if (!string.IsNullOrEmpty(mskTC.Text) && !string.IsNullOrEmpty(txtSifre.Text))
                {
                    SqlCommand command = new SqlCommand("Select * from tbl_patient Where TC=@p1 and Password=@p2", conn.connection());
                    command.Parameters.AddWithValue("@p1", Convert.ToInt32(mskTC.Text));
                    command.Parameters.AddWithValue("@p2", txtSifre.Text);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        PatientPanel pp = new PatientPanel();
                        pp.tc = mskTC.Text;
                        pp.ad = ad;
                        pp.soyad = soyad;
                        pp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numaranız veya şifreniz yanlış..");
                    }
                    conn.connection().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void mskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
