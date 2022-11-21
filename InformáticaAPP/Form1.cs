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
    public partial class FormMain : Form
    {
        public static string utilizador = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.Hour.ToString("00");
            label_min.Text = DateTime.Now.Minute.ToString("00");
            label_sec.Text = DateTime.Now.Second.ToString("00");
            timerSeg.Start();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
        }

        public void MostrarLogin(string u)
        {
            if (u != null)
            {
                lbl_util.Text = utilizador;
                ficheirosToolStripMenuItem.Enabled = true;
                produtosToolStripMenuItem.Enabled = true;
                VendasToolStripMenuItem.Enabled = true;
                reparar_ToolStripMenuItem.Enabled = true;
            }
            else
            {
                lbl_util.Text = "Login";
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void ficheirosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
                ActiveMdiChild.Close();
            lbl_util.Text = "Login";
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
            ficheirosToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            VendasToolStripMenuItem.Enabled = false;
            reparar_ToolStripMenuItem.Enabled = false;
        }

        private void lbl_util_Click(object sender, EventArgs e)
        {

        }

        private void reparar_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void timerSeg_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.Hour.ToString("00");
            label_min.Text = DateTime.Now.Minute.ToString("00");
            label_sec.Text = DateTime.Now.Second.ToString("00");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
