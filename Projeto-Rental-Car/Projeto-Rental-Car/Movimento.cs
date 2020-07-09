using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projeto_Rental_Car
{
    public partial class Verificacao : Form
    {
        public Verificacao()
        {
            InitializeComponent();
        }

        private void Verificacao_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            string sqlQuery;

            SqlConnection conectCliente = conexao.Conect();

            sqlQuery = "SELECT * FROM LOCACAO ORDER BY NR_LOCACAO";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conectCliente);
            DataTable dt = new DataTable();
            try
            {
                dta.Fill(dt);

                DGV_LOCACAO.DataSource = dt;

                DGV_LOCACAO.RowsDefaultCellStyle.BackColor = Color.White;
                DGV_LOCACAO.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                DGV_LOCACAO.Columns[0].HeaderCell.Value = " Numero da Locação ";
                DGV_LOCACAO.Columns[1].HeaderCell.Value = " ID do Cliente ";
                DGV_LOCACAO.Columns[2].HeaderCell.Value = " Placa do Veiculo ";
                notific.ForeColor = Color.Green;
                notific.Text = "Todas as Locações.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao listar clientes " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conectCliente != null)
                {
                    conectCliente.Close();
                }
            }
        
    }
    }
}
