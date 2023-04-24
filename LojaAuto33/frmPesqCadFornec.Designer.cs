namespace LojaAuto33
{
    partial class frmPesqCadFornec
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblRepres = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIDPess = new System.Windows.Forms.Button();
            this.btnPesqPess = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cadastrodeFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornendereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornfoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forncepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornRepresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastrodeFornecedoresTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.cadastrodeFornecedoresTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(67, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            // 
            // lblRepres
            // 
            this.lblRepres.AutoSize = true;
            this.lblRepres.Location = new System.Drawing.Point(55, 42);
            this.lblRepres.Name = "lblRepres";
            this.lblRepres.Size = new System.Drawing.Size(77, 13);
            this.lblRepres.TabIndex = 16;
            this.lblRepres.Text = "Representante";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(270, 407);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(138, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 30);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIDPess
            // 
            this.btnIDPess.Location = new System.Drawing.Point(378, 72);
            this.btnIDPess.Name = "btnIDPess";
            this.btnIDPess.Size = new System.Drawing.Size(122, 31);
            this.btnIDPess.TabIndex = 3;
            this.btnIDPess.Text = "CÓDIGO ID";
            this.btnIDPess.UseVisualStyleBackColor = true;
            // 
            // btnPesqPess
            // 
            this.btnPesqPess.Location = new System.Drawing.Point(378, 30);
            this.btnPesqPess.Name = "btnPesqPess";
            this.btnPesqPess.Size = new System.Drawing.Size(122, 29);
            this.btnPesqPess.TabIndex = 2;
            this.btnPesqPess.Text = "PESQUISA PESSOA";
            this.btnPesqPess.UseVisualStyleBackColor = true;
            this.btnPesqPess.Click += new System.EventHandler(this.btnPesqPess_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrodeFornecedoresBindingSource, "forn_Repres", true));
            this.textBox1.Location = new System.Drawing.Point(138, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornidDataGridViewTextBoxColumn,
            this.fornCNPJDataGridViewTextBoxColumn,
            this.fornendereçoDataGridViewTextBoxColumn,
            this.fornfoneDataGridViewTextBoxColumn,
            this.fornemailDataGridViewTextBoxColumn,
            this.forncepDataGridViewTextBoxColumn,
            this.fornRepresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastrodeFornecedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 203);
            this.dataGridView1.TabIndex = 4;
            // 
            // fornidDataGridViewTextBoxColumn
            // 
            this.fornidDataGridViewTextBoxColumn.DataPropertyName = "forn_id";
            this.fornidDataGridViewTextBoxColumn.HeaderText = "Código";
            this.fornidDataGridViewTextBoxColumn.Name = "fornidDataGridViewTextBoxColumn";
            this.fornidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornCNPJDataGridViewTextBoxColumn
            // 
            this.fornCNPJDataGridViewTextBoxColumn.DataPropertyName = "forn_CNPJ";
            this.fornCNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.fornCNPJDataGridViewTextBoxColumn.Name = "fornCNPJDataGridViewTextBoxColumn";
            // 
            // fornendereçoDataGridViewTextBoxColumn
            // 
            this.fornendereçoDataGridViewTextBoxColumn.DataPropertyName = "forn_endereço";
            this.fornendereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.fornendereçoDataGridViewTextBoxColumn.Name = "fornendereçoDataGridViewTextBoxColumn";
            // 
            // fornfoneDataGridViewTextBoxColumn
            // 
            this.fornfoneDataGridViewTextBoxColumn.DataPropertyName = "forn_fone";
            this.fornfoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.fornfoneDataGridViewTextBoxColumn.Name = "fornfoneDataGridViewTextBoxColumn";
            // 
            // fornemailDataGridViewTextBoxColumn
            // 
            this.fornemailDataGridViewTextBoxColumn.DataPropertyName = "forn_email";
            this.fornemailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.fornemailDataGridViewTextBoxColumn.Name = "fornemailDataGridViewTextBoxColumn";
            // 
            // forncepDataGridViewTextBoxColumn
            // 
            this.forncepDataGridViewTextBoxColumn.DataPropertyName = "forn_cep";
            this.forncepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.forncepDataGridViewTextBoxColumn.Name = "forncepDataGridViewTextBoxColumn";
            // 
            // fornRepresDataGridViewTextBoxColumn
            // 
            this.fornRepresDataGridViewTextBoxColumn.DataPropertyName = "forn_Repres";
            this.fornRepresDataGridViewTextBoxColumn.HeaderText = "Marca Representante";
            this.fornRepresDataGridViewTextBoxColumn.Name = "fornRepresDataGridViewTextBoxColumn";
            // 
            // cadastrodeFornecedoresTableAdapter
            // 
            this.cadastrodeFornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPesqCadFornec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRepres);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIDPess);
            this.Controls.Add(this.btnPesqPess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesqCadFornec";
            this.Text = "PESQUISA CADASTRO FORNECEDOR";
            this.Load += new System.EventHandler(this.frmPescCadFornec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRepres;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIDPess;
        private System.Windows.Forms.Button btnPesqPess;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource cadastrodeFornecedoresBindingSource;
        private Autopeca33DataSetTableAdapters.cadastrodeFornecedoresTableAdapter cadastrodeFornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornendereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornfoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forncepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornRepresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}