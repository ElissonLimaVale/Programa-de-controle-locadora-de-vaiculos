using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Rental_Car
{
    public class conexao
    {
      
        public static SqlConnection Conect()
        {
            try
            {
                SqlConnection conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Projeto;Integrated Security=True;Pooling=False");
                return conect;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
        }
      
    }
}
