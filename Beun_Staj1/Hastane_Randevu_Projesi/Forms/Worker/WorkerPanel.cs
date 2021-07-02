using Hastane_Randevu_Projesi.Forms.Appointment;
using Hastane_Randevu_Projesi.Forms.Worker;
using Hastane_Randevu_Projesi.Forms.Worker.Branch;
using Hastane_Randevu_Projesi.Forms.Worker.Doctor;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms
{
    public partial class WorkerPanel : Form
    {
        public WorkerPanel()
        {
            InitializeComponent();
        }
        public string ad;
        public string soyad;
        public string tc;
        public string tel;
        public string cinsiyet;

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.
        private void WorkerPanel_Load(object sender, EventArgs e)
        {
            //Çalışan bilgilerini tutarak form da ayırdığımız yerde bilgilerini görüntüleyebilir.
            //lblAd.Text = ad;
            lblTc.Text = tc;
            //lblSoyad.Text = tel;

            SqlCommand command = new SqlCommand("Select Name,Surname,PhoneNumber,Gender From tbl_worker where TC=@p1", conn.connection());
            command.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0] + "";
                lblSoyad.Text = dr[1] + "";
                lblTel.Text = dr[2] + "";
                lblCinsiyet.Text = dr[3] + "";
            }
            ad = lblAd.Text;
            soyad = lblSoyad.Text;
            conn.connection().Close();

        }

        //Doktor ekleme formunu açar.
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            AddDoctor frm = new AddDoctor();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
            this.Close();
        }
        //Doktor güncelleme formunu açar.
        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            UpdateDoctor frm = new UpdateDoctor();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
            this.Close();
        }
        //Doktor silme formunu açar.
        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            DeleteDoctor frm = new DeleteDoctor();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
            this.Close();
        }
        //Branş ekleme formunu açar.
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            AddBranch frm = new AddBranch();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
        }
        //Branş silme formunu açar.
        private void btnBransSil_Click(object sender, EventArgs e)
        {
            DeleteBranch frm = new DeleteBranch();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
        }
        //Branş güncelleme formunu açar.
        private void btnBransGuncelle_Click(object sender, EventArgs e)
        {
            UpdateBranch frm = new UpdateBranch();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();

        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            WorkerInformationUpdate frm = new WorkerInformationUpdate();
            frm.TCNo = tc;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrangingAppointmentTime frm = new ArrangingAppointmentTime();
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
        }
    }
}
