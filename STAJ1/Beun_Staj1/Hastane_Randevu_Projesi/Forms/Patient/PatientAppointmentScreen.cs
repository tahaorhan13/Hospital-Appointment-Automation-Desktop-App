using Hastane_Randevu_Projesi.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi
{
    public partial class AppointmentScreen : Form
    {
        public AppointmentScreen()
        {
            InitializeComponent();
        }
        DbConnection conn = new DbConnection(); //Veritabanı bağlantı nesnesi.
        Logger logger = new Logger();
        public string ad;
        public string soyad;
        public string Tc;
        public string[] hour = new string[15];

        private void AppointmentScreen_Load(object sender, EventArgs e)
        {
            //Branşları comboboxa aktarır.
            SqlCommand command1 = new SqlCommand("Select Branch From tbl_branch", conn.connection());
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBrans.Items.Add(dr1[0]);
            }
            conn.connection().Close();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";


            SqlCommand command2 = new SqlCommand("Select Checked,Time From tbl_check", conn.connection());
            SqlDataReader dr2 = command2.ExecuteReader();

            while (dr2.Read())
            {
                if ((bool)dr2[0])
                {
                    cmbSaat.Items.Add(dr2[1]);
                }
            }
            conn.connection().Close();



        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_appointment where Branch='" + cmbBrans.Text + "'", conn.connection());
            da.Fill(dt);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand command3 = new SqlCommand("Select Name,Surname From tbl_doctor where Branch=@p1", conn.connection());
            command3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            conn.connection().Close();
        }

        //Randevu Alma Fonksiyonu
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int appointmentno = rnd.Next();
                if (!string.IsNullOrEmpty(dateTimePicker1.Text) && !string.IsNullOrEmpty(cmbSaat.Text) && !string.IsNullOrEmpty(cmbBrans.Text) && !string.IsNullOrEmpty(cmbDoktor.Text) && !string.IsNullOrEmpty(Tc) && !string.IsNullOrEmpty(appointmentno.ToString()))
                {
                    

                    SqlCommand command = new SqlCommand("insert into tbl_appointment (Date,Hour,Branch,DoctorName,TC,RandevuNo) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.connection());
                    command.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@p2", cmbSaat.Text);
                    command.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    command.Parameters.AddWithValue("@p4", cmbDoktor.Text);
                    command.Parameters.AddWithValue("@p5", Tc);
                    command.Parameters.AddWithValue("@p6", appointmentno);
                    command.ExecuteNonQuery();
                    conn.connection().Close();
                    MessageBox.Show("Randevu Kaydınız Gerçekleşmiştir ");

                    logger.Log(ad, soyad, "Randevu aldı");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            OldAppointment frm = new OldAppointment();
            frm.tcno = Tc;
            frm.Ad = ad;
            frm.Soyad = soyad;
            frm.Show();
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
