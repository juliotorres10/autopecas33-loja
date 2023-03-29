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
            this.Validate();
            cadastrodeclientesBindingSource.EndEdit();
            cadastrodeclientesTableAdapter.Update(autopeca33DataSet.cadastrodeclientes);
            this.cadastrodeclientesTableAdapter.Fill(this.autopeca33DataSet.cadastrodeclientes);
            cadastrodeclientesBindingSource.MoveLast();

            //chamar um novo registro
            cadastrodeclientesBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abra o formulário de cadastro de clientes
            frmPesqCadClie frmCadClie = new frmPesqCadClie();
            frmCadClie.Show();

        }

        private void frmCadClie_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrodeclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrodeclientesTableAdapter.Fill(this.autopeca33DataSet.cadastrodeclientes);
            cadastrodeclientesBindingSource.AddNew();

        }
    }
}
