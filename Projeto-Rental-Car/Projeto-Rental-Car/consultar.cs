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
    public partial class Consultar : Form
    {
        CadastrarCliente frmCliente;
        public Consultar(CadastrarCliente frmCliente)
        {
            this.frmCliente = frmCliente;
            InitializeComponent();
        }
        private void Consultar_Load(object sender, EventArgs e)
        {
            string sqlQuery;

            SqlConnection conectCliente = conexao.Conect();

            sqlQuery = "SELECT ID_CLIENTE, NOME, CPF, DATA_NASC FROM CLIENTE ORDER BY nome";
            
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conectCliente);

            DataTable dt = new DataTable();

            try
            {
                dta.Fill(dt);
                
                DGVCliente.DataSource = dt;

                DGVCliente.RowsDefaultCellStyle.BackColor = Color.White;
                DGVCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                DGVCliente.Columns[0].HeaderCell.Value = "Código do Cliente"; 
                DGVCliente.Columns[1].HeaderCell.Value = " Nome "; 
                DGVCliente.Columns[2].HeaderCell.Value = " CPF "; 
                DGVCliente.Columns[3].HeaderCell.Value = "data Nasc"; 
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

        private void Selecionar_Click(object sender, EventArgs e)
        {
            string codigoCliente;

            codigoCliente = DGVCliente.CurrentRow.Cells[0].Value.ToString();

            string sqlQuery;

            SqlConnection conClienteConsulta = conexao.Conect();

            SqlDataReader dtr = null;

            sqlQuery = "SELECT ID_CLIENTE, NOME, CPF, DATA_NASC FROM CLIENTE WHERE ID_CLIENTE = @id_cliente";

            try
            {
                conClienteConsulta.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conClienteConsulta);

                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(codigoCliente)));

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    frmCliente.codigo.Text = Convert.ToString(dtr["ID_CLIENTE"]);
                    frmCliente.nome.Text = Convert.ToString(dtr["NOME"]);
                    frmCliente.data_nasc.Text = Convert.ToString(dtr["DATA_NASC"]);
                    frmCliente.cpf.Text = Convert.ToString(dtr["CPF"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (dtr != null)
                {
                    dtr.Close();
                }
                if (conClienteConsulta != null)
                {
                    conClienteConsulta.Close();
                }
            }
            this.Close();
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

