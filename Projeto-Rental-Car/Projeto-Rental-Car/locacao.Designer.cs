namespace Projeto_Rental_Car
{
    partial class locacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVLOCACAO = new System.Windows.Forms.DataGridView();
            this.Fechar = new System.Windows.Forms.Button();
            this.selecionar = new System.Windows.Forms.Button();
            this.NLocacao = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SCliente = new System.Windows.Forms.Button();
            this.SVeiculo = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.TextBox();
            this.Veiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notific = new System.Windows.Forms.Label();
            this.Cadastrar_Cliente = new System.Windows.Forms.Button();
            this.Cadastrar_Veiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLOCACAO)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLOCACAO
            // 
            this.DGVLOCACAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLOCACAO.Location = new System.Drawing.Point(29, 87);
            this.DGVLOCACAO.Name = "DGVLOCACAO";
            this.DGVLOCACAO.Size = new System.Drawing.Size(1192, 334);
            this.DGVLOCACAO.TabIndex = 0;
            // 
            // Fechar
            // 
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Fechar.Location = new System.Drawing.Point(1082, 496);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(139, 69);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // selecionar
            // 
            this.selecionar.Location = new System.Drawing.Point(29, 427);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(124, 29);
            this.selecionar.TabIndex = 2;
            this.selecionar.Text = "Selecionar";
            this.selecionar.UseVisualStyleBackColor = true;
            this.selecionar.Click += new System.EventHandler(this.Selecionar_Click);
            // 
            // NLocacao
            // 
            this.NLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLocacao.ForeColor = System.Drawing.Color.Green;
            this.NLocacao.Location = new System.Drawing.Point(29, 515);
            this.NLocacao.Name = "NLocacao";
            this.NLocacao.Size = new System.Drawing.Size(173, 50);
            this.NLocacao.TabIndex = 3;
            this.NLocacao.Text = "Concluir Locação";
            this.NLocacao.UseVisualStyleBackColor = true;
            this.NLocacao.Click += new System.EventHandler(this.NLocacao_Click);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(464, 536);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(106, 29);
            this.consultar.TabIndex = 4;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(297, 536);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(102, 29);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir\r\n";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // SCliente
            // 
            this.SCliente.Location = new System.Drawing.Point(29, 23);
            this.SCliente.Name = "SCliente";
            this.SCliente.Size = new System.Drawing.Size(124, 29);
            this.SCliente.TabIndex = 6;
            this.SCliente.Text = "Selecionar Cliente";
            this.SCliente.UseVisualStyleBackColor = true;
            this.SCliente.Click += new System.EventHandler(this.SCliente_Click);
            // 
            // SVeiculo
            // 
            this.SVeiculo.Location = new System.Drawing.Point(645, 23);
            this.SVeiculo.Name = "SVeiculo";
            this.SVeiculo.Size = new System.Drawing.Size(124, 29);
            this.SVeiculo.TabIndex = 7;
            this.SVeiculo.Text = "Selecionar Veiculo";
            this.SVeiculo.UseVisualStyleBackColor = true;
            this.SVeiculo.Click += new System.EventHandler(this.SVeiculo_Click);
            // 
            // Cliente
            // 
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(243, 43);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(361, 22);
            this.Cliente.TabIndex = 8;
            // 
            // Veiculo
            // 
            this.Veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veiculo.Location = new System.Drawing.Point(879, 43);
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.Size = new System.Drawing.Size(284, 22);
            this.Veiculo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Veiculo:";
            // 
            // notific
            // 
            this.notific.AutoSize = true;
            this.notific.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notific.ForeColor = System.Drawing.Color.Red;
            this.notific.Location = new System.Drawing.Point(220, 449);
            this.notific.Name = "notific";
            this.notific.Size = new System.Drawing.Size(99, 20);
            this.notific.TabIndex = 12;
            this.notific.Text = "Notificação";
            // 
            // Cadastrar_Cliente
            // 
            this.Cadastrar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar_Cliente.Location = new System.Drawing.Point(645, 515);
            this.Cadastrar_Cliente.Name = "Cadastrar_Cliente";
            this.Cadastrar_Cliente.Size = new System.Drawing.Size(135, 52);
            this.Cadastrar_Cliente.TabIndex = 13;
            this.Cadastrar_Cliente.Text = "Cadastrar Cliente";
            this.Cadastrar_Cliente.UseVisualStyleBackColor = true;
            this.Cadastrar_Cliente.Click += new System.EventHandler(this.Cadastrar_Cliente_Click);
            // 
            // Cadastrar_Veiculo
            // 
            this.Cadastrar_Veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar_Veiculo.Location = new System.Drawing.Point(807, 515);
            this.Cadastrar_Veiculo.Name = "Cadastrar_Veiculo";
            this.Cadastrar_Veiculo.Size = new System.Drawing.Size(125, 50);
            this.Cadastrar_Veiculo.TabIndex = 14;
            this.Cadastrar_Veiculo.Text = "Cadastrar Veiculo";
            this.Cadastrar_Veiculo.UseVisualStyleBackColor = true;
            this.Cadastrar_Veiculo.Click += new System.EventHandler(this.Cadastrar_Veiculo_Click);
            // 
            // locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 577);
            this.Controls.Add(this.Cadastrar_Veiculo);
            this.Controls.Add(this.Cadastrar_Cliente);
            this.Controls.Add(this.notific);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Veiculo);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.SVeiculo);
            this.Controls.Add(this.SCliente);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.NLocacao);
            this.Controls.Add(this.selecionar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.DGVLOCACAO);
            this.Name = "locacao";
            this.Text = "locacões";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Locacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLOCACAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLOCACAO;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.Button NLocacao;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button SCliente;
        private System.Windows.Forms.Button SVeiculo;
        private System.Windows.Forms.TextBox Cliente;
        private System.Windows.Forms.TextBox Veiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label notific;
        private System.Windows.Forms.Button Cadastrar_Cliente;
        private System.Windows.Forms.Button Cadastrar_Veiculo;
    }
}