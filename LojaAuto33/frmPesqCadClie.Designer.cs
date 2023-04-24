namespace LojaAuto33
{
    partial class frmPesqCadClie
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
            this.clieCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastrodeclientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPesqPess = new System.Windows.Forms.Button();
            this.btnIDClie = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodClie = new System.Windows.Forms.Label();
            this.cadastrodeclientesTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.cadastrodeclientesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeclientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clieCDDataGridViewTextBoxColumn,
            this.clieNMDataGridViewTextBoxColumn,
            this.clieCPFDataGridViewTextBoxColumn,
            this.clieRGDataGridViewTextBoxColumn,
            this.cliefoneDataGridViewTextBoxColumn,
            this.clieemailDataGridViewTextBoxColumn,
            this.clieendDataGridViewTextBoxColumn,
            this.clieCEPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastrodeclientesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 219);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clieCDDataGridViewTextBoxColumn
            // 
            this.clieCDDataGridViewTextBoxColumn.DataPropertyName = "clie_CD";
            this.clieCDDataGridViewTextBoxColumn.HeaderText = "clie_CD";
            this.clieCDDataGridViewTextBoxColumn.Name = "clieCDDataGridViewTextBoxColumn";
            this.clieCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clieNMDataGridViewTextBoxColumn
            // 
            this.clieNMDataGridViewTextBoxColumn.DataPropertyName = "clie_NM";
            this.clieNMDataGridViewTextBoxColumn.HeaderText = "clie_NM";
            this.clieNMDataGridViewTextBoxColumn.Name = "clieNMDataGridViewTextBoxColumn";
            // 
            // clieCPFDataGridViewTextBoxColumn
            // 
            this.clieCPFDataGridViewTextBoxColumn.DataPropertyName = "clie_CPF";
            this.clieCPFDataGridViewTextBoxColumn.HeaderText = "clie_CPF";
            this.clieCPFDataGridViewTextBoxColumn.Name = "clieCPFDataGridViewTextBoxColumn";
            // 
            // clieRGDataGridViewTextBoxColumn
            // 
            this.clieRGDataGridViewTextBoxColumn.DataPropertyName = "clie_RG";
            this.clieRGDataGridViewTextBoxColumn.HeaderText = "clie_RG";
            this.clieRGDataGridViewTextBoxColumn.Name = "clieRGDataGridViewTextBoxColumn";
            // 
            // cliefoneDataGridViewTextBoxColumn
            // 
            this.cliefoneDataGridViewTextBoxColumn.DataPropertyName = "clie_fone";
            this.cliefoneDataGridViewTextBoxColumn.HeaderText = "clie_fone";
            this.cliefoneDataGridViewTextBoxColumn.Name = "cliefoneDataGridViewTextBoxColumn";
            // 
            // clieemailDataGridViewTextBoxColumn
            // 
            this.clieemailDataGridViewTextBoxColumn.DataPropertyName = "clie_email";
            this.clieemailDataGridViewTextBoxColumn.HeaderText = "clie_email";
            this.clieemailDataGridViewTextBoxColumn.Name = "clieemailDataGridViewTextBoxColumn";
            // 
            // clieendDataGridViewTextBoxColumn
            // 
            this.clieendDataGridViewTextBoxColumn.DataPropertyName = "clie_end";
            this.clieendDataGridViewTextBoxColumn.HeaderText = "clie_end";
            this.clieendDataGridViewTextBoxColumn.Name = "clieendDataGridViewTextBoxColumn";
            // 
            // clieCEPDataGridViewTextBoxColumn
            // 
            this.clieCEPDataGridViewTextBoxColumn.DataPropertyName = "clie_CEP";
            this.clieCEPDataGridViewTextBoxColumn.HeaderText = "clie_CEP";
            this.clieCEPDataGridViewTextBoxColumn.Name = "clieCEPDataGridViewTextBoxColumn";
            // 
            // cadastrodeclientesBindingSource1
            // 
            this.cadastrodeclientesBindingSource1.DataMember = "cadastrodeclientes";
            this.cadastrodeclientesBindingSource1.DataSource = this.autopeca33DataSet;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnPesqPess
            // 
            this.btnPesqPess.Location = new System.Drawing.Point(592, 32);
            this.btnPesqPess.Name = "btnPesqPess";
            this.btnPesqPess.Size = new System.Drawing.Size(122, 29);
            this.btnPesqPess.TabIndex = 3;
            this.btnPesqPess.Text = "NOME";
            this.btnPesqPess.UseVisualStyleBackColor = true;
            this.btnPesqPess.Click += new System.EventHandler(this.btnPesqPess_Click);
            // 
            // btnIDClie
            // 
            this.btnIDClie.Location = new System.Drawing.Point(592, 75);
            this.btnIDClie.Name = "btnIDClie";
            this.btnIDClie.Size = new System.Drawing.Size(122, 31);
            this.btnIDClie.TabIndex = 4;
            this.btnIDClie.Text = "CÓDIGO ID";
            this.btnIDClie.UseVisualStyleBackColor = true;
            this.btnIDClie.Click += new System.EventHandler(this.btnIDClie_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(207, 387);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 38);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(358, 387);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 39);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(116, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome do Cliente";
            // 
            // lblCodClie
            // 
            this.lblCodClie.AutoSize = true;
            this.lblCodClie.Location = new System.Drawing.Point(116, 81);
            this.lblCodClie.Name = "lblCodClie";
            this.lblCodClie.Size = new System.Drawing.Size(75, 13);
            this.lblCodClie.TabIndex = 8;
            this.lblCodClie.Text = "Código Cliente";
            // 
            // cadastrodeclientesTableAdapter
            // 
            this.cadastrodeclientesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPesqCadClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodClie);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIDClie);
            this.Controls.Add(this.btnPesqPess);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesqCadClie";
            this.Text = "PESQUISAR CADASTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.frmPesqCadClie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeclientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPesqPess;
        private System.Windows.Forms.Button btnIDClie;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodClie;
        private Autopeca33DataSet autopeca33DataSet;
        private Autopeca33DataSetTableAdapters.cadastrodeclientesTableAdapter cadastrodeclientesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cadastrodeclientesBindingSource1;
    }
}