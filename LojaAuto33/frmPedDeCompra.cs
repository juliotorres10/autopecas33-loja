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
    public partial class frmPedDeCompra : Form
    {
        public frmPedDeCompra()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            // Mensagem cadstro produto usando clique no botão cadastrar
            MessageBox.Show("Pedido Cadastrado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());

        }

        private void btnPedComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
