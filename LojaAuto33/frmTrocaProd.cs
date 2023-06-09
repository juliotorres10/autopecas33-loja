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
    public partial class frmTrocaProd : Form
    {
        public frmTrocaProd()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Controls.OfType<TextBox>().Concat<Control>(Controls.OfType<ComboBox>()).
            Concat<Control>(Controls.OfType<CheckBox>()).ToList().ForEach(control => control.Text = "");
        }

        private void btnDevolocao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Devolução bem sucedida!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
          
        }

        private void frmTrocaProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.trocaProd'. Você pode movê-la ou removê-la conforme necessário.
            this.trocaProdTableAdapter.Fill(this.autopeca33DataSet.trocaProd);

        }
    }
}
