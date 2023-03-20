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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

            
        {
            // Seu código de login aqui
            MessageBox.Show("Logado com sucesso!");
            this.Hide(); // oculta o formulário de login
            frmMenu menu = new frmMenu(); // cria um novo formulário de menu
            menu.Show(); // exibe o formulário de menu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
