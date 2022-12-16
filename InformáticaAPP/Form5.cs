using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InformáticaAPP.Produto;

namespace InformáticaAPP
{
    public partial class Form5 : Form
    {
        //declarar um vetor para armazenar os registos
        private const int MaxCategorias = 100;
        private readonly Categorias[] categoriasVetor;
        //declarar contador de registos
        private int num_categorias;

        public Form5()
        {
            categoriasVetor = new Categorias[MaxCategorias];
            num_categorias = 0;
            InitializeComponent();
        }

        private void botFec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Limpar()
        {
            txtCodigo5.ResetText();
            txtCat5.ResetText();
            txtfila5.ResetText();
            txtfila5.ResetText();
            txtpart5.ResetText();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //configurar datagridview

            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.ColumnCount = 5;
            grelha.Columns[0].Name = "Código";
            grelha.Columns[0].Width = 50;
            grelha.Columns[1].Name = "Categoria";
            grelha.Columns[0].Width = 150;
            grelha.Columns[2].Name = "Zona";
            grelha.Columns[0].Width = 50;
            grelha.Columns[3].Name = "Fila";
            grelha.Columns[3].Width = 50;
            grelha.Columns[4].Name = "Prateleira";
            grelha.Columns[4].Width = 100;
            grelha.Rows.Clear();

            Limpar();
        }

        private void bot_apagar5_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnNovo5_Click(object sender, EventArgs e)
        {
            int x;
            //verificar se dos dados são válidos
            try
            {
                if (!int.TryParse(txtCodigo5.Text, out x))
                {
                    txtCodigo5.Focus();
                    throw new Exception("Insira um código válido");

                }
                else if (Convert.ToInt32(txtCodigo5.Text) < 1)
                {
                    txtCodigo5.Focus();
                    throw new Exception("Insira um código maior que 0");
                }

                //verificar se é uma descrição válida
                if (txtCat5.Equals("") ||
                   txtCat5.Text.Length < 3 ||
                   txtCat5.Text.Length > 50)
                {
                    txtCat5.Focus();
                    throw new Exception("Insira a descrição da categoria (3 a 50 caracters)");
                }
                //verificar se é uma zona válida

                if (txtzona5.Equals("") || !System.Text.RegularExpressions.Regex.IsMatch(txtzona5.Text, "^[a-zA-Z]"))

                {
                    txtzona5.Focus();
                    throw new Exception("Insira uma Zona (letra A a Z)");
                }

                //verificar se a fila é inteiro

                if (!int.TryParse(txtfila5.Text, out x))
                {
                    txtfila5.Focus();
                    throw new Exception("Insira uma Fila com valor inteiro");
                }
                else if (Convert.ToInt32(txtfila5.Text) < 1 || Convert.ToInt32(txtfila5.Text) > 100)
                {
                    txtfila5.Focus();
                    throw new Exception("Insira um valor da Fila entre 1 e 100");
                }

                //verificar se a parteleira é inteiro

                if (!int.TryParse(txtpart5.Text, out x))
                {
                    txtpart5.Focus();
                    throw new Exception("Insira uma parteleira com valor inteiro");
                }
                else if (Convert.ToInt32(txtpart5.Text) < 1 || Convert.ToInt32(txtpart5.Text) < 10)
                {
                    txtpart5.Focus();
                    throw new Exception("Insira um valor para a Parteleira entre 1 e 10");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            grelha.Rows.Add(txtCodigo5.Text, txtCat5.Text, txtzona5.Text, txtfila5.Text, txtpart5.Text);
            Limpar();
        }

        private void btnEliminar5_Click(object sender, EventArgs e)
        {
            if(posList != -1)
            {
                grelha.Rows.RemoveAt(posList);
                posList = -1;
                Limpar();
            }
            else
            {
                MessageBox.Show("Não existe nenhuma categorai selecionada!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //saber qual o index da categoria selecionado no datagridview
        
        private void grelha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int posList = -1;
        private void grelha_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posList = grelha.CurrentCell.RowIndex;
            if(posList != -1)
            {
                txtCodigo5.Text = grelha.Rows[posList].Cells[0].Value.ToString();
                txtCat5.Text = grelha.Rows[posList].Cells[1].Value.ToString();
                txtzona5.Text = grelha.Rows[posList].Cells[2].Value.ToString();
                txtfila5.Text = grelha.Rows[posList].Cells[3].Value.ToString();
                txtpart5.Text = grelha.Rows[posList].Cells[4].Value.ToString();
                txtCodigo5.Focus();
            }
        }

        private void btnAtualizar5_Click(object sender, EventArgs e)
        {
            if(posList != -1)
            {



            
                int x;
                //verificar se dos dados são válidos
                try
                {
                    if (!int.TryParse(txtCodigo5.Text, out x))
                    {
                        txtCodigo5.Focus();
                        throw new Exception("Insira um código válido");

                    }
                    else if (Convert.ToInt32(txtCodigo5.Text) < 1)
                    {
                        txtCodigo5.Focus();
                        throw new Exception("Insira um código maior que 0");
                    }

                    //verificar se é uma descrição válida
                    if (txtCat5.Equals("") ||
                       txtCat5.Text.Length < 3 ||
                       txtCat5.Text.Length > 50)
                    {
                        txtCat5.Focus();
                        throw new Exception("Insira a descrição da categoria (3 a 50 caracters)");
                    }
                    //verificar se é uma zona válida

                    if (txtzona5.Equals("") || !System.Text.RegularExpressions.Regex.IsMatch(txtzona5.Text, "^[a-zA-Z]"))

                    {
                        txtzona5.Focus();
                        throw new Exception("Insira uma Zona (letra A a Z)");
                    }

                    //verificar se a fila é inteiro

                    if (!int.TryParse(txtfila5.Text, out x))
                    {
                        txtfila5.Focus();
                        throw new Exception("Insira uma Fila com valor inteiro");
                    }
                    else if (Convert.ToInt32(txtfila5.Text) < 1 || Convert.ToInt32(txtfila5.Text) > 100)
                    {
                        txtfila5.Focus();
                        throw new Exception("Insira um valor da Fila entre 1 e 100");
                    }

                    //verificar se a parteleira é inteiro

                    if (!int.TryParse(txtpart5.Text, out x))
                    {
                        txtpart5.Focus();
                        throw new Exception("Insira uma parteleira com valor inteiro");
                    }
                    else if (Convert.ToInt32(txtpart5.Text) < 1 || Convert.ToInt32(txtpart5.Text) < 10)
                    {
                        txtpart5.Focus();
                        throw new Exception("Insira um valor para a Parteleira entre 1 e 10");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                //colocar linha no datagridview
                grelha.Rows.RemoveAt(posList);
                grelha.Rows.Insert(posList, txtCodigo5.Text, txtCat5.Text,
                txtzona5.Text, txtfila5.Text, txtpart5.Text);
                posList = -1;
                Limpar();
            }
        }
        private void AdicionarCategoria(Categorias c)
        {
            if (num_categorias < MaxCategorias)
            {
                categoriasVetor[num_categorias++] = c;
            }
        }
        private void btnGuardar5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in grelha.Rows)
            {
                int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
                string categoria = linha.Cells[1].Value.ToString();
                string zona = linha.Cells[1].Value.ToString();
                int fila = Convert.ToInt32(linha.Cells[3].Value.ToString());
                int prateleira = Convert.ToInt32(linha.Cells[4].Value.ToString());

                AdicionarCategoria(new Categorias(codigo, categoria, zona, fila, prateleira));
                MessageBox.Show("Registo guardados com sucesso.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
