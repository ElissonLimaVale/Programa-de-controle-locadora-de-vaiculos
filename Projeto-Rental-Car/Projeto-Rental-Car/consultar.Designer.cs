namespace Projeto_Rental_Car
{
    partial class Consultar
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
            this.DGVCliente = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCliente
            // 
            this.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCliente.Location = new System.Drawing.Point(12, 12);
            this.DGVCliente.Name = "DGVCliente";
            this.DGVCliente.Size = new System.Drawing.Size(1042, 393);
            this.DGVCliente.TabIndex = 0;
            // 
            // selecionar
            // 
            this.selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionar.Location = new System.Drawing.Point(221, 421);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(117, 44);
            this.selecionar.TabIndex = 1;
            this.selecionar.Text = "selecionar";
            this.selecionar.UseVisualStyleBackColor = true;
            this.selecionar.Click += new System.EventHandler(this.Selecionar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(733, 421);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(107, 44);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 477);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.selecionar);
            this.Controls.Add(this.DGVCliente);
            this.Name = "Consultar";
            this.Text = "consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCliente;
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.Button cancelar;
    }
}