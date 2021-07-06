using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms.Worker.Branch
{
    public partial class AddBranch : Form
    {
        public AddBranch()
        {
            InitializeComponent();
        }
        public string Ad;
        public string Soyad;
        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi
        Logger logger = new Logger();

        //RefreshDB fonksiyonu her işlem yaptıktan sonra datagridviewın yenilenmesi için kendi oluşturduğum fonksiyon
        public void RefreshDB()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_branch", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Branş";
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {
            //Datagridviewa branşlar listesini görüntülemek için...
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_branch", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Branş";
        }
        //Branş Ekleme Fonksiyonu..
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBrans.Text))
                {
                    SqlCommand command = new SqlCommand("insert into tbl_branch (Branch) values (@p1)", conn.connection());
                    command.Parameters.AddWithValue("@p1", txtBrans.Text);
                    command.ExecuteNonQuery();
                    RefreshDB();
                    conn.connection().Close();

                    logger.Log(Ad, Soyad, "Branş Ekledi");

                    MessageBox.Show("Branş Ekleme İşleminiz Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                logger.Log(Ad, Soyad, ex.Message);
            }
            

        }

        //O anki formu kapatıp önceki forma geri dönmesi için this.Close methodunu kullandım.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
