using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    internal class Caixa : Entidade
    {
        private decimal Saldo   { get; set ; }

        public decimal Getsaldo()
        {
            return Saldo;
        }

        public void Depositar(decimal value)
        {
            Saldo += value;
        }

        public void Sacar(decimal value)
        {
            if (value <= Saldo)
            {
                Saldo -= value;
            }
            else
            {
                Console.WriteLine("Esse saque não pode ser realizado, pois não tem saldo suficiente");
                Console.WriteLine("Você tentou sacar : " + value + "R$");
                Console.WriteLine("Esse é o seu saldo atual = " + Saldo +"R$"); 
            }
        }   
        
    }   
}
