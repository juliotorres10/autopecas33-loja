namespace LojaAuto33
{
    partial class frmCadForn
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
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cadastrodeFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cadastrodeFornecedoresTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.cadastrodeFornecedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(18, 44);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(18, 79);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Endereço";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(17, 117);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(31, 13);
            this.lblFone.TabIndex = 4;
            this.lblFone.Text = "Fone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Location = new System.Drawing.Point(17, 185);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(108, 13);
            this.lblRepresentante.TabIndex = 6;
            this.lblRepresentante.Text = "Nome Representante";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(12, 404);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(118, 34);
            this.btnCad.TabIndex = 7;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(136, 406);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(120, 32);
            this.btnPesq.TabIndex = 9;
            this.btnPesq.Text = "PESQUISAR";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(262, 406);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(118, 33);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(386, 407);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(124, 32);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(516, 407);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 34);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_CNPJ", true));
            this.textBox2.Location = new System.Drawing.Point(132, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 1;
            // 
            // cadastrodeFornecedoresBindingSource
            // 
            this.cadastrodeFornecedoresBindingSource.DataMember = "cadastrodeFornecedores";
            this.cadastrodeFornecedoresBindingSource.DataSource = this.autopeca33DataSet;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_endereço", true));
            this.textBox4.Location = new System.Drawing.Point(132, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_fone", true));
            this.textBox5.Location = new System.Drawing.Point(132, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_email", true));
            this.textBox6.Location = new System.Drawing.Point(133, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_Repres", true));
            this.textBox7.Location = new System.Drawing.Point(133, 182);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CEP";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_cep", true));
            this.textBox8.Location = new System.Drawing.Point(133, 214);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 20);
            this.textBox8.TabIndex = 14;
            // 
            // cadastrodeFornecedoresTableAdapter
            // 
            this.cadastrodeFornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lblRepresentante);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblCNPJ);
            this.Name = "frmCadForn";
            this.Text = "CADASTRO DE FORNECEDORES";
            this.Load += new System.EventHandler(this.frmCadForn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource cadastrodeFornecedoresBindingSource;
        private Autopeca33DataSetTableAdapters.cadastrodeFornecedoresTableAdapter cadastrodeFornecedoresTableAdapter;
        //   private Autopeca33DataSet autopeca33DataSet;
        //  private Autopeca33DataSetTableAdapters.cadastrodeFornecedoresTableAdapter cadastrodeFornecedoresTableAdapter;
    }
}