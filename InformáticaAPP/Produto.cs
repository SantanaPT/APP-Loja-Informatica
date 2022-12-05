using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformáticaAPP
{
    internal class Produto
    {
        
        public class Produtos
        {
        //Atributos

            private int codigo;
            private string nomeProduto;
            private int categoria;
            private double preco;

        //Construtor

            public Produtos()
            {
                this.codigo = 0;
                this.nomeProduto = "";
                this.categoria = -1;
                this.preco = 0;
            }
            public Produtos (int codigo, string nomeProduto, int categoria, double preco)
            {
                this.codigo = codigo;
                this.nomeProduto = nomeProduto;
                this.categoria = categoria;
                this.preco = preco;
            }

            //seletores

            public int getCodigo()
            {
                return codigo;
            }

            public string getNomeProduto() { return nomeProduto; }
            public int getCategoria() { return categoria; }
            public double getPreco() { return preco; }

            //modificadores
            
           public void setCodigo (int codigo) { this.codigo = codigo; }
           public void setNomeProduto(string nomeProduto) { this.nomeProduto = nomeProduto; }
           public void setCategoria(int categoria) { this.categoria = categoria; }
           public void setPreco(double preco) { this.preco = preco; }

        }
   }
}