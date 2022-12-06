using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformáticaAPP
{
    public partial class lstb_produtos : Form
    {
        //declarar um vetor para armazenar os registos
        private const int MaxProdutos = 100;
        private readonly Produto[] produtos;

        //declarar contador de registos
        private int num_produtos;

        public lstb_produtos()
        {
            produtos = new Produto[MaxProdutos];
            num_produtos = 0;
            InitializeComponent();

            //configurar a combobox
            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Hardware");
            cbCategoria.Items.Add("Software");
            cbCategoria.SelectedIndex = -1;
        }
        private void Limpar()
        {
            txtCodigo.ResetText();
            txtProdutos.ResetText();
            txtPreco.ResetText();
            cbCategoria.SelectedIndex = -1;
            txtCodigo.Focus();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Limpar();

        }
        private void AdicionarProdutos(Produto p)
        {
            if (num_produtos < MaxProdutos)
            {
                produtos[num_produtos++] = p;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            //verificar se dos dados são válidos
            try
            {
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código válido");

                }
                else if (Convert.ToInt32(txtCodigo.Text) < 100)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código com mais de 3 dígitos");
                }

                //verificar se é uma descrição válida
                if (txtProdutos.Text.Equals("") ||
                   txtProdutos.Text.Length < 3 ||
                   txtProdutos.Text.Length > 50)
                {
                    txtProdutos.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 caracters)");
                }
                //verificar categoria
                if (cbCategoria.SelectedIndex == -1)
                {
                    throw new Exception("Escolhe uma categoria!");
                }
                //verificar se preco é double
                if (!double.TryParse(txtPreco.Text, out y))
                {
                    txtPreco.Focus();
                    throw new Exception("Insira em preço um numérico");
                }
                else if (Convert.ToDouble(txtPreco.Text) <= 0)
                {
                    txtPreco.Focus();
                    throw new Exception("Insira um valor superiror a 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string linha = txtCodigo.Text + " | " + txtProdutos.Text + " | " +
                cbCategoria.SelectedItem + " | " + txtPreco.Text;

            listBox1.Items.Add(linha);
            Limpar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private int posLista = -1;
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //ajustar
            posLista = listBox1.SelectedIndex;

            string[]  campos = listBox1.SelectedItem.ToString().Split('|');

            txtCodigo.Text = campos[0].Trim();
            txtProdutos.Text = campos[1].Trim();

            switch (campos[2].Trim())
            {
                case "Hardware": cbCategoria.SelectedIndex = 0; break;
                case "Software": cbCategoria.SelectedIndex = 1; break;
                default: cbCategoria.SelectedIndex = -1; break;
            }
            txtPreco.Text = campos[3].Trim();
            txtCodigo.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            //verificar se dos dados são válidos
            try
            {
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código válido");

                }
                else if (Convert.ToInt32(txtCodigo.Text) < 100)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código com mais de 3 dígitos");
                }

                //verificar se é uma descrição válida
                if (txtProdutos.Text.Equals("") ||
                   txtProdutos.Text.Length < 3 ||
                   txtProdutos.Text.Length > 50)
                {
                    txtProdutos.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 caracters)");
                }
                //verificar categoria
                if (cbCategoria.SelectedIndex == -1)
                {
                    throw new Exception("Escolhe uma categoria!");
                }
                //verificar se preco é double
                if (!double.TryParse(txtPreco.Text, out y))
                {
                    txtPreco.Focus();
                    throw new Exception("Insira em preço um numérico");
                }
                else if (Convert.ToDouble(txtPreco.Text) <= 0)
                {
                    txtPreco.Focus();
                    throw new Exception("Insira um valor superiror a 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string linha = txtCodigo.Text + " | " + txtProdutos.Text + " | " +
                cbCategoria.SelectedItem + " | " + txtPreco.Text;
            
            listBox1.Items.RemoveAt(posLista);
            listBox1.Items.Insert(posLista, linha);
            posLista = -1;
            Limpar();
        }
    }
}
