using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
