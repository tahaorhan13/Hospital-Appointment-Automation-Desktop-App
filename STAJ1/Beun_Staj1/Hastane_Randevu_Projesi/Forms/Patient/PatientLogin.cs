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
        Logger logger = new Logger();

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
                    if (mskTC.Text.Length == 11)
                    {
                        SqlCommand command = new SqlCommand("Select * from tbl_patient Where TC=@p1 and Password=@p2", conn.connection());
                        command.Parameters.AddWithValue("@p1", mskTC.Text);
                        command.Parameters.AddWithValue("@p2", txtSifre.Text);
                        SqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            PatientPanel pp = new PatientPanel();
                            pp.tc = mskTC.Text;
                            pp.ad = ad;
                            pp.soyad = soyad;
                            pp.Show();
                            logger.Log(ad, soyad, "Giriş yaptı");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("TC Kimlik Numaranız veya şifreniz yanlış..");
                        }
                        conn.connection().Close();
                    }
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numaranız veya Şifreniz Boş Olamaz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Log(ad, soyad, ex.Message);
            }


        }

        private void mskTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
