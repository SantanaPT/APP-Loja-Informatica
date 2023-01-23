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
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.ColumnCount = 6;
            grelha.Columns[0].Name = "Código";
            grelha.Columns[1].Name = "Data";
            grelha.Columns[2].Name = "Cliente";
            grelha.Columns[3].Name = "Contacto";
            grelha.Columns[4].Name = "Descrição";
            grelha.Columns[5].Name = "Garantia";
            grelha.Columns[0].Width = 100;
            grelha.Columns[1].Width = 100;
            grelha.Columns[2].Width = 300;
            grelha.Columns[3].Width = 150;
            grelha.Columns[4].Width = 350;
            grelha.Columns[5].Width = 50;
            grelha.Rows.Clear();
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tsAdicionar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void ts_anular_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void ts_validar_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                //verificar se o código
                if(!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insiria um Código válido.");
                }
                else if(Convert.ToInt32(txtCodigo.Text) < 0)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Código com valor positivo.");
                }

                //verificar se o nome do cliente é válido
                if (txtNome.Text.Equals("") || txtNome.Text.Length < 3 || txtNome.Text.Length > 50)
                {
                    txtNome.Focus();
                    throw new Exception("Insira o Nome do cliente (3 a 50 caracteres).");
                }
                if (!int.TryParse(txtTelefone.Text, out x))
                {
                    txtTelefone.Focus();
                    throw new Exception("Insira um número de Telefone  válido.");

                }
                else if (Convert.ToInt32(txtTelefone.Text) < 210000000)
                {
                    txtTelefone.Focus();
                    throw new Exception("Insira um número de telefone válido.");
                }
                //verificar se escolheu o tipo de avaria
                if(cbAvaria.SelectedIndex == -1)
                {
                    throw new Exception("Escolha da lista a tipologia da avaria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            grelha.Rows.Add(txtCodigo.Text.ToString(), dtData.Value.ToString(), 
                txtNome.Text, txtTelefone.Text, cbAvaria.SelectedItem, chkGarantia.Checked ? "Sim" : "Não");

            int codigo = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtData.Value;
            string nome = txtNome.Text;
            long telefone = Convert.ToInt64(txtTelefone.Text);
            string email = txtEmail.Text;
            string avaria = cbAvaria.SelectedItem.ToString();
            bool garantia = chkGarantia.Checked;
            AdicionaAvaria(new Avarias(codigo, data, nome, telefone, email, avaria, garantia));
            Limpar();
        }
        private void AdicionaAvaria(Avarias av)
        {
            if (num_avarias < MaxAvarias)
            {
                avarias[num_avarias++] = av;
            }
        }

        private void tsGuardarSair_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\data";
                if (!Directory.Exists(target))
                {
                    DirectoryInfo di = Directory.CreateDirectory(target);
                }
                string caminho = target + "\\avarias.txt";
                Stream ficheiro = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                StreamWriter registo = new StreamWriter(ficheiro);

                for(int i = 0; i < num_avarias; i++)
                {
                    int codigo = avarias[i].getCodigo();
                    DateTime data = avarias[i].getData();
                    string nome = avarias[i].getNomeCliente();
                    long telefone = avarias[i].getTelefone();
                    string email = avarias[i].getEmail();
                    string avaria = avarias[i].getAvaria();
                    bool garantia = avarias[i].getGarantia();
                    registo.Write(codigo + ";");
                    registo.Write(data + ";");
                    registo.Write(nome + ";");
                    registo.Write(telefone + ";");
                    registo.Write(email + ";");
                    registo.Write(avaria + ";");
                    registo.Write(garantia + ";");
                    registo.Write(Environment.NewLine);
                }
                registo.Close();
                ficheiro.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
