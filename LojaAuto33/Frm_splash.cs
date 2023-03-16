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
    public partial class Frm_splash : Form
    {
        public Frm_splash()
        {
            InitializeComponent();
            pbar.Value = 0;
            pbar.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(363, 338);
            pictureBox1.BackColor = Color.Transparent;
        }

        private void Frm_splash_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 2;
            pbar.Text = pbar.Value.ToString() + "%";
            if(pbar.Value == 100)
            {
                timer1.Enabled = false;
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
