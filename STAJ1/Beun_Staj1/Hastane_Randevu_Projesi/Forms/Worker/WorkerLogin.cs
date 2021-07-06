using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms
{
    public partial class WorkerLogin : Form
    {
        public WorkerLogin()
        {
            InitializeComponent();
        }
        public string ad;
        public string soyad;

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.
        Logger logger = new Logger();

        //Çalışan kayıt olma ekranını açar.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WorkerRegister frm = new WorkerRegister();     
            frm.Show();
        }

        //Çalışan bilgilerini girerek doğru,yanlış koşuluna göre işlemler yapılır.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mskTC.Text) && !string.IsNullOrEmpty(txtSifre.Text))
                {
                    if (mskTC.Text.Length == 11) { 
                    SqlCommand command = new SqlCommand("Select * from tbl_worker Where TC=@p1 and Password=@p2", conn.connection());
                    command.Parameters.AddWithValue("@p1", mskTC.Text);
                    command.Parameters.AddWithValue("@p2", txtSifre.Text);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        WorkerPanel pp = new WorkerPanel();
                        pp.tc = mskTC.Text; // Hangi çalışanın giriş yaptığını bilmemiz için tc sini bir sonraki formda da yakalıyoruz.
                        pp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numaranız veya şifreniz yanlış.."); //Hata mesajı
                    }
                    conn.connection().Close();
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bilgiler Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void WorkerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
