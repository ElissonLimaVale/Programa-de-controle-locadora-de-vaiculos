namespace Projeto_Rental_Car
{
    partial class Verificacao
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
            this.DGV_LOCACAO = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.notific = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LOCACAO)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_LOCACAO
            // 
            this.DGV_LOCACAO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LOCACAO.Location = new System.Drawing.Point(23, 62);
            this.DGV_LOCACAO.Name = "DGV_LOCACAO";
            this.DGV_LOCACAO.Size = new System.Drawing.Size(547, 313);
            this.DGV_LOCACAO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Locações do Dia:";
            // 
            // notific
            // 
            this.notific.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notific.Location = new System.Drawing.Point(24, 557);
            this.notific.Name = "notific";
            this.notific.Size = new System.Drawing.Size(1322, 97);
            this.notific.TabIndex = 4;
            this.notific.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notificações do Sistema";
            // 
            // Verificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notific);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_LOCACAO);
            this.Name = "Verificacao";
            this.Text = "verificações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Verificacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LOCACAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_LOCACAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox notific;
        private System.Windows.Forms.Label label2;
    }
}