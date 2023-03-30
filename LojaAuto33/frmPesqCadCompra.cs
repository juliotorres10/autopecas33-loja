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
    public partial class frmPesqCadCompra : Form
    {
        public frmPesqCadCompra()
        {
            InitializeComponent();
        }

        private void frmPesqCadCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.pedidosdecompras'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosdecomprasTableAdapter.Fill(this.autopeca33DataSet.pedidosdecompras);

        }
    }
}
