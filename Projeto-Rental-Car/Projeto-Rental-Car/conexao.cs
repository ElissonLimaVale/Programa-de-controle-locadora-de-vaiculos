using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Projeto_Rental_Car
{
    public class conexao
    {
      
        public static SqlConnection Conect()
        {
            SqlConnection conect = new SqlConnection("Data Source=(localdb)\"MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return conect;
        }
      
    }
}
