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
    public partial class frmPescCadFornec : Form
    {
        public frmPescCadFornec()
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
    }
}
