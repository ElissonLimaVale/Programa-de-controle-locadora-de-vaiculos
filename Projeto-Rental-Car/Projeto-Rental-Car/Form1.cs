using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Rental_Car
{
    public partial class PainelCentral : Form
    {
        public PainelCentral()
        {
            InitializeComponent();
        }
private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new CadastrarCliente();

            form.MdiParent = this;
            
            form.Show();
        }

        private void VeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new CadastrarVeiculo();

            form.MdiParent = this;
            
            form.Show();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new locacao();
            form.MdiParent = this;
            form.Show();
        }

        private void DevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Devolucao();
            form.MdiParent = this;
            form.Show();
        }

        private void VerificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Verificacao();
            form.MdiParent = this;
            form.Show();
        }

        private void PainelCentral_Load(object sender, EventArgs e)
        {
            Form form = new Verificacao();
            form.MdiParent = this;
            form.Show();
        }
    }
}
