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
    public partial class frmCadFunc : Form
    {
        public frmCadFunc()
        {
            InitializeComponent();
        }

        private void fmrCadFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrofuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrofuncionariosTableAdapter.Fill(this.autopeca33DataSet.cadastrofuncionarios);
            cadastrofuncionariosBindingSource.AddNew();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Controls.OfType<TextBox>().Concat<Control>(Controls.OfType<ComboBox>()).
            Concat<Control>(Controls.OfType<CheckBox>()).ToList().ForEach(control => control.Text = "");

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrofuncionariosBindingSource.EndEdit();
            cadastrofuncionariosTableAdapter.Update(autopeca33DataSet.cadastrofuncionarios);
            this.cadastrofuncionariosTableAdapter.Fill(this.autopeca33DataSet.cadastrofuncionarios);
            cadastrofuncionariosBindingSource.MoveLast();

            //chamar um novo registro
            cadastrofuncionariosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }
    }
}
