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
    public partial class frmControlEstoque : Form
    {
        public frmControlEstoque()
        {
            InitializeComponent();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesqControlEstoq pesqEstoq = new frmPesqControlEstoq();
            pesqEstoq.Show();
            this.Close();
        }

        private void frmControlEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.controlEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controlEstoqueTableAdapter.Fill(this.autopeca33DataSet.controlEstoque);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            controlEstoqueBindingSource.EndEdit();
            controlEstoqueTableAdapter.Update(autopeca33DataSet.controlEstoque);
            this.controlEstoqueTableAdapter.Fill(this.autopeca33DataSet.controlEstoque);
            controlEstoqueBindingSource.MoveLast();

            //chamar um novo registro
            controlEstoqueBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }
    }
}
