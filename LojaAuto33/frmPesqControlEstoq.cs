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
    public partial class frmPesqControlEstoq : Form
    {
        public frmPesqControlEstoq()
        {
            InitializeComponent();
        }

        private void frmPesqControlEstoq_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.controlEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controlEstoqueTableAdapter.Fill(this.autopeca33DataSet.controlEstoque);

        }
    }
}
