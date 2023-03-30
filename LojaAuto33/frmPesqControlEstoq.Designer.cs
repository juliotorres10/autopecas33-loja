namespace LojaAuto33
{
    partial class frmPesqControlEstoq
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
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIDPess = new System.Windows.Forms.Button();
            this.btnPesqPess = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.controlEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlEstoqueTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.controlEstoqueTableAdapter();
            this.controlEstCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstdescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstdataEntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstdataSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstqtdEntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstqtdSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlEstvalorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 106);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(48, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(251, 408);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(119, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 30);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIDPess
            // 
            this.btnIDPess.Location = new System.Drawing.Point(359, 88);
            this.btnIDPess.Name = "btnIDPess";
            this.btnIDPess.Size = new System.Drawing.Size(122, 31);
            this.btnIDPess.TabIndex = 3;
            this.btnIDPess.Text = "CÓDIGO ID";
            this.btnIDPess.UseVisualStyleBackColor = true;
            // 
            // btnPesqPess
            // 
            this.btnPesqPess.Location = new System.Drawing.Point(359, 46);
            this.btnPesqPess.Name = "btnPesqPess";
            this.btnPesqPess.Size = new System.Drawing.Size(122, 29);
            this.btnPesqPess.TabIndex = 2;
            this.btnPesqPess.Text = "PESQUISA PESSOA";
            this.btnPesqPess.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.controlEstCDDataGridViewTextBoxColumn,
            this.fornidDataGridViewTextBoxColumn,
            this.cadProdCDDataGridViewTextBoxColumn,
            this.controlEstCNPJDataGridViewTextBoxColumn,
            this.controlEstdescrDataGridViewTextBoxColumn,
            this.controlEstdataEntDataGridViewTextBoxColumn,
            this.controlEstdataSaidaDataGridViewTextBoxColumn,
            this.controlEstqtdEntDataGridViewTextBoxColumn,
            this.controlEstqtdSaidaDataGridViewTextBoxColumn,
            this.controlEstvalorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.controlEstoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(119, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 188);
            this.dataGridView1.TabIndex = 4;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlEstoqueBindingSource
            // 
            this.controlEstoqueBindingSource.DataMember = "controlEstoque";
            this.controlEstoqueBindingSource.DataSource = this.autopeca33DataSet;
            // 
            // controlEstoqueTableAdapter
            // 
            this.controlEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // controlEstCDDataGridViewTextBoxColumn
            // 
            this.controlEstCDDataGridViewTextBoxColumn.DataPropertyName = "controlEst_CD";
            this.controlEstCDDataGridViewTextBoxColumn.HeaderText = "controlEst_CD";
            this.controlEstCDDataGridViewTextBoxColumn.Name = "controlEstCDDataGridViewTextBoxColumn";
            this.controlEstCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornidDataGridViewTextBoxColumn
            // 
            this.fornidDataGridViewTextBoxColumn.DataPropertyName = "forn_id";
            this.fornidDataGridViewTextBoxColumn.HeaderText = "forn_id";
            this.fornidDataGridViewTextBoxColumn.Name = "fornidDataGridViewTextBoxColumn";
            // 
            // cadProdCDDataGridViewTextBoxColumn
            // 
            this.cadProdCDDataGridViewTextBoxColumn.DataPropertyName = "cadProd_CD";
            this.cadProdCDDataGridViewTextBoxColumn.HeaderText = "cadProd_CD";
            this.cadProdCDDataGridViewTextBoxColumn.Name = "cadProdCDDataGridViewTextBoxColumn";
            // 
            // controlEstCNPJDataGridViewTextBoxColumn
            // 
            this.controlEstCNPJDataGridViewTextBoxColumn.DataPropertyName = "controlEst_CNPJ";
            this.controlEstCNPJDataGridViewTextBoxColumn.HeaderText = "controlEst_CNPJ";
            this.controlEstCNPJDataGridViewTextBoxColumn.Name = "controlEstCNPJDataGridViewTextBoxColumn";
            // 
            // controlEstdescrDataGridViewTextBoxColumn
            // 
            this.controlEstdescrDataGridViewTextBoxColumn.DataPropertyName = "controlEst_descr";
            this.controlEstdescrDataGridViewTextBoxColumn.HeaderText = "controlEst_descr";
            this.controlEstdescrDataGridViewTextBoxColumn.Name = "controlEstdescrDataGridViewTextBoxColumn";
            // 
            // controlEstdataEntDataGridViewTextBoxColumn
            // 
            this.controlEstdataEntDataGridViewTextBoxColumn.DataPropertyName = "controlEst_dataEnt";
            this.controlEstdataEntDataGridViewTextBoxColumn.HeaderText = "controlEst_dataEnt";
            this.controlEstdataEntDataGridViewTextBoxColumn.Name = "controlEstdataEntDataGridViewTextBoxColumn";
            // 
            // controlEstdataSaidaDataGridViewTextBoxColumn
            // 
            this.controlEstdataSaidaDataGridViewTextBoxColumn.DataPropertyName = "controlEst_dataSaida";
            this.controlEstdataSaidaDataGridViewTextBoxColumn.HeaderText = "controlEst_dataSaida";
            this.controlEstdataSaidaDataGridViewTextBoxColumn.Name = "controlEstdataSaidaDataGridViewTextBoxColumn";
            // 
            // controlEstqtdEntDataGridViewTextBoxColumn
            // 
            this.controlEstqtdEntDataGridViewTextBoxColumn.DataPropertyName = "controlEst_qtdEnt";
            this.controlEstqtdEntDataGridViewTextBoxColumn.HeaderText = "controlEst_qtdEnt";
            this.controlEstqtdEntDataGridViewTextBoxColumn.Name = "controlEstqtdEntDataGridViewTextBoxColumn";
            // 
            // controlEstqtdSaidaDataGridViewTextBoxColumn
            // 
            this.controlEstqtdSaidaDataGridViewTextBoxColumn.DataPropertyName = "controlEst_qtdSaida";
            this.controlEstqtdSaidaDataGridViewTextBoxColumn.HeaderText = "controlEst_qtdSaida";
            this.controlEstqtdSaidaDataGridViewTextBoxColumn.Name = "controlEstqtdSaidaDataGridViewTextBoxColumn";
            // 
            // controlEstvalorDataGridViewTextBoxColumn
            // 
            this.controlEstvalorDataGridViewTextBoxColumn.DataPropertyName = "controlEst_valor";
            this.controlEstvalorDataGridViewTextBoxColumn.HeaderText = "controlEst_valor";
            this.controlEstvalorDataGridViewTextBoxColumn.Name = "controlEstvalorDataGridViewTextBoxColumn";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(383, 408);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(134, 30);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // frmPesqControlEstoq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIDPess);
            this.Controls.Add(this.btnPesqPess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesqControlEstoq";
            this.Text = "PESQUISA CONTROLE DE ESTOQUE";
            this.Load += new System.EventHandler(this.frmPesqControlEstoq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIDPess;
        private System.Windows.Forms.Button btnPesqPess;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource controlEstoqueBindingSource;
        private Autopeca33DataSetTableAdapters.controlEstoqueTableAdapter controlEstoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstdescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstdataEntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstdataSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstqtdEntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstqtdSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlEstvalorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeletar;
    }
}