using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InformáticaAPP
{
    public partial class Form3 : Form
    {
        private const int MaxAvarias = 200;
        private readonly Avarias[] avarias;
        private int num_avarias;

 
        public Form3()
        {
            avarias = new Avarias[MaxAvarias];
            num_avarias = 0;
            InitializeComponent();
        }
        private void Limpar()
        {
            txtCodigo.ResetText();
            dtData.Value = DateTime.Now;
            txtNome.ResetText();
            txtTelefone.ResetText();
            txtEmail.ResetText();
            cbAvaria.SelectedIndex = -1;
            chkGarantia.Checked = false;
            txtCodigo.Focus();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            cbAvaria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAvaria.Items.Clear();
            cbAvaria.Items.Add("Não Liga");
            cbAvaria.Items.Add("Bloqueia");
            cbAvaria.Items.Add("Ecrã com defeito");
            cbAvaria.Items.Add("Teclado com defeito");
            cbAvaria.Items.Add("Software com erros");
            cbAvaria.Items.Add("Não lê cartão SIM");
            cbAvaria.Items.Add("Não lê cartão de memória");
            cbAvaria.Items.Add("Desliga-se");
            cbAvaria.Items.Add("Não carrega");
            cbAvaria.SelectedIndex = -1;
            //Popriedades datagrew

            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible = false;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grel
                
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
