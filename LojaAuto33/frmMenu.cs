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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pEDIDODECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta o formulário de login
            frmPedDeCompra menu = new frmPedDeCompra(); // cria um novo formulário de menu
            menu.Show();
        }

        private void cONTROLEDEESTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta o formulário de login
            frmControlEstoque menu = new frmControlEstoque(); // cria um novo formulário de menu
            menu.Show();

        }

        private void cADASTRODEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta o formulário de login
            frmCadProd menu = new frmCadProd(); // cria um novo formulário de menu
            menu.Show();
        }

        private void tROCADEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta o formulário de login
            frmTrocaProd menu = new frmTrocaProd(); // cria um novo formulário de menu
            menu.Show();
        }

        private void cONTROLEDECAIXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta o formulário de login
            frmControlCaixa menu = new frmControlCaixa(); // cria um novo formulário de menu
            menu.Show();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadFunc menu = new frmCadFunc();
            menu.Show();
            


        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadClie menu = new frmCadClie();
            menu.Show();
        }

        private void fORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadForn menu = new frmCadForn();
            menu.Show();
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
