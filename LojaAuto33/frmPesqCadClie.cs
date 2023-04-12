using System;
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
    public partial class frmPesqCadClie : Form
    {
        public frmPesqCadClie()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void frmPesqCadClie_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrodeclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrodeclientesTableAdapter.Fill(this.autopeca33DataSet.cadastrodeclientes);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            frmAltClie newform5 = new frmAltClie();
            newform5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cadastrodeclientesBindingSource1.RemoveCurrent();
                cadastrodeclientesTableAdapter.Update(autopeca33DataSet.cadastrodeclientes); //salvar
                this.cadastrodeclientesTableAdapter.Fill(this.autopeca33DataSet.cadastrodeclientes);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesqPess_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                if (textBox1.Text.Length == 0)
                {
                    cadastrodeclientesBindingSource1.Filter = "";
                }
                else
                {
                    cadastrodeclientesBindingSource1.Filter = string.Format("clie_NM like'%{0}%'", textBox1.Text);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha apenas um campo, ou o nome ou o id", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIDClie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                if (textBox2.Text.Length == 0)
                {
                    cadastrodeclientesBindingSource1.Filter = "";
                }
                else
                {
                    cadastrodeclientesBindingSource1.Filter = string.Format("clie_CD={0}", textBox2.Text);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha apenas um campo, ou o nome ou o id", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
