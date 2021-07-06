using System.Data.SqlClient;

namespace Hastane_Randevu_Projesi
{
    class DbConnection 
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-L5EJ319\\SQLEXPRESS;Initial Catalog=Hastane.Randevu;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
