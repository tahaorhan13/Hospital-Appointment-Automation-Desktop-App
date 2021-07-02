using Hastane_Randevu_Projesi.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi
{
    public partial class PatientPanel : Form
    {
        public PatientPanel()
        {
            InitializeComponent();
        }
        public string ad;
        public string soyad;
        public string tc;
        public string secilentarih;

        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.
        
        private void PatientPanel_Load(object sender, EventArgs e)
        {
            //Hastanın bilgilerini kişisel bilgierimdeki labellara yazdırma.
            lblTc.Text = tc;
            lblAdSoyad2.Text = ad + ' ' + soyad;

            SqlCommand command = new SqlCommand("Select Name,Surname From tbl_patient where TC=@p1", conn.connection());
            command.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                //Hoşgeldiniz açıklaması için hastanın bilgisini labellara aktarma
                lblAdSoyad2.Text = dr[0] + " " + dr[1];
                lblHosgeldinizAciklama.Text= "Sn.  " + dr[0] + " " + dr[1] + ", Randevu Sistemine Hoşgeldiniz.";
            }
            conn.connection().Close();

        }

        //Randevu ekranını açan buton.
        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentScreen frm = new AppointmentScreen();
            frm.Tc = tc; //tc sini açılacak olan forma aktararak hangi hasta için randevu görüntüleyeceğimizi belirliyoruz.
            frm.ad = ad;
            frm.soyad = soyad;
            frm.Show();
            
        }

        //Hastanın bilgilerini güncelliyeceği form ekranını açan buton.
        private void button2_Click(object sender, EventArgs e)
        {
            PatientInformationUpdate frm = new PatientInformationUpdate();
            frm.TCNo = tc; //tc sini açılacak olan forma aktararak hangi hasta için işlem yapacağımızı belirliyoruz
            frm.Show();
        }
    }
}
