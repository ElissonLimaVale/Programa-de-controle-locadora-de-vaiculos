namespace Projeto_Rental_Car
{
    partial class CadastrarVeiculo
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
            this.Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fabricante = new System.Windows.Forms.TextBox();
            this.Ano = new System.Windows.Forms.TextBox();
            this.Placa = new System.Windows.Forms.TextBox();
            this.Modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cor = new System.Windows.Forms.TextBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.notific = new System.Windows.Forms.Label();
            this.DGVVER = new System.Windows.Forms.DataGridView();
            this.Seleciona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVER)).BeginInit();
            this.SuspendLayout();
            // 
            // Fechar
            // 
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Location = new System.Drawing.Point(897, 455);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(121, 44);
            this.Fechar.TabIndex = 0;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            // 
            // Fabricante
            // 
            this.Fabricante.Location = new System.Drawing.Point(177, 41);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(123, 20);
            this.Fabricante.TabIndex = 2;
            // 
            // Ano
            // 
            this.Ano.Location = new System.Drawing.Point(177, 114);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(123, 20);
            this.Ano.TabIndex = 3;
            // 
            // Placa
            // 
            this.Placa.Location = new System.Drawing.Point(781, 48);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(100, 20);
            this.Placa.TabIndex = 4;
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(508, 45);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(127, 20);
            this.Modelo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fabricante:";
            // 
            // Cor
            // 
            this.Cor.Location = new System.Drawing.Point(508, 114);
            this.Cor.Name = "Cor";
            this.Cor.Size = new System.Drawing.Size(134, 20);
            this.Cor.TabIndex = 10;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(421, 470);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(91, 29);
            this.Excluir.TabIndex = 11;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(268, 470);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(88, 29);
            this.Alterar.TabIndex = 12;
            this.Alterar.Text = "alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Inserir
            // 
            this.Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserir.Location = new System.Drawing.Point(71, 455);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(122, 44);
            this.Inserir.TabIndex = 13;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(565, 470);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(93, 29);
            this.Consultar.TabIndex = 14;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // notific
            // 
            this.notific.AutoSize = true;
            this.notific.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notific.ForeColor = System.Drawing.Color.Black;
            this.notific.Location = new System.Drawing.Point(66, 387);
            this.notific.Name = "notific";
            this.notific.Size = new System.Drawing.Size(127, 24);
            this.notific.TabIndex = 15;
            this.notific.Text = "notificações:";
            // 
            // DGVVER
            // 
            this.DGVVER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVER.Location = new System.Drawing.Point(71, 167);
            this.DGVVER.Name = "DGVVER";
            this.DGVVER.Size = new System.Drawing.Size(923, 207);
            this.DGVVER.TabIndex = 16;
            // 
            // Seleciona
            // 
            this.Seleciona.Location = new System.Drawing.Point(907, 386);
            this.Seleciona.Name = "Seleciona";
            this.Seleciona.Size = new System.Drawing.Size(87, 31);
            this.Seleciona.TabIndex = 17;
            this.Seleciona.Text = "Selecionar";
            this.Seleciona.UseVisualStyleBackColor = true;
            this.Seleciona.Click += new System.EventHandler(this.Selecionar_Click);
            // 
            // CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 521);
            this.Controls.Add(this.Seleciona);
            this.Controls.Add(this.DGVVER);
            this.Controls.Add(this.notific);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Cor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fechar);
            this.Name = "CadastrarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarVeiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Label notific;
        private System.Windows.Forms.DataGridView DGVVER;
        private System.Windows.Forms.Button Seleciona;
        public System.Windows.Forms.TextBox Fabricante;
        public System.Windows.Forms.TextBox Ano;
        public System.Windows.Forms.TextBox Placa;
        public System.Windows.Forms.TextBox Modelo;
        public System.Windows.Forms.TextBox Cor;
    }
}