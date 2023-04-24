using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

    
        private void frmControlCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet1.CadProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutosTableAdapter.Fill(this.autopeca33DataSet1.CadProdutos);
            // TODO: esta linha de código carrega dados na tabela 'autopeca33DataSet.controlCaixa'. Você pode movê-la ou removê-la conforme necessário.
            this.controlCaixaTableAdapter.Fill(this.autopeca33DataSet.controlCaixa);

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            dataGridView1.Columns[3].DefaultCellStyle.Format = "C2";
            controlCaixaBindingSource.AddNew();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            string pesquisa = textBox2.Text;
            foreach (DataGridViewRow row in
                dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value.ToString().Contains(pesquisa))
                {
                    Produtos.Items.Add(row.Cells[1].Value.ToString()
                        + " | " +
                        row.Cells[2].Value.ToString()
                        + " | R$ " +
                        row.Cells[3].Value.ToString()
                        );

                    listBox1.Items.Add(row.Cells[3].Value.ToString());
                    double valorTotal = 0.00;

                    textBox1.Text = " " + row.Cells[0].Value.ToString() + " ";

                    foreach (string v in listBox1.Items)
                    {
                        double dv = Double.Parse(v);
                        valorTotal += dv;
                    }
                    textBox5.Text = "Valor total: " + valorTotal.ToString();

                    break;

                }


            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void lblFormPgto_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                cadProdutosBindingSource.Filter = string.Format("cadProd_CD={0}", textBox2.Text);
            }
            else
            {
               cadProdutosBindingSource.Filter = "";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
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
                MessageBox.Show("Compra finalizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("O carrinho não pode estar vazio", "Erro na compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNvOLTAR_Click_1(object sender, EventArgs e)
        {
            Form menuForm = new frmMenu(); // Crie uma nova instância do menu principal
            menuForm.Show(); // Exibir o menu principal
            this.Visible = false; // Fechar o formulário atual
        }

        private void Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(Produtos.Items.Count > 0)
            {
                string pesquisa = textBox2.Text;
                foreach (DataGridViewRow row in
                    dataGridView1.SelectedRows)
                {
                    if (row.Cells[0].Value.ToString().Contains(pesquisa))
                    {
                        Produtos.Items.Remove(
                            row.Cells[1].Value.ToString()
                            + " | " +
                            row.Cells[2].Value.ToString()
                            + " | R$ " +
                            row.Cells[3].Value.ToString()
                            );



                        listBox1.Items.Remove(row.Cells[3].Value.ToString());
                        double valorTotal = 0.00;

                        foreach (string v in listBox1.Items)
                        {
                            double dv = Double.Parse(v);
                            valorTotal += dv;
                        }
                        textBox5.Text = "Valor total: " + valorTotal.ToString();

                        break;

                    }


                }
                MessageBox.Show("O item foi removido com sucesso", "Remoção de item", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O carrinho está vazio, nada para tirar", "Erro no caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           textBox5.ForeColor = Color.Red;

        }
    }
}
