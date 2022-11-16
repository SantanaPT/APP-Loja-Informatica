using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformáticaAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string user, string pass)
        {
            InitializeComponent();
            text_user.Text = user;
            text_pass.Text = pass;
        }
        public string user;
        public string pass;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.utilizador = text_nome.Text;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            if (text_pass.Text == "welcome_")
            {
                FormMain.utilizador = text_nome.Text;
                FormMain Parent = (FormMain)this.MdiParent;
                Parent.MostrarLogin(text_nome.Text);
                Close();   
            }
            else
            {
                MessageBox.Show("Password incorreta!", "ERRO!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }
    }
}
