namespace LojaAuto33
{
    partial class frmPedDeCompra
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
            this.lblRazSocial = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataEntradaProd = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPedComprar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.pedidosdecomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosdecomprasTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.pedidosdecomprasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosdecomprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRazSocial
            // 
            this.lblRazSocial.AutoSize = true;
            this.lblRazSocial.Location = new System.Drawing.Point(33, 42);
            this.lblRazSocial.Name = "lblRazSocial";
            this.lblRazSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazSocial.TabIndex = 1;
            this.lblRazSocial.Text = "Razão Social";
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(33, 91);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(80, 13);
            this.lblCodProd.TabIndex = 2;
            this.lblCodProd.Text = "Código Produto";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(29, 133);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(110, 13);
            this.lblDescProd.TabIndex = 3;
            this.lblDescProd.Text = "Descrição do Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(27, 179);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataEntradaProd
            // 
            this.lblDataEntradaProd.AutoSize = true;
            this.lblDataEntradaProd.Location = new System.Drawing.Point(27, 228);
            this.lblDataEntradaProd.Name = "lblDataEntradaProd";
            this.lblDataEntradaProd.Size = new System.Drawing.Size(125, 13);
            this.lblDataEntradaProd.TabIndex = 5;
            this.lblDataEntradaProd.Text = "Data de Entrada Produto";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(12, 399);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(127, 39);
            this.btnCad.TabIndex = 6;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(145, 399);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(139, 39);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPedComprar
            // 
            this.btnPedComprar.Location = new System.Drawing.Point(292, 399);
            this.btnPedComprar.Name = "btnPedComprar";
            this.btnPedComprar.Size = new System.Drawing.Size(141, 38);
            this.btnPedComprar.TabIndex = 8;
            this.btnPedComprar.Text = "PESQUISAR";
            this.btnPedComprar.UseVisualStyleBackColor = true;
            this.btnPedComprar.Click += new System.EventHandler(this.btnPedComprar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(442, 399);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(142, 38);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(600, 399);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 39);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_CNPJ", true));
            this.textBox2.Location = new System.Drawing.Point(170, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "cadProd_CD", true));
            this.textBox3.Location = new System.Drawing.Point(170, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_desc", true));
            this.textBox4.Location = new System.Drawing.Point(170, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_qtd", true));
            this.textBox5.Location = new System.Drawing.Point(170, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_dataDeEntr", true));
            this.textBox6.Location = new System.Drawing.Point(170, 221);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(175, 20);
            this.textBox6.TabIndex = 5;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosdecomprasBindingSource
            // 
            this.pedidosdecomprasBindingSource.DataMember = "pedidosdecompras";
            this.pedidosdecomprasBindingSource.DataSource = this.autopeca33DataSet;
            // 
            // pedidosdecomprasTableAdapter
            // 
            this.pedidosdecomprasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data de Saída Produto";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_dataDeSaida", true));
            this.textBox1.Location = new System.Drawing.Point(170, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data de Devolução Produto";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_dataDevolucao", true));
            this.textBox8.Location = new System.Drawing.Point(173, 311);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(171, 20);
            this.textBox8.TabIndex = 16;
            // 
            // frmPedDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPedComprar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lblDataEntradaProd);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblDescProd);
            this.Controls.Add(this.lblCodProd);
            this.Controls.Add(this.lblRazSocial);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidosdecomprasBindingSource, "pedCompra_CNPJ", true));
            this.Name = "frmPedDeCompra";
            this.Text = "PEDIDO DE COMPRA";
            this.Load += new System.EventHandler(this.frmPedDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosdecomprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRazSocial;
        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataEntradaProd;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPedComprar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource pedidosdecomprasBindingSource;
        private Autopeca33DataSetTableAdapters.pedidosdecomprasTableAdapter pedidosdecomprasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
    }
}