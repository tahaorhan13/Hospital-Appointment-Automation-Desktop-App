using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms.Worker
{
    public partial class WorkerInformationUpdate : Form
    {
        public WorkerInformationUpdate()
        {
            InitializeComponent();
        }
        DbConnection conn = new DbConnection();
        Logger logger = new Logger();
        public string TCNo;
        private void WorkerInformationUpdate_Load(object sender, EventArgs e)
        {
            //Güncelleme yapacak hastanın bilgilerini oluşturduğumuz textbox,maskedtextbox,comboboxlara aktarıyoruz.
            txtTC.Text = TCNo;

            SqlCommand sqlCommand = new SqlCommand("Select * From tbl_worker where TC=@p1", conn.connection());
            sqlCommand.Parameters.AddWithValue("@p1", txtTC.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtTel.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            conn.connection().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTel.Text) && !string.IsNullOrEmpty(txtSifre.Text) && !string.IsNullOrEmpty(cmbCinsiyet.Text))
                {
                    if (txtTC.Text.Length == 11 && txtTel.Text.Length == 11)
                    {
                        SqlCommand komut2 = new SqlCommand("update tbl_worker set Name=@p1,Surname=@p2,TC=@p3,PhoneNumber=@p4,Password=@p5,Gender=@p6 where TC=@p3", conn.connection());
                        komut2.Parameters.AddWithValue("@p1", txtAd.Text);
                        komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
                        komut2.Parameters.AddWithValue("@p3", txtTC.Text);
                        komut2.Parameters.AddWithValue("@p4", txtTel.Text);
                        komut2.Parameters.AddWithValue("@p5", txtSifre.Text);
                        komut2.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);

                        komut2.ExecuteNonQuery();
                        conn.connection().Close();
                        logger.Log(txtAd.Text, txtSoyad.Text, "Çalışanı Bilgisini Güncelledi");
                        MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numaranız veya Telefon Numaranız 11 haneden az veya fazla giremezsiniz");
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Log(txtAd.Text, txtSoyad.Text, ex.Message);
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                   && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
