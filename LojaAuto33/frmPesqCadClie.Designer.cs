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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPesqPess = new System.Windows.Forms.Button();
            this.btnIDClie = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodClie = new System.Windows.Forms.Label();
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.autopeca33DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrodeclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrodeclientesTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.cadastrodeclientesTableAdapter();
            this.clieCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeclientesBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.cadastrodeclientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(119, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnPesqPess
            // 
            this.btnPesqPess.Location = new System.Drawing.Point(339, 34);
            this.btnPesqPess.Name = "btnPesqPess";
            this.btnPesqPess.Size = new System.Drawing.Size(122, 29);
            this.btnPesqPess.TabIndex = 3;
            this.btnPesqPess.Text = "PESQUISA PESSOA";
            this.btnPesqPess.UseVisualStyleBackColor = true;
            // 
            // btnIDClie
            // 
            this.btnIDClie.Location = new System.Drawing.Point(339, 77);
            this.btnIDClie.Name = "btnIDClie";
            this.btnIDClie.Size = new System.Drawing.Size(122, 31);
            this.btnIDClie.TabIndex = 4;
            this.btnIDClie.Text = "CÓDIGO ID";
            this.btnIDClie.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(119, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 30);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(251, 407);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome do Cliente";
            // 
            // lblCodClie
            // 
            this.lblCodClie.AutoSize = true;
            this.lblCodClie.Location = new System.Drawing.Point(28, 83);
            this.lblCodClie.Name = "lblCodClie";
            this.lblCodClie.Size = new System.Drawing.Size(75, 13);
            this.lblCodClie.TabIndex = 8;
            this.lblCodClie.Text = "Código Cliente";
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
            // cadastrodeclientesBindingSource
            // 
            this.cadastrodeclientesBindingSource.DataMember = "cadastrodeclientes";
            this.cadastrodeclientesBindingSource.DataSource = this.autopeca33DataSetBindingSource;
            // 
            // cadastrodeclientesTableAdapter
            // 
            this.cadastrodeclientesTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrodeclientesBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource autopeca33DataSetBindingSource;
        private Autopeca33DataSet autopeca33DataSet;
        private System.Windows.Forms.BindingSource cadastrodeclientesBindingSource;
        private Autopeca33DataSetTableAdapters.cadastrodeclientesTableAdapter cadastrodeclientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}