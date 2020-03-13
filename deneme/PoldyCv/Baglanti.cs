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
            SqlConnection baglan = new SqlConnection("Data Source=FERIT\\FERIT;Initial Catalog=PoldyCv;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
        }
}
