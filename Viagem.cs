using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Viagem
    {
        private static int geradorId = 0;
        public int Id { get; set; }
        public Caminhao Caminhao { get; set; }
        public Motorista Motorista { get; set; }
        public Viagem()
        {
            this.Id = System.Threading.Interlocked.Increment(ref geradorId);
        }
        public Viagem(Caminhao caminhao, Motorista motorista, Viagem viagens)
        {
            this.Caminhao = caminhao;
            this.Motorista = motorista;          
            this.Id = System.Threading.Interlocked.Increment(ref geradorId);      
        }
           
    }
}
