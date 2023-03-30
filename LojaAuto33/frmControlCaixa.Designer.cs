namespace LojaAuto33
{
    partial class frmControlCaixa
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
            this.lblFormPgto = new System.Windows.Forms.Label();
            this.controlCaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.lblAdicionar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.controlCaixaTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.controlCaixaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autopeca33DataSet1 = new LojaAuto33.Autopeca33DataSet();
            this.autopeca33DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadProdutosTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.CadProdutosTableAdapter();
            this.cadProdCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProddescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdvalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.BTNvOLTAR = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.controlCaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormPgto
            // 
            this.lblFormPgto.AutoSize = true;
            this.lblFormPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormPgto.Location = new System.Drawing.Point(525, 322);
            this.lblFormPgto.Name = "lblFormPgto";
            this.lblFormPgto.Size = new System.Drawing.Size(193, 24);
            this.lblFormPgto.TabIndex = 4;
            this.lblFormPgto.Text = "Forma de Pagamento";
            this.lblFormPgto.Click += new System.EventHandler(this.lblFormPgto_Click);
            // 
            // controlCaixaBindingSource
            // 
            this.controlCaixaBindingSource.DataMember = "controlCaixa";
            this.controlCaixaBindingSource.DataSource = this.autopeca33DataSet;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.Location = new System.Drawing.Point(12, 415);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(88, 23);
            this.lblAdicionar.TabIndex = 5;
            this.lblAdicionar.Text = "ADICIONAR";
            this.lblAdicionar.UseVisualStyleBackColor = true;
            this.lblAdicionar.Click += new System.EventHandler(this.lblCadastrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlCaixaBindingSource, "controlCaixa_formaPgmo", true));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "à vista",
            "cartão de debito",
            "cartão de credito"});
            this.comboBox1.Location = new System.Drawing.Point(529, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // controlCaixaTableAdapter
            // 
            this.controlCaixaTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(470, 314);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(529, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 218);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Oleo";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(529, 255);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 50);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Valor total: 1500";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(218, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 29);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código do produto";
            // 
            // autopeca33DataSet1
            // 
            this.autopeca33DataSet1.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autopeca33DataSet1BindingSource
            // 
            this.autopeca33DataSet1BindingSource.DataSource = this.autopeca33DataSet1;
            this.autopeca33DataSet1BindingSource.Position = 0;
            // 
            // cadProdutosBindingSource
            // 
            this.cadProdutosBindingSource.DataMember = "CadProdutos";
            this.cadProdutosBindingSource.DataSource = this.autopeca33DataSet1BindingSource;
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
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(106, 415);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(88, 23);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // BTNvOLTAR
            // 
            this.BTNvOLTAR.Location = new System.Drawing.Point(200, 415);
            this.BTNvOLTAR.Name = "BTNvOLTAR";
            this.BTNvOLTAR.Size = new System.Drawing.Size(88, 23);
            this.BTNvOLTAR.TabIndex = 16;
            this.BTNvOLTAR.Text = "VOLTAR";
            this.BTNvOLTAR.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(294, 415);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 23);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // frmControlCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.BTNvOLTAR);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAdicionar);
            this.Controls.Add(this.lblFormPgto);
            this.Name = "frmControlCaixa";
            this.Text = "CONTROLE DE CAIXA";
            this.Load += new System.EventHandler(this.frmControlCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlCaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFormPgto;
        private System.Windows.Forms.Button lblAdicionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource controlCaixaBindingSource;
        private Autopeca33DataSetTableAdapters.controlCaixaTableAdapter controlCaixaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource autopeca33DataSet1BindingSource;
        private Autopeca33DataSet autopeca33DataSet1;
        private System.Windows.Forms.BindingSource cadProdutosBindingSource;
        private Autopeca33DataSetTableAdapters.CadProdutosTableAdapter cadProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProddescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdvalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button BTNvOLTAR;
        private System.Windows.Forms.Button btnFechar;
    }
}