﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.
        Logger logger = new Logger();

        //Hasta ekleme(kayıt olma) fonksiyonu..
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(mskTel.Text) && !string.IsNullOrEmpty(txtSifre.Text) && !string.IsNullOrEmpty(cmbCinsiyet.Text))
                {
                    if (txtTC.Text.Length == 11 && mskTel.Text.Length==11)
                    {
                        SqlCommand command = new SqlCommand("insert into tbl_patient (Name,Surname,TC,PhoneNumber,Password,Gender) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.connection());
                        command.Parameters.AddWithValue("@p1", txtAd.Text);
                        command.Parameters.AddWithValue("@p2", txtSoyad.Text);
                        command.Parameters.AddWithValue("@p3", txtTC.Text);
                        command.Parameters.AddWithValue("@p4", mskTel.Text);
                        command.Parameters.AddWithValue("@p5", txtSifre.Text);
                        command.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
                        command.ExecuteNonQuery();
                        logger.Log(txtAd.Text, txtSoyad.Text, "Kayıt işlemi yaptı");
                        conn.connection().Close();
                        MessageBox.Show("Kaydınız Gerçekleşmiştir");
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numarası 11 haneli olmak zorundadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Log(txtAd.Text, txtSoyad.Text, ex.Message);
            }

        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mskTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
    }
}
