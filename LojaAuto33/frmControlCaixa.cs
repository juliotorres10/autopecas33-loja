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
    public partial class frmControlCaixa : Form
    {
        public frmControlCaixa()
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

        private void frmControlCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.controlCaixa'. Você pode movê-la ou removê-la conforme necessário.
            this.controlCaixaTableAdapter.Fill(this.autopeca33DataSet.controlCaixa);
            controlCaixaBindingSource.AddNew();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            this.Validate();
            controlCaixaBindingSource.EndEdit();
            controlCaixaTableAdapter.Update(autopeca33DataSet.controlCaixa);
            this.controlCaixaTableAdapter.Fill(this.autopeca33DataSet.controlCaixa);
            controlCaixaBindingSource.MoveLast();

            //chamar um novo registro
            controlCaixaBindingSource.AddNew();

            textBox2.Focus();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa cadastrada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
