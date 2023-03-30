namespace LojaAuto33
{
    partial class frmPesqCadCompra
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
            this.button1 = new System.Windows.Forms.Button();
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.pedidosdecomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosdecomprasTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.pedidosdecomprasTableAdapter();
            this.pedCompraCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedCompraCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedCompradescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedCompraqtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedCompradataDeEntrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedCompradataDeSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedCompradataDevolucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosdecomprasBindingSource)).BeginInit();
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
            this.btnVoltar.Location = new System.Drawing.Point(251, 395);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(119, 396);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 30);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIDPess
            // 
            this.btnIDPess.Location = new System.Drawing.Point(337, 99);
            this.btnIDPess.Name = "btnIDPess";
            this.btnIDPess.Size = new System.Drawing.Size(122, 31);
            this.btnIDPess.TabIndex = 3;
            this.btnIDPess.Text = "CÓDIGO ID";
            this.btnIDPess.UseVisualStyleBackColor = true;
            // 
            // btnPesqPess
            // 
            this.btnPesqPess.Location = new System.Drawing.Point(337, 55);
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
            this.pedCompraCDDataGridViewTextBoxColumn,
            this.fornidDataGridViewTextBoxColumn,
            this.cadProdCDDataGridViewTextBoxColumn,
            this.pedCompraCNPJDataGridViewTextBoxColumn,
            this.pedCompradescDataGridViewTextBoxColumn,
            this.pedCompraqtdDataGridViewTextBoxColumn,
            this.pedCompradataDeEntrDataGridViewTextBoxColumn,
            this.pedCompradataDeSaidaDataGridViewTextBoxColumn,
            this.pedCompradataDevolucaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidosdecomprasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(119, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 188);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = true;
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
            // pedCompraCDDataGridViewTextBoxColumn
            // 
            this.pedCompraCDDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_CD";
            this.pedCompraCDDataGridViewTextBoxColumn.HeaderText = "pedCompra_CD";
            this.pedCompraCDDataGridViewTextBoxColumn.Name = "pedCompraCDDataGridViewTextBoxColumn";
            this.pedCompraCDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // pedCompraCNPJDataGridViewTextBoxColumn
            // 
            this.pedCompraCNPJDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_CNPJ";
            this.pedCompraCNPJDataGridViewTextBoxColumn.HeaderText = "pedCompra_CNPJ";
            this.pedCompraCNPJDataGridViewTextBoxColumn.Name = "pedCompraCNPJDataGridViewTextBoxColumn";
            // 
            // pedCompradescDataGridViewTextBoxColumn
            // 
            this.pedCompradescDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_desc";
            this.pedCompradescDataGridViewTextBoxColumn.HeaderText = "pedCompra_desc";
            this.pedCompradescDataGridViewTextBoxColumn.Name = "pedCompradescDataGridViewTextBoxColumn";
            // 
            // pedCompraqtdDataGridViewTextBoxColumn
            // 
            this.pedCompraqtdDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_qtd";
            this.pedCompraqtdDataGridViewTextBoxColumn.HeaderText = "pedCompra_qtd";
            this.pedCompraqtdDataGridViewTextBoxColumn.Name = "pedCompraqtdDataGridViewTextBoxColumn";
            // 
            // pedCompradataDeEntrDataGridViewTextBoxColumn
            // 
            this.pedCompradataDeEntrDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_dataDeEntr";
            this.pedCompradataDeEntrDataGridViewTextBoxColumn.HeaderText = "pedCompra_dataDeEntr";
            this.pedCompradataDeEntrDataGridViewTextBoxColumn.Name = "pedCompradataDeEntrDataGridViewTextBoxColumn";
            // 
            // pedCompradataDeSaidaDataGridViewTextBoxColumn
            // 
            this.pedCompradataDeSaidaDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_dataDeSaida";
            this.pedCompradataDeSaidaDataGridViewTextBoxColumn.HeaderText = "pedCompra_dataDeSaida";
            this.pedCompradataDeSaidaDataGridViewTextBoxColumn.Name = "pedCompradataDeSaidaDataGridViewTextBoxColumn";
            // 
            // pedCompradataDevolucaoDataGridViewTextBoxColumn
            // 
            this.pedCompradataDevolucaoDataGridViewTextBoxColumn.DataPropertyName = "pedCompra_dataDevolucao";
            this.pedCompradataDevolucaoDataGridViewTextBoxColumn.HeaderText = "pedCompra_dataDevolucao";
            this.pedCompradataDevolucaoDataGridViewTextBoxColumn.Name = "pedCompradataDevolucaoDataGridViewTextBoxColumn";
            // 
            // frmPesqCadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIDPess);
            this.Controls.Add(this.btnPesqPess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesqCadCompra";
            this.Text = "PESQUISA CADASTRO DE COMPRA";
            this.Load += new System.EventHandler(this.frmPesqCadCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosdecomprasBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource pedidosdecomprasBindingSource;
        private Autopeca33DataSetTableAdapters.pedidosdecomprasTableAdapter pedidosdecomprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompraCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompraCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompradescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompraqtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompradataDeEntrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompradataDeSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedCompradataDevolucaoDataGridViewTextBoxColumn;
    }
}