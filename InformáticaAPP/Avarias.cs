using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformáticaAPP
{
    internal class Avarias
    {
        private int codigo;
        private DateTime data;
        private string nomeCliente;
        private long telefone;
        private string email;
        private string avaria;
        private Boolean garantia;

        //Empty Constructor

        public Avarias()
        {
            this.codigo = 0;
            this.data = DateTime.MinValue;
            this.nomeCliente = null;
            this.telefone = 0;
            this.email = null;
            this.avaria = null;
            this.garantia = false;
        }
        public Avarias(int codigo, DateTime data, string nomeCliente, long telefone, string email, string avaria, bool garantia)
        {
            this.codigo = codigo;
            this.data = data;
            this.nomeCliente = nomeCliente;
            this.telefone = telefone;
            this.email = email;
            this.avaria = avaria;
            this.garantia = garantia;
        }

        //Selectors

        public int getCodigo() { return codigo; }

        public DateTime getData() { return data; }

        public  string getNomeCliente() { return nomeCliente; }

        public long getTelefone() { return telefone; }

        public string getEmail() { return email; }

        public string getAvaria() { return avaria; }   

        public bool getGarantia() { return garantia; }

        //Modifiers

        public void setCodigo(int codigo) { this.codigo = codigo; }

        public void setData(DateTime data) { this.data = data; }

        public void setNomeCliente(string nomeCliente) { this.nomeCliente = nomeCliente; }

        public void setTelefone(long telefone) { this.telefone = telefone; }

        public void setEmail(string email) { this.email = email; }

        public void setAvaria(string avaria) { this.avaria = avaria; }

        public void setGarantia(bool garantia) { this.garantia = garantia; }


    }
}
