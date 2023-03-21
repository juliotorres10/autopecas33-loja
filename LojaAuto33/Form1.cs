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
    public partial class frmPesqProd : Form
    {
        public frmPesqProd()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadProd CadProd = new frmCadProd();
            CadProd.Show();
            this.Close();
        }
    }
}
