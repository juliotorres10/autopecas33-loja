namespace LojaAuto33
{
    partial class frmTrocaProd
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
            this.components = new System.ComponentModel.Container();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.lblDataTroca = new System.Windows.Forms.Label();
            this.btnDevolocao = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trocaProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.trocaProdTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.trocaProdTableAdapter();
            this.lblQtd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trocaProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(27, 76);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(95, 13);
            this.lblCodProd.TabIndex = 1;
            this.lblCodProd.Text = "Código do Produto";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Location = new System.Drawing.Point(27, 128);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(69, 13);
            this.lblDataVenda.TabIndex = 2;
            this.lblDataVenda.Text = "Código Caixa";
            // 
            // lblDataTroca
            // 
            this.lblDataTroca.AutoSize = true;
            this.lblDataTroca.Location = new System.Drawing.Point(27, 169);
            this.lblDataTroca.Name = "lblDataTroca";
            this.lblDataTroca.Size = new System.Drawing.Size(76, 13);
            this.lblDataTroca.TabIndex = 3;
            this.lblDataTroca.Text = "Data da Troca";
            // 
            // btnDevolocao
            // 
            this.btnDevolocao.Location = new System.Drawing.Point(10, 411);
            this.btnDevolocao.Name = "btnDevolocao";
            this.btnDevolocao.Size = new System.Drawing.Size(127, 27);
            this.btnDevolocao.TabIndex = 4;
            this.btnDevolocao.Text = "CONFIRMAR TROCA";
            this.btnDevolocao.UseVisualStyleBackColor = true;
            this.btnDevolocao.Click += new System.EventHandler(this.btnDevolocao_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(258, 411);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 28);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(599, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 28);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(143, 411);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(109, 28);
            this.btnPesq.TabIndex = 5;
            this.btnPesq.Text = "PESQUISAR";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trocaProdBindingSource, "cadProd_CD", true));
            this.textBox2.Location = new System.Drawing.Point(165, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 1;
            // 
            // trocaProdBindingSource
            // 
            this.trocaProdBindingSource.DataMember = "trocaProd";
            this.trocaProdBindingSource.DataSource = this.autopeca33DataSet;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trocaProdBindingSource, "controlCaixa_CD", true));
            this.textBox3.Location = new System.Drawing.Point(165, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trocaProdBindingSource, "trocaProd_dataTroca", true));
            this.textBox4.Location = new System.Drawing.Point(165, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(374, 411);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 28);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(488, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 28);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // trocaProdTableAdapter
            // 
            this.trocaProdTableAdapter.ClearBeforeFill = true;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(27, 220);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 10;
            this.lblQtd.Text = "Quantidade ";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trocaProdBindingSource, "trocaProd_Quantidade", true));
            this.textBox1.Location = new System.Drawing.Point(164, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 11;
            // 
            // frmTrocaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDevolocao);
            this.Controls.Add(this.lblDataTroca);
            this.Controls.Add(this.lblDataVenda);
            this.Controls.Add(this.lblCodProd);
            this.Name = "frmTrocaProd";
            this.Text = "TROCA DE PRODUTO";
            this.Load += new System.EventHandler(this.frmTrocaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trocaProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.Label lblDataTroca;
        private System.Windows.Forms.Button btnDevolocao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource trocaProdBindingSource;
        private Autopeca33DataSetTableAdapters.trocaProdTableAdapter trocaProdTableAdapter;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox textBox1;
    }
}