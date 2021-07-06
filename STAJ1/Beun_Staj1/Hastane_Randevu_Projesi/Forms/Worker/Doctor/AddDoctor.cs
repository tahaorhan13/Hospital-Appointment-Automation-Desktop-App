using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }
        public string tc;
        public string Ad;
        public string Soyad;
        //RefreshDB fonksiyonu her işlem yaptıktan sonra datagridviewın yenilenmesi için kendi oluşturduğum fonksiyon
        public void RefreshDB()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (Name + ' ' + Surname) as 'Doktorlar',Branch  From tbl_doctor", conn.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        //Veritabanı bağlantı nesnesi
        DbConnection conn = new DbConnection();
        Logger logger = new Logger();
        private void AddDoctor_Load(object sender, EventArgs e)
        {
            //Datagridviewa doktorlar listesini görüntülemek için...
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (Name + ' ' + Surname) as 'Doktorlar',Branch as 'Branş'  From tbl_doctor", conn.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Combobox ın içerisine veritabanımdaki branşlar verisi aktarıldı..
            SqlCommand command = new SqlCommand("Select Branch From tbl_branch", conn.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr[0]);
            }
            conn.connection().Close();

        }

        //Doktor ekleme fonksiyonu..
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(cmbBrans.Text) && !string.IsNullOrEmpty(txtTC.Text))
                {
                    if (txtTC.Text.Length == 11)
                    {
                        SqlCommand command = new SqlCommand("insert into tbl_doctor (Name,Surname,Branch,TC) values (@p1,@p2,@p3,@p4)", conn.connection());
                        command.Parameters.AddWithValue("@p1", txtAd.Text);
                        command.Parameters.AddWithValue("@p2", txtSoyad.Text);
                        command.Parameters.AddWithValue("@p3", cmbBrans.Text);
                        command.Parameters.AddWithValue("@p4", txtTC.Text);
                        command.ExecuteNonQuery();
                        RefreshDB();
                        conn.connection().Close();


                        logger.Log(Ad, Soyad, "Doktor Ekledi");

                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtTC.Clear();
                        cmbBrans.ResetText();
                        MessageBox.Show("Doktor Kaydınız Gerçekleşmiştir");
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik Numarası 11 Haneden Az Veya Fazla Olamaz");
                    }

                }
                else
                {
                    MessageBox.Show("Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                logger.Log(txtAd.Text, txtSoyad.Text, ex.Message);
            }

        }
        //O anki formu kapatıp önceki forma geri dönmesi için this.Close metodunu kullandım.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            WorkerPanel frm = new WorkerPanel();
            frm.tc = tc;
            frm.Show();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
