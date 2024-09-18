namespace ProjHeranca
{
    partial class FormHeranca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeranca));
            this.btnConta = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.btnPoupancaEspecial = new System.Windows.Forms.Button();
            this.btnGerente = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConstrutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(12, 26);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(192, 60);
            this.btnConta.TabIndex = 0;
            this.btnConta.Text = "Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.Location = new System.Drawing.Point(210, 26);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(192, 60);
            this.btnPoupanca.TabIndex = 1;
            this.btnPoupanca.Text = "Poupança";
            this.btnPoupanca.UseVisualStyleBackColor = true;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // btnPoupancaEspecial
            // 
            this.btnPoupancaEspecial.Location = new System.Drawing.Point(12, 92);
            this.btnPoupancaEspecial.Name = "btnPoupancaEspecial";
            this.btnPoupancaEspecial.Size = new System.Drawing.Size(390, 60);
            this.btnPoupancaEspecial.TabIndex = 2;
            this.btnPoupancaEspecial.Text = "Poupança Especial";
            this.btnPoupancaEspecial.UseVisualStyleBackColor = true;
            this.btnPoupancaEspecial.Click += new System.EventHandler(this.btnPoupancaEspecial_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerente.Location = new System.Drawing.Point(12, 205);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(192, 60);
            this.btnGerente.TabIndex = 3;
            this.btnGerente.Text = "Gerente";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // btnColaborador
            // 
            this.btnColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador.Location = new System.Drawing.Point(12, 285);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(215, 60);
            this.btnColaborador.TabIndex = 4;
            this.btnColaborador.Text = "Colaborador";
            this.btnColaborador.UseVisualStyleBackColor = true;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnConstrutor
            // 
            this.btnConstrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstrutor.Location = new System.Drawing.Point(12, 364);
            this.btnConstrutor.Name = "btnConstrutor";
            this.btnConstrutor.Size = new System.Drawing.Size(230, 90);
            this.btnConstrutor.TabIndex = 6;
            this.btnConstrutor.Text = "Colaborador\r\nContrutor";
            this.btnConstrutor.UseVisualStyleBackColor = true;
            this.btnConstrutor.Click += new System.EventHandler(this.btnConstrutor_Click);
            // 
            // FormHeranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(968, 507);
            this.Controls.Add(this.btnConstrutor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnColaborador);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnPoupancaEspecial);
            this.Controls.Add(this.btnPoupanca);
            this.Controls.Add(this.btnConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormHeranca";
            this.Text = "Herança";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Button btnPoupancaEspecial;
        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConstrutor;
    }
}

