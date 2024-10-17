using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hortalizas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            inicio form = new inicio();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frm_closing(object sender, EventArgs e)
        {
            txtdocumento.Text = "";
            txtcontraseña.Text = "";
            this.Show();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
