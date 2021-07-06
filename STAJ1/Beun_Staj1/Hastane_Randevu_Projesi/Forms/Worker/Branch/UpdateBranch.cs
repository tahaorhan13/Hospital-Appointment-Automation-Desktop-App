using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms.Worker.Branch
{
    public partial class UpdateBranch : Form
    {
        public UpdateBranch()
        {
            InitializeComponent();
        }

        public string Ad;
        public string Soyad;

        //İşlemlerden sonra datagridviewımı anlık olarak yenileyip son halini göstermek için oluşturduğum fonkisyon
        public void RefreshDB()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_branch", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Branş";
        }
        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi
        Logger logger = new Logger();

        //Datagridviewda seçtiğim doktorun verilerini textbox,comboboxlara yazdırdık.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBrans.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void UpdateBranch_Load(object sender, EventArgs e)
        {
            //Datagridviewa branşlar listesini görüntülemek için...
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_branch", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Branş";
        }

        //Branş Güncelleme Fonksiyonu..
        private void btnBransGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtBrans.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Güncellemek İstiyor Musunuz ? ", "Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("update tbl_branch set Branch=@p1 where Id=@p2", conn.connection());
                        command.Parameters.AddWithValue("@p1", txtBrans.Text);
                        command.Parameters.AddWithValue("@p2", txtId.Text);
                        command.ExecuteNonQuery();
                        RefreshDB();
                        conn.connection().Close();

                        logger.Log(Ad, Soyad, "Branş Güncelledi");

                        MessageBox.Show("Branş Güncellendi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir branş yok", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Log(Ad, Soyad, ex.Message);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
