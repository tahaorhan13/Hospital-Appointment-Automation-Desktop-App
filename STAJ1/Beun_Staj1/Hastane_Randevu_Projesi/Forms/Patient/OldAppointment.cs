using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms
{
    public partial class OldAppointment : Form
    {
        public OldAppointment()
        {
            InitializeComponent();
        }

        public string tcno;
        public string Ad;
        public string Soyad;

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.
        Logger logger = new Logger();
        public void RefreshDB()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_appointment", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void OldAppointment_Load(object sender, EventArgs e)
        {
            //Hastanın aldığı randevuları datagridview da listeler.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_appointment where TC=" + tcno, conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].HeaderText = "Tarih";
            dataGridView1.Columns[2].HeaderText = "Saat";
            dataGridView1.Columns[3].HeaderText = "Branş";
            dataGridView1.Columns[4].HeaderText = "Doktor Adı";

        }

        private void btnRandevuiptal_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRandevu.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Silmek İstiyor Musunuz ? ", "Onay Ekranı", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("delete from tbl_appointment where RandevuNo=@p1", conn.connection());
                        command.Parameters.AddWithValue("@p1", txtRandevu.Text);
                        command.ExecuteNonQuery();
                        RefreshDB();
                        conn.connection().Close();

                        logger.Log(Ad, Soyad, "Randevu İptal Etti");
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir randevu bulunmamaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                logger.Log(Ad, Soyad, ex.Message);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTarih.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSaat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBrans.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDoktor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRandevu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
