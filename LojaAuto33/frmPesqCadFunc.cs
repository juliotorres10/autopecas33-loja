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
    public partial class frmPesqCadFunc : Form
    {
        public frmPesqCadFunc()
        {
            InitializeComponent();
        }

        private void frmPesqCadFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrofuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrofuncionariosTableAdapter.Fill(this.autopeca33DataSet.cadastrofuncionarios);

        }

        private void btnPesqPess_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                if (textBox1.Text.Length == 0)
                {
                    cadastrofuncionariosBindingSource.Filter = "";
                }
                else
                {
                    cadastrofuncionariosBindingSource.Filter = string.Format("func_CD like'%{0}%'", textBox1.Text);
                }

            }
            else
            {
                MessageBox.Show("Por favor, preencha apenas um campo, ou o nome ou o id", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
