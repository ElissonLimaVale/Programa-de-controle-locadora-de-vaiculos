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
    public partial class locacao : Form
    {
        string id_cliente;
        string placa,nome_cliente,modelo,fabricante;
        public locacao()
        {
            InitializeComponent();
        }
        private bool Verifica()
        {
            if(string.IsNullOrEmpty(Cliente.Text)) 
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Campo Cliente exige preenchimento obrigatório!";
                return false;
            }
            if(string.IsNullOrEmpty(Veiculo.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Campo Veiculo Exige preenchimento obrigatório!";
                return false;
            }
            else
            {
                return true;
            }
        }
        private void habilitar()
        {
            selecionar.Enabled = true;
        }
        private void desabilitar()
        {
            selecionar.Enabled = false;
        }
        private void Locacao_Load(object sender, EventArgs e)
        {
            desabilitar();
            Excluir.Enabled = false;
            Cliente.Enabled = false;
            Veiculo.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            notific.Text = "";
        }

        private void SCliente_Click(object sender, EventArgs e)
        {
            habilitar();
            Excluir.Enabled = false;
            Cliente.Text = "Selecione o cliente";
            string sqlQuery;

            SqlConnection conectCliente = conexao.Conect();

            sqlQuery = "SELECT * FROM CLIENTE ORDER BY nome";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conectCliente);
            DataTable dt = new DataTable();

            try
            {
                dta.Fill(dt);

                DGVLOCACAO.DataSource = dt;

                DGVLOCACAO.RowsDefaultCellStyle.BackColor = Color.White;
                DGVLOCACAO.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                DGVLOCACAO.Columns[0].HeaderCell.Value = "Código do Cliente";
                DGVLOCACAO.Columns[1].HeaderCell.Value = " Nome ";
                DGVLOCACAO.Columns[2].HeaderCell.Value = " CPF ";
                DGVLOCACAO.Columns[3].HeaderCell.Value = "data Nasc";
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

        private void Consultar_Click(object sender, EventArgs e)
        {
            desabilitar();
            Excluir.Enabled = true;
            string sqlQuery;

            SqlConnection conectCliente = conexao.Conect();

            sqlQuery = "SELECT * FROM LOCACAO ORDER BY NR_LOCACAO";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conectCliente);
            DataTable dt = new DataTable();
            try
            {
                dta.Fill(dt);

                DGVLOCACAO.DataSource = dt;

                DGVLOCACAO.RowsDefaultCellStyle.BackColor = Color.White;
                DGVLOCACAO.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                DGVLOCACAO.Columns[0].HeaderCell.Value = " Numero da Locação ";
                DGVLOCACAO.Columns[1].HeaderCell.Value = " ID do Cliente ";
                DGVLOCACAO.Columns[2].HeaderCell.Value = " Placa do Veiculo ";
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

        private void Excluir_Click(object sender, EventArgs e)
        {
            string sqlquery,NR_LOCACAO,placa;
            placa = DGVLOCACAO.CurrentRow.Cells[2].Value.ToString();
            NR_LOCACAO = DGVLOCACAO.CurrentRow.Cells[0].Value.ToString();
            SqlConnection conect = conexao.Conect();
            sqlquery = "DELETE FROM LOCACAO WHERE NR_LOCACAO = @nr_locacao;";
            SqlCommand cmd = new SqlCommand(sqlquery, conect);

            try
            {
                conect.Open();
                cmd.Parameters.Add(new SqlParameter("@nr_locacao", NR_LOCACAO));
                cmd.ExecuteNonQuery();
                notific.ForeColor = Color.Green;
                notific.Text = "Locação do Veiculo de Placa '" + placa + "' Excluida com exito.";
                string sqlQuery;

                SqlConnection conectCliente = conexao.Conect();

                sqlQuery = "SELECT * FROM LOCACAO ORDER BY NR_LOCACAO";
                SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conectCliente);
                DataTable dt = new DataTable();
                try
                {
                    dta.Fill(dt);

                    DGVLOCACAO.DataSource = dt;

                    DGVLOCACAO.RowsDefaultCellStyle.BackColor = Color.White;
                    DGVLOCACAO.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                    DGVLOCACAO.Columns[0].HeaderCell.Value = " Numero da Locação ";
                    DGVLOCACAO.Columns[1].HeaderCell.Value = " ID do Cliente ";
                    DGVLOCACAO.Columns[2].HeaderCell.Value = " Placa do Veiculo ";
                    notific.ForeColor = Color.Green;
                    notific.Text = "Todas as Locações.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao listar clientes " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Erro " + ex;
            }
            finally
            {
                if (conect != null)
                {
                    conect.Close();
                }
            }
        }
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Cliente_Click(object sender, EventArgs e)
        {
            Form form = new CadastrarCliente();
            
            form.Show();
            this.Close();
        }

        private void Cadastrar_Veiculo_Click(object sender, EventArgs e)
        {
            Form form = new CadastrarVeiculo();
            form.Show();
            this.Close();
        }

        private void SVeiculo_Click(object sender, EventArgs e)
        {
            habilitar();
            Excluir.Enabled = false;
            Veiculo.Text = "Slecione o Veiculo";
            string sqlQuery;

            SqlConnection conectCliente = conexao.Conect();

            sqlQuery = "SELECT * FROM VEICULO ORDER BY MODELO";
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conectCliente);
            DataTable dt = new DataTable();

            try
            {
                dta.Fill(dt);

                DGVLOCACAO.DataSource = dt;

                DGVLOCACAO.RowsDefaultCellStyle.BackColor = Color.White;
                DGVLOCACAO.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                DGVLOCACAO.Columns[0].HeaderCell.Value = " PLACA ";
                DGVLOCACAO.Columns[1].HeaderCell.Value = " FABRICANTE ";
                DGVLOCACAO.Columns[2].HeaderCell.Value = " MODELO ";
                DGVLOCACAO.Columns[3].HeaderCell.Value = " ANO ";
                DGVLOCACAO.Columns[4].HeaderCell.Value = " COR ";
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
            if (Cliente.Text == "Selecione o cliente")
            {
               id_cliente = DGVLOCACAO.CurrentRow.Cells[0].Value.ToString();
               nome_cliente = DGVLOCACAO.CurrentRow.Cells[1].Value.ToString();
                Cliente.Text = nome_cliente + " ID: " + id_cliente ;
            }
            else
            {
                placa = DGVLOCACAO.CurrentRow.Cells[0].Value.ToString();
                modelo = DGVLOCACAO.CurrentRow.Cells[2].Value.ToString();
                fabricante = DGVLOCACAO.CurrentRow.Cells[1].Value.ToString();
                Veiculo.Text = fabricante + " " + modelo + " Placa: " + placa;
            }
        }
        private void NLocacao_Click(object sender, EventArgs e)
        {
            if (Verifica() == false)
            {
                return;
            }
            Excluir.Enabled = false;
            string sqlquery,Consulta;
            SqlConnection conect = conexao.Conect();
            SqlConnection conectVeiculo = conexao.Conect();
            sqlquery = "INSERT INTO LOCACAO(ID_CLIENTE,PLACA) VALUES(@id_cliente,@placa);";
            Consulta = "SELECT * FROM LOCACAO WHERE PLACA = @placa;";
            SqlDataReader result = null;
            SqlCommand cmd = new SqlCommand(sqlquery, conect);
            try
            {
                conectVeiculo.Open();
                SqlCommand cmd1 = new SqlCommand(Consulta, conectVeiculo);
                cmd1.Parameters.Add(new SqlParameter("@placa", placa));
                result = cmd1.ExecuteReader();
                if (result.Read())
                {
                    notific.ForeColor = Color.Red;
                    notific.Text = " O Veiculo de placa " + placa + " Já está Alugado.";
                }
                else
                {
                    try
                    {
                        conect.Open();
                        cmd.Parameters.Add(new SqlParameter("@placa", placa));
                        cmd.Parameters.Add(new SqlParameter("id_cliente", id_cliente));
                        cmd.ExecuteNonQuery();
                        notific.ForeColor = Color.Green;
                        notific.Text = "Veiculo alugado  para " + nome_cliente + " com sucesso.";
                    }
                    catch (Exception ex)
                    {
                        notific.ForeColor = Color.Red;
                        notific.Text = "Erro " + ex;
                    }
                }
            }
            catch (Exception ex)
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Erro " + ex;
            }
            finally
            {
                if (conect != null)
                {
                    conect.Close();
                }
                if (conectVeiculo != null)
                {
                    conectVeiculo.Close();
                }
            }
        }
    }

}
