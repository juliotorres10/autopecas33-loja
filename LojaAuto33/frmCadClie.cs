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
    public partial class frmCadClie : Form
    {
        public frmCadClie()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Controls.OfType<TextBox>().Concat<Control>(Controls.OfType<ComboBox>()).
            Concat<Control>(Controls.OfType<CheckBox>()).ToList().ForEach(control => control.Text = "");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abra o formulário de cadastro de clientes
            frmPesqCadClie frmCadClie = new frmPesqCadClie();
            frmCadClie.Show();

        }
    }
}
