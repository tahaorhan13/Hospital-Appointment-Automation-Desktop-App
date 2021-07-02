using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms.Appointment
{
    public partial class ArrangingAppointmentTime : Form
    {
        public ArrangingAppointmentTime()
        {
            InitializeComponent();
        }
        public string Ad;
        public string Soyad;
        DbConnection conn = new DbConnection();
        Logger logger = new Logger();
        private void ArrangingAppointmentTime_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand1 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand1.Parameters.AddWithValue("@p1", checkBox1.Text);
            SqlDataReader dr1 = sqlCommand1.ExecuteReader();
            while (dr1.Read())
            {
                checkBox1.Checked = (bool)dr1[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand2 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand2.Parameters.AddWithValue("@p1", checkBox2.Text);
            SqlDataReader dr2 = sqlCommand2.ExecuteReader();
            while (dr2.Read())
            {
                checkBox2.Checked = (bool)dr2[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand3 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand3.Parameters.AddWithValue("@p1", checkBox3.Text);
            SqlDataReader dr3 = sqlCommand3.ExecuteReader();
            while (dr3.Read())
            {
                checkBox3.Checked = (bool)dr3[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand4 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand4.Parameters.AddWithValue("@p1", checkBox4.Text);
            SqlDataReader dr4 = sqlCommand4.ExecuteReader();
            while (dr4.Read())
            {
                checkBox4.Checked = (bool)dr4[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand5 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand5.Parameters.AddWithValue("@p1", checkBox5.Text);
            SqlDataReader dr5 = sqlCommand5.ExecuteReader();
            while (dr5.Read())
            {
                checkBox5.Checked = (bool)dr5[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand6 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand6.Parameters.AddWithValue("@p1", checkBox6.Text);
            SqlDataReader dr6 = sqlCommand6.ExecuteReader();
            while (dr6.Read())
            {
                checkBox6.Checked = (bool)dr6[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand7 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand7.Parameters.AddWithValue("@p1", checkBox7.Text);
            SqlDataReader dr7 = sqlCommand7.ExecuteReader();
            while (dr7.Read())
            {
                checkBox7.Checked = (bool)dr7[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand8 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand8.Parameters.AddWithValue("@p1", checkBox8.Text);
            SqlDataReader dr8 = sqlCommand8.ExecuteReader();
            while (dr8.Read())
            {
                checkBox8.Checked = (bool)dr8[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand9 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand9.Parameters.AddWithValue("@p1", checkBox9.Text);
            SqlDataReader dr9 = sqlCommand9.ExecuteReader();
            while (dr9.Read())
            {
                checkBox9.Checked = (bool)dr9[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand10 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand10.Parameters.AddWithValue("@p1", checkBox10.Text);
            SqlDataReader dr10 = sqlCommand10.ExecuteReader();
            while (dr10.Read())
            {
                checkBox10.Checked = (bool)dr10[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand11 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand11.Parameters.AddWithValue("@p1", checkBox11.Text);
            SqlDataReader dr11 = sqlCommand11.ExecuteReader();
            while (dr11.Read())
            {
                checkBox11.Checked = (bool)dr11[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand12 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand12.Parameters.AddWithValue("@p1", checkBox12.Text);
            SqlDataReader dr12 = sqlCommand12.ExecuteReader();
            while (dr12.Read())
            {
                checkBox12.Checked = (bool)dr12[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand13 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand13.Parameters.AddWithValue("@p1", checkBox13.Text);
            SqlDataReader dr13 = sqlCommand13.ExecuteReader();
            while (dr13.Read())
            {
                checkBox13.Checked = (bool)dr13[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand14 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand14.Parameters.AddWithValue("@p1", checkBox14.Text);
            SqlDataReader dr14 = sqlCommand14.ExecuteReader();
            while (dr14.Read())
            {
                checkBox14.Checked = (bool)dr14[1];
            }
            conn.connection().Close();

            SqlCommand sqlCommand15 = new SqlCommand("Select * From tbl_check where Time=@p1", conn.connection());
            sqlCommand15.Parameters.AddWithValue("@p1", checkBox15.Text);
            SqlDataReader dr15 = sqlCommand15.ExecuteReader();
            while (dr15.Read())
            {
                checkBox15.Checked = (bool)dr15[1];
            }
            conn.connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut1.Parameters.AddWithValue("@p1", checkBox1.Checked);
            komut1.Parameters.AddWithValue("@p2", checkBox1.Text);
            komut1.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm1 = new AppointmentScreen();
            if (checkBox1.Checked)
            {
                frm1.hour.Append(checkBox1.Text.ToString());
            }

            SqlCommand komut2 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut2.Parameters.AddWithValue("@p1", checkBox2.Checked);
            komut2.Parameters.AddWithValue("@p2", checkBox2.Text);
            komut2.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm2 = new AppointmentScreen();
            frm2.hour.Append(checkBox2.Text);

            SqlCommand komut3 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut3.Parameters.AddWithValue("@p1", checkBox3.Checked);
            komut3.Parameters.AddWithValue("@p2", checkBox3.Text);
            komut3.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm3 = new AppointmentScreen();
            frm3.hour.Append(checkBox3.Text);

            SqlCommand komut4 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut4.Parameters.AddWithValue("@p1", checkBox4.Checked);
            komut4.Parameters.AddWithValue("@p2", checkBox4.Text);
            komut4.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm4 = new AppointmentScreen();
            frm4.hour.Append(checkBox4.Text);

            SqlCommand komut5 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut5.Parameters.AddWithValue("@p1", checkBox5.Checked);
            komut5.Parameters.AddWithValue("@p2", checkBox5.Text);
            komut5.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm5 = new AppointmentScreen();
            frm5.hour.Append(checkBox5.Text);

            SqlCommand komut6 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut6.Parameters.AddWithValue("@p1", checkBox6.Checked);
            komut6.Parameters.AddWithValue("@p2", checkBox6.Text);
            komut6.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm6 = new AppointmentScreen();
            frm6.hour.Append(checkBox6.Text);

            SqlCommand komut7 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut7.Parameters.AddWithValue("@p1", checkBox7.Checked);
            komut7.Parameters.AddWithValue("@p2", checkBox7.Text);
            komut7.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm7 = new AppointmentScreen();
            frm7.hour.Append(checkBox7.Text);

            SqlCommand komut8 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut8.Parameters.AddWithValue("@p1", checkBox8.Checked);
            komut8.Parameters.AddWithValue("@p2", checkBox8.Text);
            komut8.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm8 = new AppointmentScreen();
            frm8.hour.Append(checkBox8.Text);

            SqlCommand komut9 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut9.Parameters.AddWithValue("@p1", checkBox9.Checked);
            komut9.Parameters.AddWithValue("@p2", checkBox9.Text);
            komut9.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm9 = new AppointmentScreen();
            frm9.hour.Append(checkBox9.Text);

            SqlCommand komut10 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut10.Parameters.AddWithValue("@p1", checkBox10.Checked);
            komut10.Parameters.AddWithValue("@p2", checkBox10.Text);
            komut10.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm10 = new AppointmentScreen();
            frm10.hour.Append(checkBox10.Text);

            SqlCommand komut11 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut11.Parameters.AddWithValue("@p1", checkBox11.Checked);
            komut11.Parameters.AddWithValue("@p2", checkBox11.Text);
            komut11.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm11 = new AppointmentScreen();
            frm11.hour.Append(checkBox11.Text);

            SqlCommand komut12 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut12.Parameters.AddWithValue("@p1", checkBox12.Checked);
            komut12.Parameters.AddWithValue("@p2", checkBox12.Text);
            komut12.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm12 = new AppointmentScreen();
            frm12.hour.Append(checkBox12.Text);

            SqlCommand komut13 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut13.Parameters.AddWithValue("@p1", checkBox13.Checked);
            komut13.Parameters.AddWithValue("@p2", checkBox13.Text);
            komut13.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm13 = new AppointmentScreen();
            frm13.hour.Append(checkBox13.Text);

            SqlCommand komut14 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut14.Parameters.AddWithValue("@p1", checkBox14.Checked);
            komut14.Parameters.AddWithValue("@p2", checkBox14.Text);
            komut14.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm14 = new AppointmentScreen();
            frm14.hour.Append(checkBox14.Text);

            SqlCommand komut15 = new SqlCommand("update tbl_check set Checked=@p1 where Time=@p2", conn.connection());
            komut15.Parameters.AddWithValue("@p1", checkBox15.Checked);
            komut15.Parameters.AddWithValue("@p2", checkBox15.Text);
            komut15.ExecuteNonQuery();
            conn.connection().Close();
            AppointmentScreen frm15 = new AppointmentScreen();
            frm15.hour.Append(checkBox15.Text);

            logger.Log(Ad, Soyad, "Saatte düzenleme yaptı");

            MessageBox.Show("Saatler düzenlendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
