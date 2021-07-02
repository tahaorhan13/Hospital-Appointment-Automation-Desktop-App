using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms.Worker.Branch
{
    public partial class DeleteBranch : Form
    {
        public DeleteBranch()
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
        }
        DbConnection conn = new DbConnection();//Veritabanı bağlantı nesnesi
        Logger logger = new Logger();
        private void DeleteBranch_Load(object sender, EventArgs e)
        {
            //Datagridviewa branşlar listesini görüntülemek için...
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_branch", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Datagridviewda seçtiğim doktorun verilerini textbox,comboboxlara yazdırdık.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbBrans.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        //Branş Silme Fonksiyonu..
        private void btnBransSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbBrans.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Silmek İstiyor Musunuz ? ", "Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("delete from tbl_branch where Branch=@p1", conn.connection());
                        command.Parameters.AddWithValue("@p1", cmbBrans.Text);
                        command.ExecuteNonQuery();
                        RefreshDB();
                        conn.connection().Close();

                        logger.Log(Ad, Soyad, "Branş Sildi");

                        MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir branş yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
