using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms.Worker.Doctor
{
    public partial class DeleteDoctor : Form
    {
        public DeleteDoctor()
        {
            InitializeComponent();
        }
        public string tc;
        public string Ad;
        public string Soyad;
        //RefreshDB fonksiyonu her işlem yaptıktan sonra datagridviewın yenilenmesi için kendi oluşturduğum fonksiyon
        public void RefreshDB()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_doctor", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "TC";
        }

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi
        Logger logger = new Logger();

        //Doktor silme fonksiyonu..
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(cmbBrans.Text) && !string.IsNullOrEmpty(txtTC.Text))
                {
                    if (txtTC.Text.Length == 11)
                    {
                        DialogResult dialogResult = MessageBox.Show("Silmek İstiyor Musunuz ? ", "Onay Ekranı", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SqlCommand command = new SqlCommand("delete from tbl_doctor where TC=@p1", conn.connection());
                            command.Parameters.AddWithValue("@p1", txtTC.Text);
                            command.ExecuteNonQuery();
                            RefreshDB();
                            conn.connection().Close();

                            logger.Log(Ad, Soyad, "Doktor sildi");

                            txtAd.Clear();
                            txtSoyad.Clear();
                            txtTC.Clear();
                            cmbBrans.ResetText();
                        }
                        else
                        {
                            MessageBox.Show("TC Kimlik Numarası 11 haneden az veya fazla olamaz");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                logger.Log(Ad, Soyad, ex.Message);
            }

        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {
            //Datagridviewa doktorlar listesini görüntülemek için...
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_doctor", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "TC";
        }

        //Datagridviewda seçtiğim doktorun verilerini textbox,comboboxlara yazdırdık.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        //O anki formu kapatıp önceki forma geri dönmesi için this.Close methodunu kullandım.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            WorkerPanel frm = new WorkerPanel();
            frm.tc = tc;
            frm.Show();
        }
    }
}
