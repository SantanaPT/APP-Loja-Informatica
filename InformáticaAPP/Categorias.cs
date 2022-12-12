using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformáticaAPP
{
    public class Categorias
    {
        //atributos
        private int codigo;          // maior que 0
        private string categoria;   // 3 a 50 chars
        private string zona;       // letra de A a Z
        private int fila;         // 1 a 100
        private int prateleira;  // 1 a 10

        //contrutor

        public Categorias()
        {
            this.codigo = -1;
            this.categoria = null;
            this.fila = 0;
            this.prateleira = 0;
        }

        public Categorias(int codigo, string categoria, int fila, int prateleira)
        {
            this.codigo = -1;
            this.categoria = null;
            this.fila = 0;
            this.prateleira = 0;
        }

        public int getCodigo() { return this.codigo; }

        public string getCategoria() { return this.categoria; }

        public string getZona() { return this.zona; }
        public int getFila() { return this.fila; }
        public int getPrateleira() { return this.prateleira; }

        //modificadores (setters)

        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setZona(string zona) { this.zona = zona; }
        public void setFila(int fila) { this.fila = fila; }

    }
}
