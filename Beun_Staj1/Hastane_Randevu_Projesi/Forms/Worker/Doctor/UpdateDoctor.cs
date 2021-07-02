using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms
{
    public partial class UpdateDoctor : Form
    {
        public UpdateDoctor()
        {
            InitializeComponent();
        }

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi
        Logger logger = new Logger();
        public string TCNo;
        public string Ad;
        public string Soyad;

        //RefreshDB fonksiyonu her işlem yaptıktan sonra datagridviewın yenilenmesi için kendi oluşturduğum fonksiyon
        public void RefreshDB()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_doctor", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {
            //Datagridviewa doktorlar listesini görüntülemek için...
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_doctor", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Combobox ın içerisine veritabanımdaki branşlar verisi aktarıldı..
            SqlCommand sqlCommand = new SqlCommand("Select Branch From tbl_branch ", conn.connection());
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr[0]);
            }
            conn.connection().Close();

        }
        //Doktor güncelleme fonksiyonu..
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(cmbBrans.Text) && !string.IsNullOrEmpty(txtTC.Text))
                {
                    SqlCommand command = new SqlCommand("update tbl_doctor set Name=@p1,Surname=@p2,Branch=@p3,TC=@p4 where TC=@p5", conn.connection());
                    command.Parameters.AddWithValue("@p1", txtAd.Text);
                    command.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    command.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    command.Parameters.AddWithValue("@p4", txtTC.Text); //Olası yanlış yazılan tc yi değiştirmek için.
                    command.Parameters.AddWithValue("@p5", TCNo); // Hangi doktorun bilgisini güncelleyeceğimize tc sinden filtreliyoruz.
                    command.ExecuteNonQuery();
                    RefreshDB();
                    conn.connection().Close();

                    logger.Log(Ad, Soyad, "Doktor Bilgisi Güncelledi");

                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtTC.Clear();
                    cmbBrans.ResetText();
                    MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Datagridviewda seçtiğim doktorun verilerini textbox,comboboxlara yazdırdık.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TCNo = txtTC.Text;

        }

        //O anki formu kapatıp önceki forma geri dönmesi için this.Close methodunu kullandım.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            WorkerPanel frm = new WorkerPanel();
            frm.tc = TCNo;
            frm.Show();
        }


    }
}
