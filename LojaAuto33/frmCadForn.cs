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
    public partial class frmCadForn : Form
    {
        public frmCadForn()
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

        private void btnCad_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrodeFornecedoresBindingSource.EndEdit();
            cadastrodeFornecedoresTableAdapter.Update(autopeca33DataSet.cadastrodeFornecedores);
            this.cadastrodeFornecedoresTableAdapter.Fill(this.autopeca33DataSet.cadastrodeFornecedores);
            cadastrodeFornecedoresBindingSource.MoveLast();

            //chamar um novo registro
            cadastrodeFornecedoresBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void frmCadForn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.cadastrodeFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrodeFornecedoresTableAdapter.Fill(this.autopeca33DataSet.cadastrodeFornecedores);
            cadastrodeFornecedoresBindingSource.AddNew();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
