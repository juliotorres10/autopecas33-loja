﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaAuto33
{
    public partial class frmPesqCadFornec : Form
    {
        public frmPesqCadFornec()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void frmPescCadFornec_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrodeFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrodeFornecedoresTableAdapter.Fill(this.autopeca33DataSet.cadastrodeFornecedores);

        }

        private void btnPesqPess_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
            {
                cadastrodeFornecedoresBindingSource.Filter = "";
            }
            else
            {
                cadastrodeFornecedoresBindingSource.Filter = string.Format("forn_id like'%{0}%'", textBox1.Text);
            }
        }
    }
}
