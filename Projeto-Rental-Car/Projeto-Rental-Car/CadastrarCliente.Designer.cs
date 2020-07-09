namespace Projeto_Rental_Car
{
    partial class CadastrarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.consultar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.incluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.notific = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.data_nasc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // Fechar
            // 
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.Location = new System.Drawing.Point(908, 401);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(111, 42);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(163, 65);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(141, 20);
            this.codigo.TabIndex = 2;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(590, 411);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(112, 32);
            this.consultar.TabIndex = 3;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(445, 411);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(98, 32);
            this.excluir.TabIndex = 4;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(302, 411);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(94, 32);
            this.alterar.TabIndex = 5;
            this.alterar.Text = "alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // incluir
            // 
            this.incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluir.Location = new System.Drawing.Point(49, 401);
            this.incluir.Name = "incluir";
            this.incluir.Size = new System.Drawing.Size(141, 42);
            this.incluir.TabIndex = 6;
            this.incluir.Text = "Incluir";
            this.incluir.UseVisualStyleBackColor = true;
            this.incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(359, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 8;
            this.label.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(156, 125);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(466, 20);
            this.nome.TabIndex = 10;
            // 
            // notific
            // 
            this.notific.AutoSize = true;
            this.notific.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notific.ForeColor = System.Drawing.Color.Red;
            this.notific.Location = new System.Drawing.Point(91, 189);
            this.notific.Name = "notific";
            this.notific.Size = new System.Drawing.Size(124, 24);
            this.notific.TabIndex = 13;
            this.notific.Text = "Notificações";
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(413, 64);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(181, 20);
            this.cpf.TabIndex = 14;
            // 
            // data_nasc
            // 
            this.data_nasc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.data_nasc.Location = new System.Drawing.Point(852, 67);
            this.data_nasc.Mask = "00/00/0000";
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.Size = new System.Drawing.Size(76, 20);
            this.data_nasc.TabIndex = 15;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 473);
            this.Controls.Add(this.data_nasc);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.notific);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.incluir);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "CadastrarCliente";
            this.Text = "CadastrarCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button incluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label notific;
        public System.Windows.Forms.TextBox codigo;
        public System.Windows.Forms.TextBox nome;
        public System.Windows.Forms.MaskedTextBox cpf;
        public System.Windows.Forms.MaskedTextBox data_nasc;
    }
}