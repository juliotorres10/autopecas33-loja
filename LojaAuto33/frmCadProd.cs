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
    public partial class frmCadProd : Form
    {
        public frmCadProd()
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

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadProdutosBindingSource.EndEdit();
            cadProdutosTableAdapter.Update(autopeca33DataSet.CadProdutos);
            this.cadProdutosTableAdapter.Fill(this.autopeca33DataSet.CadProdutos);
            cadProdutosBindingSource.MoveLast();

            //chamar um novo registro
            cadProdutosBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesqProd pesqProd = new frmPesqProd();
            pesqProd.Show();
            this.Close();
        }

        private void frmCadProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.autopeca33DataSet.CadProdutos);
            cadProdutosBindingSource.AddNew();

        }
    }
}
