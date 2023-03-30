namespace LojaAuto33
{
    partial class frmPesqProd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPesqProd = new System.Windows.Forms.Button();
            this.btnIDProd = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.autopeca33DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadProdutosTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.CadProdutosTableAdapter();
            this.cadProdCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProddescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdvalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cadProdCDDataGridViewTextBoxColumn,
            this.cadProddescDataGridViewTextBoxColumn,
            this.cadProdmarcaDataGridViewTextBoxColumn,
            this.cadProdvalVendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadProdutosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(102, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 161);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(70, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(72, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnPesqProd
            // 
            this.btnPesqProd.Location = new System.Drawing.Point(404, 29);
            this.btnPesqProd.Name = "btnPesqProd";
            this.btnPesqProd.Size = new System.Drawing.Size(152, 24);
            this.btnPesqProd.TabIndex = 2;
            this.btnPesqProd.Text = "PESQUISAR PRODUTO";
            this.btnPesqProd.UseVisualStyleBackColor = true;
            // 
            // btnIDProd
            // 
            this.btnIDProd.Location = new System.Drawing.Point(404, 75);
            this.btnIDProd.Name = "btnIDProd";
            this.btnIDProd.Size = new System.Drawing.Size(151, 23);
            this.btnIDProd.TabIndex = 3;
            this.btnIDProd.Text = "CÓDIGO ID";
            this.btnIDProd.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(102, 398);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(116, 32);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(224, 397);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 32);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(345, 397);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(119, 33);
            this.btndeletar.TabIndex = 7;
            this.btndeletar.Text = "DELETAR";
            this.btndeletar.UseVisualStyleBackColor = true;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autopeca33DataSetBindingSource
            // 
            this.autopeca33DataSetBindingSource.DataSource = this.autopeca33DataSet;
            this.autopeca33DataSetBindingSource.Position = 0;
            // 
            // cadProdutosBindingSource
            // 
            this.cadProdutosBindingSource.DataMember = "CadProdutos";
            this.cadProdutosBindingSource.DataSource = this.autopeca33DataSetBindingSource;
            // 
            // cadProdutosTableAdapter
            // 
            this.cadProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // cadProdCDDataGridViewTextBoxColumn
            // 
            this.cadProdCDDataGridViewTextBoxColumn.DataPropertyName = "cadProd_CD";
            this.cadProdCDDataGridViewTextBoxColumn.HeaderText = "cadProd_CD";
            this.cadProdCDDataGridViewTextBoxColumn.Name = "cadProdCDDataGridViewTextBoxColumn";
            this.cadProdCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadProddescDataGridViewTextBoxColumn
            // 
            this.cadProddescDataGridViewTextBoxColumn.DataPropertyName = "cadProd_desc";
            this.cadProddescDataGridViewTextBoxColumn.HeaderText = "cadProd_desc";
            this.cadProddescDataGridViewTextBoxColumn.Name = "cadProddescDataGridViewTextBoxColumn";
            // 
            // cadProdmarcaDataGridViewTextBoxColumn
            // 
            this.cadProdmarcaDataGridViewTextBoxColumn.DataPropertyName = "cadProd_marca";
            this.cadProdmarcaDataGridViewTextBoxColumn.HeaderText = "cadProd_marca";
            this.cadProdmarcaDataGridViewTextBoxColumn.Name = "cadProdmarcaDataGridViewTextBoxColumn";
            // 
            // cadProdvalVendaDataGridViewTextBoxColumn
            // 
            this.cadProdvalVendaDataGridViewTextBoxColumn.DataPropertyName = "cadProd_valVenda";
            this.cadProdvalVendaDataGridViewTextBoxColumn.HeaderText = "cadProd_valVenda";
            this.cadProdvalVendaDataGridViewTextBoxColumn.Name = "cadProdvalVendaDataGridViewTextBoxColumn";
            // 
            // frmPesqProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIDProd);
            this.Controls.Add(this.btnPesqProd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesqProd";
            this.Text = "PESQUISA DE PRODUTO";
            this.Load += new System.EventHandler(this.frmPesqProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPesqProd;
        private System.Windows.Forms.Button btnIDProd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.BindingSource autopeca33DataSetBindingSource;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.BindingSource cadProdutosBindingSource;
        private Autopeca33DataSetTableAdapters.CadProdutosTableAdapter cadProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProddescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdvalVendaDataGridViewTextBoxColumn;
    }
}