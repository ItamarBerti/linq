using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Caminhao
    {
        private static int geradorId = 0;
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public Caminhao()
        {
            this.Id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        public Caminhao(string modelo, string placa)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        override
        public string ToString()
        {
            return "Id do veículo: " + this.Id + "Placa do veículo: " + this.Placa + "Modelo do veículo: " + this.Modelo;
        }
    }
}
