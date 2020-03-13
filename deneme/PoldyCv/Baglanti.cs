using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
namespace PoldyCv
{
    class Baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-VF92D18\\SQLEXPRESS;Initial Catalog=PoldyCv;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
        }
}
