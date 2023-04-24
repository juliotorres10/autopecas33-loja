namespace LojaAuto33
{
    partial class frmPesqCadFunc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cadastrofuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopeca33DataSet = new LojaAuto33.Autopeca33DataSet();
            this.cadastrofuncionariosTableAdapter = new LojaAuto33.Autopeca33DataSetTableAdapters.cadastrofuncionariosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.funcCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_datadenasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrofuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(38, 81);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            // 
            // lblRepres
            // 
            this.lblRepres.AutoSize = true;
            this.lblRepres.Location = new System.Drawing.Point(38, 33);
            this.lblRepres.Name = "lblRepres";
            this.lblRepres.Size = new System.Drawing.Size(93, 13);
            this.lblRepres.TabIndex = 25;
            this.lblRepres.Text = "Nome Funcionário";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(269, 398);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(137, 399);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 30);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIDPess
            // 
            this.btnIDPess.Location = new System.Drawing.Point(377, 63);
            this.btnIDPess.Name = "btnIDPess";
            this.btnIDPess.Size = new System.Drawing.Size(122, 31);
            this.btnIDPess.TabIndex = 21;
            this.btnIDPess.Text = "CÓDIGO ID";
            this.btnIDPess.UseVisualStyleBackColor = true;
            // 
            // btnPesqPess
            // 
            this.btnPesqPess.Location = new System.Drawing.Point(377, 21);
            this.btnPesqPess.Name = "btnPesqPess";
            this.btnPesqPess.Size = new System.Drawing.Size(122, 29);
            this.btnPesqPess.TabIndex = 20;
            this.btnPesqPess.Text = "PESQUISA PESSOA";
            this.btnPesqPess.UseVisualStyleBackColor = true;
            this.btnPesqPess.Click += new System.EventHandler(this.btnPesqPess_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcCDDataGridViewTextBoxColumn,
            this.func_NM,
            this.func_CPF,
            this.func_RG,
            this.func_datadenasc,
            this.func_end,
            this.func_fone,
            this.func_email,
            this.func_usuario,
            this.func_senha,
            this.func_cargo});
            this.dataGridView1.DataSource = this.cadastrofuncionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 203);
            this.dataGridView1.TabIndex = 22;
            // 
            // cadastrofuncionariosBindingSource
            // 
            this.cadastrofuncionariosBindingSource.DataMember = "cadastrofuncionarios";
            this.cadastrofuncionariosBindingSource.DataSource = this.autopeca33DataSet;
            // 
            // autopeca33DataSet
            // 
            this.autopeca33DataSet.DataSetName = "Autopeca33DataSet";
            this.autopeca33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastrofuncionariosTableAdapter
            // 
            this.cadastrofuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // funcCDDataGridViewTextBoxColumn
            // 
            this.funcCDDataGridViewTextBoxColumn.DataPropertyName = "func_CD";
            this.funcCDDataGridViewTextBoxColumn.HeaderText = "func_CD";
            this.funcCDDataGridViewTextBoxColumn.Name = "funcCDDataGridViewTextBoxColumn";
            this.funcCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // func_NM
            // 
            this.func_NM.DataPropertyName = "func_NM";
            this.func_NM.HeaderText = "Nome";
            this.func_NM.Name = "func_NM";
            // 
            // func_CPF
            // 
            this.func_CPF.DataPropertyName = "func_CPF";
            this.func_CPF.HeaderText = "CPF";
            this.func_CPF.Name = "func_CPF";
            // 
            // func_RG
            // 
            this.func_RG.DataPropertyName = "func_RG";
            this.func_RG.HeaderText = "RG";
            this.func_RG.Name = "func_RG";
            // 
            // func_datadenasc
            // 
            this.func_datadenasc.DataPropertyName = "func_datadenasc";
            this.func_datadenasc.HeaderText = "Data de Nascimento";
            this.func_datadenasc.Name = "func_datadenasc";
            // 
            // func_end
            // 
            this.func_end.DataPropertyName = "func_end";
            this.func_end.HeaderText = "Endereço";
            this.func_end.Name = "func_end";
            // 
            // func_fone
            // 
            this.func_fone.DataPropertyName = "func_fone";
            this.func_fone.HeaderText = "Telefone";
            this.func_fone.Name = "func_fone";
            // 
            // func_email
            // 
            this.func_email.DataPropertyName = "func_email";
            this.func_email.HeaderText = "Email";
            this.func_email.Name = "func_email";
            // 
            // func_usuario
            // 
            this.func_usuario.DataPropertyName = "func_usuario";
            this.func_usuario.HeaderText = "Usuário";
            this.func_usuario.Name = "func_usuario";
            // 
            // func_senha
            // 
            this.func_senha.DataPropertyName = "func_senha";
            this.func_senha.HeaderText = "Senha";
            this.func_senha.Name = "func_senha";
            // 
            // func_cargo
            // 
            this.func_cargo.DataPropertyName = "func_cargo";
            this.func_cargo.HeaderText = "Cargo";
            this.func_cargo.Name = "func_cargo";
            // 
            // frmPesqCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
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
            this.Name = "frmPesqCadFunc";
            this.Text = "frmPesqCadFunc";
            this.Load += new System.EventHandler(this.frmPesqCadFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrofuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopeca33DataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource cadastrofuncionariosBindingSource;
        private Autopeca33DataSetTableAdapters.cadastrofuncionariosTableAdapter cadastrofuncionariosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcdatadenascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcfoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcsenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funccargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_datadenasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_cargo;
    }
}