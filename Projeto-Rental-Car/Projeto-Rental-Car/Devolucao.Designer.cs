namespace Projeto_Rental_Car
{
    partial class Devolucao
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
            this.ConsultaLocacao = new System.Windows.Forms.Button();
            this.Devolver = new System.Windows.Forms.Button();
            this.PlacaVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notific = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpf = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.TextBox();
            this.ncliente = new System.Windows.Forms.TextBox();
            this.aveiculo = new System.Windows.Forms.TextBox();
            this.pveiculo = new System.Windows.Forms.TextBox();
            this.mveiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nrlocacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fveiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultaLocacao
            // 
            this.ConsultaLocacao.Location = new System.Drawing.Point(53, 298);
            this.ConsultaLocacao.Name = "ConsultaLocacao";
            this.ConsultaLocacao.Size = new System.Drawing.Size(129, 34);
            this.ConsultaLocacao.TabIndex = 0;
            this.ConsultaLocacao.Text = "Consultar Locação\r\n";
            this.ConsultaLocacao.UseVisualStyleBackColor = true;
            this.ConsultaLocacao.Click += new System.EventHandler(this.ConsultaLocacao_Click);
            // 
            // Devolver
            // 
            this.Devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devolver.ForeColor = System.Drawing.Color.Green;
            this.Devolver.Location = new System.Drawing.Point(48, 483);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(194, 49);
            this.Devolver.TabIndex = 4;
            this.Devolver.Text = "Concluir Devolução";
            this.Devolver.UseVisualStyleBackColor = true;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // PlacaVeiculo
            // 
            this.PlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaVeiculo.Location = new System.Drawing.Point(178, 46);
            this.PlacaVeiculo.Name = "PlacaVeiculo";
            this.PlacaVeiculo.Size = new System.Drawing.Size(159, 22);
            this.PlacaVeiculo.TabIndex = 9;
            this.PlacaVeiculo.TextChanged += new System.EventHandler(this.PlacaVeiculo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Placa Veiculo:";
            // 
            // notific
            // 
            this.notific.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notific.Location = new System.Drawing.Point(48, 373);
            this.notific.Name = "notific";
            this.notific.Size = new System.Drawing.Size(1130, 92);
            this.notific.TabIndex = 12;
            this.notific.Text = "notificações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Notificaçoes do Sistema:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.fveiculo);
            this.groupBox1.Controls.Add(this.cpf);
            this.groupBox1.Controls.Add(this.id_cliente);
            this.groupBox1.Controls.Add(this.ncliente);
            this.groupBox1.Controls.Add(this.aveiculo);
            this.groupBox1.Controls.Add(this.pveiculo);
            this.groupBox1.Controls.Add(this.mveiculo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(48, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 180);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Locação";
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(865, 121);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(159, 22);
            this.cpf.TabIndex = 15;
            // 
            // id_cliente
            // 
            this.id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.Location = new System.Drawing.Point(490, 121);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(159, 22);
            this.id_cliente.TabIndex = 16;
            // 
            // ncliente
            // 
            this.ncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncliente.Location = new System.Drawing.Point(26, 121);
            this.ncliente.Name = "ncliente";
            this.ncliente.Size = new System.Drawing.Size(310, 22);
            this.ncliente.TabIndex = 17;
            // 
            // aveiculo
            // 
            this.aveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aveiculo.Location = new System.Drawing.Point(915, 47);
            this.aveiculo.Name = "aveiculo";
            this.aveiculo.Size = new System.Drawing.Size(159, 22);
            this.aveiculo.TabIndex = 18;
            // 
            // pveiculo
            // 
            this.pveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pveiculo.Location = new System.Drawing.Point(620, 47);
            this.pveiculo.Name = "pveiculo";
            this.pveiculo.Size = new System.Drawing.Size(159, 22);
            this.pveiculo.TabIndex = 19;
            // 
            // mveiculo
            // 
            this.mveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mveiculo.Location = new System.Drawing.Point(323, 47);
            this.mveiculo.Name = "mveiculo";
            this.mveiculo.Size = new System.Drawing.Size(159, 22);
            this.mveiculo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(888, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "CPF do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome do Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(936, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ano do Veiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modelo do Veiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID do Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(639, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Placa Veiculo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(909, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Numero da Locação:";
            // 
            // nrlocacao
            // 
            this.nrlocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrlocacao.Location = new System.Drawing.Point(1067, 46);
            this.nrlocacao.Name = "nrlocacao";
            this.nrlocacao.Size = new System.Drawing.Size(94, 22);
            this.nrlocacao.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1067, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fveiculo
            // 
            this.fveiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fveiculo.Location = new System.Drawing.Point(26, 47);
            this.fveiculo.Name = "fveiculo";
            this.fveiculo.Size = new System.Drawing.Size(159, 22);
            this.fveiculo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fabricante do Veiculo";
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nrlocacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notific);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlacaVeiculo);
            this.Controls.Add(this.Devolver);
            this.Controls.Add(this.ConsultaLocacao);
            this.Name = "Devolucao";
            this.Text = "Devolucao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Devolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsultaLocacao;
        private System.Windows.Forms.Button Devolver;
        private System.Windows.Forms.TextBox PlacaVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox notific;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.TextBox id_cliente;
        private System.Windows.Forms.TextBox ncliente;
        private System.Windows.Forms.TextBox aveiculo;
        private System.Windows.Forms.TextBox pveiculo;
        private System.Windows.Forms.TextBox mveiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nrlocacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fveiculo;
    }
}