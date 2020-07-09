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
    public partial class CadastrarVeiculo : Form
    {
        
        public CadastrarVeiculo()
        {
            InitializeComponent();
        }
        private void habilitar()
        {
            Seleciona.Enabled = true;
        }
        private void desabilitar()
        {
            Seleciona.Enabled = false;
        }
        private void limparControles()
        {
            Modelo.Clear();
            Placa.Clear();
            Fabricante.Clear();
            Cor.Clear();
            Ano.Clear();
        }
        private bool validaDados()
        {
            if (string.IsNullOrEmpty(Ano.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                Ano.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Cor.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                Cor.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Modelo.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                Modelo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Fabricante.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                Fabricante.Focus();
                return false;
            }
            notific.Text = "";
            return true;
        }
        private void CadastrarVeiculo_Load(object sender, EventArgs e)
        {
            desabilitar();
            notific.Text = "";
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }
        private void Inserir_Click(object sender, EventArgs e)
        {
            desabilitar();
            string Ano1, Fabricante1, Modelo1, Cor1, Placa1;
            Ano1 = Convert.ToString(Ano.Text);
            Fabricante1 = Convert.ToString(Fabricante.Text);
            Modelo1 = Convert.ToString(Modelo.Text);
            Cor1 = Convert.ToString(Cor.Text);
            Placa1 = Convert.ToString(Placa.Text);
            // DATA1 = Convert.ToString(cpf.Text);
            notific.ForeColor = Color.Green;
            notific.Text = "Inserindo dados ....";

            if (validaDados() == false)
            {
                return;
            }
            string sqlQuery,Sqlquery1;
            SqlConnection conectCliente = conexao.Conect();
            SqlConnection ConectaCliente = conexao.Conect();
            sqlQuery = "INSERT INTO VEICULO(ANO,MODELO,PLACA,FABRICANTE,COR) VALUES(@ano,@modelo,@placa,@fabricante,@cor);";
            Sqlquery1 = "SELECT * FROM VEICULO WHERE PLACA = @placa;";
            try
            {
                SqlDataReader result = null;
                conectCliente.Open();
                SqlCommand cmd1 = new SqlCommand(Sqlquery1, conectCliente);
                cmd1.Parameters.Add(new SqlParameter("@placa", Placa1));
                result = cmd1.ExecuteReader();
                string nome, placa;
                if (result.Read())
                {
                    nome = Convert.ToString(result["MODELO"]);
                    placa = Convert.ToString(result["PLACA"]);
                    notific.ForeColor = Color.Red;
                    notific.Text = " O Veiculo de placa " + placa + " Já está cadastrado Como " + Convert.ToString(result["FABRICANTE"]) + " " + nome + "!\nClick em consultar para editar.";
                }
                else
                {

                    try
                    {
                        ConectaCliente.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, ConectaCliente);

                        cmd.Parameters.Add(new SqlParameter("@ano", Ano1));
                        cmd.Parameters.Add(new SqlParameter("@modelo", Modelo1));
                        cmd.Parameters.Add(new SqlParameter("@cor", Cor1));
                        cmd.Parameters.Add(new SqlParameter("@fabricante", Fabricante1));
                        cmd.Parameters.Add(new SqlParameter("@placa", Placa1));
                        
                        cmd.ExecuteNonQuery();
                        notific.ForeColor = Color.Green;
                        notific.Text = "cliente cadastrado com sucesso!";
                        limparControles();
                    }
                    catch (Exception ex)
                    {
                        notific.Text = "Erro de consulta:\n" + ex;
                    }

                }
            }
            catch (Exception ex)
            {
                notific.Text = "Erro " + ex;
            }
            finally
            {
                if (conectCliente != null)
                {
                    conectCliente.Close();
                }
                if (ConectaCliente != null)
                {
                    ConectaCliente.Close();
                }
            }
            
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            desabilitar();
            string Ano1, Fabricante1, Modelo1, Cor1, Placa1;
            Ano1 = Convert.ToString(Ano.Text);
            Fabricante1 = Convert.ToString(Fabricante.Text);
            Modelo1 = Convert.ToString(Modelo.Text);
            Cor1 = Convert.ToString(Cor.Text);
            Placa1 = Convert.ToString(Placa.Text);
           
            notific.ForeColor = Color.Green;
            notific.Text = " Inserindo dados .... ";

            if (validaDados() == false)
            {
                return;
            }
            string sqlQuery;
            SqlConnection conectCliente = conexao.Conect();
            sqlQuery = "UPDATE VEICULO SET FABRICANTE = @fabricante,MODELO = @modelo,ANO = @ano,COR = @cor WHERE PLACA = @placa;";
            try
            {
                conectCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conectCliente);

                cmd.Parameters.Add(new SqlParameter("@ano", Ano1));
                cmd.Parameters.Add(new SqlParameter("@modelo", Modelo1));
                cmd.Parameters.Add(new SqlParameter("@cor", Cor1));
                cmd.Parameters.Add(new SqlParameter("@fabricante", Fabricante1));
                cmd.Parameters.Add(new SqlParameter("@placa", Placa1));
                cmd.ExecuteNonQuery();
                notific.ForeColor = Color.Green;
                notific.Text = "Veiculo " + Modelo1 + " editado com exito!";

            }
            catch
            {
                notific.Text = "Erro ao Editar Veiculo, Para mudar a placa click em consultar.";
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            desabilitar();
            if (string.IsNullOrEmpty(Placa.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Consulte o veiculo que deseja excluir clicando no botão consultar";
                return;
            }

            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Placa1;
                Placa1 = Convert.ToString(Placa.Text);
                notific.ForeColor = Color.Green;
                notific.Text = "Excluindo ...";

                if (validaDados() == false)
                {
                    return;
                }
                string sqlQuery;
                SqlConnection conectCliente = conexao.Conect();
                sqlQuery = "DELETE FROM VEICULO  WHERE PLACA = @placa;";
                try
                {
                    conectCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conectCliente);
                    cmd.Parameters.Add(new SqlParameter("@placa", Placa1));
                    cmd.ExecuteNonQuery();
                    notific.ForeColor = Color.Green;
                    notific.Text = "Veiculo excluido con exito!";

                }
                catch
                {
                    notific.Text = "Erro ao Excluir Veiculo!";
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

        private void Consultar_Click(object sender, EventArgs e)
        {
            SqlConnection conectCliente = conexao.Conect();
            string sqlQuery1;
            sqlQuery1 = "SELECT PLACA,FABRICANTE,MODELO,ANO,COR FROM VEICULO ORDER BY MODELO;";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery1, conectCliente);
            DataTable dt = new DataTable();
            try
            {
                dta.Fill(dt);
                DGVVER.DataSource = dt;

                DGVVER.RowsDefaultCellStyle.BackColor = Color.White;
                DGVVER.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                DGVVER.Columns[0].HeaderCell.Value = " PLACA "; 
                DGVVER.Columns[1].HeaderCell.Value = " FABRICANTE ";
                DGVVER.Columns[2].HeaderCell.Value = " MODELO ";
                DGVVER.Columns[3].HeaderCell.Value = " ANO ";
                DGVVER.Columns[4].HeaderCell.Value = " COR ";

                notific.ForeColor = Color.Red;
                notific.Text = "Veicuos cadastrados no banco de dados!";
            }

            catch
            {
                notific.Text = "Erro ao consultar Veiculos!";
            }
            finally
            {
                habilitar();
            }

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Selecionar_Click(object sender, EventArgs e)
        {
            string PlacaCar;
            PlacaCar = DGVVER.CurrentRow.Cells[0].Value.ToString();

            string sqlQuery;

            SqlConnection conClienteConsulta = conexao.Conect();

            SqlDataReader dtr = null;

            sqlQuery = "SELECT PLACA, ANO, MODELO, COR, FABRICANTE  FROM VEICULO WHERE PLACA = @placa";

            try
            {
                conClienteConsulta.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conClienteConsulta);

                cmd.Parameters.Add(new SqlParameter("@placa", PlacaCar));

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    Placa.Text = Convert.ToString(dtr["PLACA"]);
                    Ano.Text = Convert.ToString(dtr["ANO"]);
                    Modelo.Text = Convert.ToString(dtr["MODELO"]);
                    Cor.Text = Convert.ToString(dtr["COR"]);
                    Fabricante.Text = Convert.ToString(dtr["FABRICANTE"]);
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
        }
    }
}
