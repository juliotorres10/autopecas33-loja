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
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Entre com os dados");
            }
            else
            {
                cadastrofuncionariosBindingSource.Filter = "func_usuario='" + textBox3.Text + "'";

                if (textBox1.Text.ToUpper() != textBox3.Text.ToUpper())
                {
                    MessageBox.Show("USUARIO ERRADO");
                    return;
                }

                cadastrofuncionariosBindingSource.Filter = "func_senha='" + textBox4.Text + "'";
                if (textBox2.Text.ToUpper() != textBox4.Text.ToUpper())
                {
                    MessageBox.Show("SENHA ERRADA");
                    return;
                }

                cadastrofuncionariosBindingSource.Filter = "func_cargo='" + comboBox2.Text + "'";

                if (comboBox1.Text.ToUpper() != comboBox2.Text.ToUpper())
                {
                    MessageBox.Show("CARGO ERRADO");
                    return;
                }
                this.Hide(); // oculta o formulário de login
                frmMenu menu = new frmMenu(); // cria um novo formulário de menu
                menu.Show(); // exibe o formulário de menu
            }

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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrofuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrofuncionariosTableAdapter.Fill(this.autopeca33DataSet.cadastrofuncionarios);
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrofuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrofuncionariosTableAdapter.Fill(this.autopeca33DataSet.cadastrofuncionarios);

        }
    }

}
