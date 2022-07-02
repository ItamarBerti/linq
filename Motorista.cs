using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Motorista
    {
        private static int geradorId = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Motorista()
        {
            this.Id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        public Motorista(string endereco, string nome)
        {
            this.Endereco = endereco;
            this.Nome = nome;
            this.Id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        override
        public string ToString()
        {
            return "Id do veículo: " + this.Id + "Nome do motorista: " + this.Nome + "Endereço do motorista: " + this.Endereco;
        }
    }
}