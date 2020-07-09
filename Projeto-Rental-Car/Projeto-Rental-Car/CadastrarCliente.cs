using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adicionado calss da função de banco de dados
using System.Data.SqlClient;

namespace Projeto_Rental_Car
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }
        CadastrarCliente frmCliente;
        public CadastrarCliente(CadastrarCliente frmCliente)
        {
            this.frmCliente = frmCliente;
        }
        private void habilitar()
        {
            codigo.Enabled = false;
            nome.Enabled = true;
            cpf.Enabled = true;
            data_nasc.Enabled = true;
        }
        private void desabilitar()
        {
            codigo.Enabled = false;
            nome.Enabled = false;
            cpf.Enabled = false;
            data_nasc.Enabled = false;
        }
        private void limparControles()
        {
            codigo.Enabled = false;

            nome.Clear();
            codigo.Clear();
            cpf.Clear();
            data_nasc.Clear();
            cpf.Focus();
        }
        private bool validaDados()
        {
            if (string.IsNullOrEmpty(cpf.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                cpf.Focus();
                return false;
            }
            DateTime auxData;
            if (!(DateTime.TryParse(data_nasc.Text, out auxData)))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                data_nasc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nome.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Preenchimento de campo obrigatório";
                nome.Focus();
                return false;
            }
            notific.Text = "";
            return true;
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            habilitar();
            notific.ForeColor = Color.Green;
            notific.Text = "";
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }
        private string MudaData(string data)
        {
            string data0, dia, mes, ano;
            mes = data.Substring(0, 2);
            dia = data.Substring(3, 2);
            ano = data.Substring(6);
            data0 = dia + "/" + mes + "/" + ano;
            return data0;
        }
        private void Incluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codigo.Text))
            {
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limparControles();
                    return; 
                }
                else
                {
                    return;
                }
            }

            string CPF1, NOME1, DATA1, DataBR;
            DataBR = Convert.ToString(data_nasc.Text);
            DATA1 = MudaData(DataBR);
            CPF1 = Convert.ToString(cpf.Text);
            NOME1 = Convert.ToString(nome.Text);

            notific.ForeColor = Color.Green;
            notific.Text = "Inserindo dados ....";

            if (validaDados() == false)
            {
                return;
            }
            string sqlQuery, Consulta;
            SqlConnection conectCliente = conexao.Conect();
            SqlConnection ConectaCliente = conexao.Conect();
            Consulta = "SELECT * FROM CLIENTE WHERE CPF = @cpf;";
            sqlQuery = "INSERT INTO CLIENTE(NOME,DATA_NASC,CPF) VALUES(@nome,@data_nasc,@cpf);";
            
            try
            {
                SqlDataReader result = null;
                conectCliente.Open();
                SqlCommand cmd1 = new SqlCommand(Consulta, conectCliente);
                cmd1.Parameters.Add(new SqlParameter("@cpf", CPF1));
                result = cmd1.ExecuteReader();
                string nome, cpff;
                if (result.Read())
                {
                    nome = Convert.ToString(result["NOME"]);
                    cpff = Convert.ToString(result["CPF"]);
                    notific.ForeColor = Color.Red;
                    notific.Text = " O CPF " + cpff + " Já está cadastrado no Cliente " + nome + "!\nClick em consultar para editar.";
                }
                else
                {
                    try
                    {
                        ConectaCliente.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, ConectaCliente);
                        cmd.Parameters.Add(new SqlParameter("@cpf", CPF1));
                        cmd.Parameters.Add(new SqlParameter("@data_nasc", DATA1));
                        cmd.Parameters.Add(new SqlParameter("@nome", NOME1));
                        
                        cmd.ExecuteNonQuery();
                        notific.ForeColor = Color.Green;
                        notific.Text = "cliente cadastrado com sucesso!";
                       
                        limparControles();
                    }
                    catch (Exception ex)
                    {
                        notific.ForeColor = Color.Red;
                        notific.Text = "***!!!Ocorreu um problema ao tentar inserir cliente!!!****\n"+ ex;
                        conectCliente.Close();
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Erro ao inserir " + ex + "!";
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
            string CPF1, NOME1, DATA1, DataBR, CODIGO;
            DataBR = Convert.ToString(data_nasc.Text);
            DATA1 = MudaData(DataBR);
            CPF1 = Convert.ToString(cpf.Text);
            NOME1 = Convert.ToString(nome.Text);
            CODIGO = Convert.ToString(codigo.Text);

            if (string.IsNullOrEmpty(codigo.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Consulte o cliente que deseja alterar clicando no botão consultar.";
                return;  
            }

            if (validaDados() == false)
            {
                return;
            }
            string sqlQuery;
            SqlConnection conectCliente = conexao.Conect();
            sqlQuery = "UPDATE CLIENTE SET NOME = @nome,DATA_NASC = @data_nasc, CPF=@cpf WHERE ID_CLIENTE = @id_cliente";
            
            try
            {
                conectCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conectCliente);
                
                cmd.Parameters.Add(new SqlParameter("@nome", NOME1));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", DATA1));
                cmd.Parameters.Add(new SqlParameter("@cpf", CPF1));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", CODIGO));
                cmd.ExecuteNonQuery();
                notific.ForeColor = Color.Green;
                notific.Text = "Cliente alterado com sucesso";

                limparControles();
            }
            catch (Exception)
            {
                notific.ForeColor = Color.Red;
                notific.Text = "**** Ocorreu um Problema ao alterar cliente ****";
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
            if (string.IsNullOrEmpty(codigo.Text))
            {
                notific.ForeColor = Color.Red;
                notific.Text = "Consulte o cliente que deseja excluir clicando no botão consultar";
                return;
            }

            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string CODIGO;
                CODIGO = Convert.ToString(codigo.Text);
                string sqlQuery;
                SqlConnection conectCliente = conexao.Conect();
                sqlQuery = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @id_cliente";
                
                try
                {
                    conectCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conectCliente);
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", CODIGO));

                    cmd.ExecuteNonQuery();
                    notific.ForeColor = Color.Green;
                    notific.Text = "Cliente excluído com sucesso!";
                    
                    limparControles();
                }
                catch (Exception)
                {
                    notific.ForeColor = Color.Red;
                    notific.Text = "**** Ocorreu um problema ao tentar excluir cliente!";
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
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Form frm = new Consultar(this);
            
            frm.MdiParent = this.MdiParent;
            
            frm.Show();
        }

    }
}