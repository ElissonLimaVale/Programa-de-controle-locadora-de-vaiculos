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
    public partial class Devolucao : Form
    {
        string CpfCliente,NomeCliente,IdCliente,ModeloCarro,PlacaCarro,AnoCarro,NumeroLocacao, FabricanteCarro;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Devolucao()
        {
            InitializeComponent();
        }
        private void desabilitar()
        {
            nrlocacao.Enabled = false;
            pveiculo.Enabled = false;
            mveiculo.Enabled = false;
            fveiculo.Enabled = false;
            aveiculo.Enabled = false;
            ncliente.Enabled = false;
            cpf.Enabled = false;
            id_cliente.Enabled = false;
        }
        private void LimpaControles()
        {
            PlacaVeiculo.Text = "";
            nrlocacao.Text = "";
            pveiculo.Text = "";
            mveiculo.Text = "";
            fveiculo.Text = "";
            aveiculo.Text = "";
            ncliente.Text = "";
            cpf.Text = "";
            id_cliente.Text = "";
        }
        private void Devolver_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Após a devolução, os dados da Locação são permanentemente excluidos do sistema," +
                "permanecem apenas os dados do Cliente e Veiculo. Deseja Concluir a Devolução? ", "Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlquery;
                sqlquery = "DELETE FROM LOCACAO WHERE PLACA = @placa;";
                SqlConnection conect = conexao.Conect();
                SqlCommand  devolver= new SqlCommand(sqlquery, conect);
                devolver.Parameters.Add(new SqlParameter("@placa", PlacaCarro));
                try
                {
                    conect.Open();
                    devolver.ExecuteNonQuery();
                    notific.ForeColor = Color.Green;
                    notific.Text = "Veiculo entregue, Locação excluida.\nO veiculo ja está disponivel para uma nova locação!";
                    LimpaControles();
                }
                catch (Exception ex)
                {
                    notific.ForeColor = Color.Red;
                    notific.Text = "Ocorreu um erro " + ex;
                }
                
            }
            else
            {
                notific.ForeColor = Color.Green;
                notific.Text = "Nada feito";
                return;
            }
        
        }

        private void Devolucao_Load(object sender, EventArgs e)
        {
            desabilitar();
            ConsultaLocacao.Enabled = false;
            notific.Text = "";
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void PlacaVeiculo_TextChanged(object sender, EventArgs e)
        {
            ConsultaLocacao.Enabled = true;
        }

        private void ConsultaLocacao_Click(object sender, EventArgs e)
        {

           
            if (PlacaVeiculo.Text == "")
            {
                notific.Text = "É nesseçario saber a placa do Veiculo Alugado\nPara Consulta-lo.";
            }
            else
            {
                string sqlquery, placa;
                placa = Convert.ToString(PlacaVeiculo.Text);
                sqlquery = "SELECT * FROM LOCACAO WHERE PLACA = @placa;";
                SqlConnection conect = conexao.Conect();
                SqlConnection conect01 = conexao.Conect();
                SqlConnection conect02 = conexao.Conect();

                try
                {
                     conect.Open();
                    SqlCommand locacao = new SqlCommand(sqlquery, conect);
                    locacao.Parameters.Add(new SqlParameter("@placa", placa));
                    SqlDataReader consult = null;
                    SqlDataReader consult01 = null;
                    SqlDataReader consult02 = null;

                    consult = locacao.ExecuteReader();
                    if (consult.Read())
                    {
                        IdCliente = consult["ID_CLIENTE"].ToString();
                        PlacaCarro = consult["PLACA"].ToString();
                        NumeroLocacao = consult["NR_LOCACAO"].ToString();
                        notific.Text = "Locação encontrada no banco de dados.\n";
                        sqlquery = "SELECT * FROM CLIENTE WHERE ID_CLIENTE = @id_clinete;";
                        SqlCommand Cliente = new SqlCommand(sqlquery, conect01);
                        try
                        {
                            conect01.Open();
                            Cliente.Parameters.Add(new SqlParameter("@id_clinete", IdCliente));
                            consult01 = Cliente.ExecuteReader();
                            if (consult01.Read())
                            {
                                NomeCliente = consult01["NOME"].ToString();
                                CpfCliente = consult01["CPF"].ToString();
                                sqlquery = "SELECT * FROM VEICULO WHERE PLACA = @placa;";
                                try
                                {
                                    conect02.Open();
                                    SqlCommand Veiculo = new SqlCommand(sqlquery, conect02);
                                    Veiculo.Parameters.Add(new SqlParameter("@placa", PlacaCarro));
                                    consult02 = Veiculo.ExecuteReader();
                                    if (consult02.Read())
                                    {
                                        AnoCarro = consult02["ANO"].ToString();
                                        ModeloCarro = consult02["MODELO"].ToString();
                                        FabricanteCarro = consult02["FABRICANTE"].ToString();
                                      
                                        nrlocacao.Text = NumeroLocacao;
                                        pveiculo.Text = PlacaCarro;
                                        mveiculo.Text = ModeloCarro;
                                        fveiculo.Text = FabricanteCarro;
                                        aveiculo.Text = AnoCarro;
                                        ncliente.Text = NomeCliente;
                                        cpf.Text = CpfCliente;
                                        id_cliente.Text = IdCliente;
                                    }
                                    else
                                    {
                                        notific.Text += "Ocorreou Um erro!";
                                    }
                                }
                                catch(Exception ex)
                                {
                                    notific.ForeColor = Color.Red;
                                    notific.Text = "Erro \n" + ex;
                                }
                            }
                            else
                            {
                                notific.Text += "Ocorreu Um erro, Verifique se a Placa está correta.";
                            }
                        }
                        catch(Exception ex)
                        {
                            notific.ForeColor = Color.Red;
                            notific.Text = "Erro \n" + ex;
                        }

                    }
                    else
                    {
                        notific.Text += "Ocorreu Um erro, Verifique se a Placa está correta.";
                    }
                }

                catch (Exception ex)
                {
                    notific.ForeColor = Color.Red;
                    notific.Text = "Erro \n" + ex;
                }
                finally
                {
                    if (conect != null)
                    {
                        conect.Close();
                    }
                    if (conect01 != null)
                    {
                        conect01.Close();
                    }
                    if (conect02 != null)
                    {
                        conect02.Close();
                    }
                }
               
            }
        }

       
    }
}
