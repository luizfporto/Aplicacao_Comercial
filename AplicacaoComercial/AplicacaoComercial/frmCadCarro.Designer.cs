
namespace AplicacaoComercial
{
    partial class frmCadCarro
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPortas = new System.Windows.Forms.Label();
            this.txtPortas = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.btnFiltrarMarca = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(59, 47);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(169, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 67);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(59, 64);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(169, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(13, 90);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(59, 83);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(84, 20);
            this.txtAno.TabIndex = 5;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(16, 107);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 13);
            this.lblCor.TabIndex = 6;
            this.lblCor.Text = "Cor:";
            // 
            // cboCor
            // 
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Location = new System.Drawing.Point(59, 104);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(121, 21);
            this.cboCor.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(185, 126);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 34);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(16, 129);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(40, 13);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Portas:";
            // 
            // txtPortas
            // 
            this.txtPortas.Location = new System.Drawing.Point(59, 126);
            this.txtPortas.Name = "txtPortas";
            this.txtPortas.Size = new System.Drawing.Size(84, 20);
            this.txtPortas.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(59, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 12;
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(-4, 166);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(606, 184);
            this.dgvCarros.TabIndex = 13;
            this.dgvCarros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(291, 126);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 33);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Location = new System.Drawing.Point(494, 127);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(108, 33);
            this.btnPreencher.TabIndex = 15;
            this.btnPreencher.Text = "Preencher";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // btnFiltrarMarca
            // 
            this.btnFiltrarMarca.Location = new System.Drawing.Point(235, 47);
            this.btnFiltrarMarca.Name = "btnFiltrarMarca";
            this.btnFiltrarMarca.Size = new System.Drawing.Size(32, 23);
            this.btnFiltrarMarca.TabIndex = 16;
            this.btnFiltrarMarca.Text = "...";
            this.btnFiltrarMarca.UseVisualStyleBackColor = true;
            this.btnFiltrarMarca.Click += new System.EventHandler(this.btnFiltrarMarca_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(402, 126);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 33);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCadCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 353);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFiltrarMarca);
            this.Controls.Add(this.btnPreencher);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPortas);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carro";
            this.Load += new System.EventHandler(this.frmCadCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cboCor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.TextBox txtPortas;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.Button btnFiltrarMarca;
        private System.Windows.Forms.Button btnExcluir;
    }
}

