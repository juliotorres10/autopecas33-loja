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
            // Esconda o formulário atual
            this.Hide();

            // Abra o formulário de cadastro de clientes
            frmCadClie frmCadClie = new frmCadClie();
            frmCadClie.Show();
        }

        private void frmPesqCadClie_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrodeclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrodeclientesTableAdapter.Fill(this.autopeca33DataSet.cadastrodeclientes);

        }
    }
}
