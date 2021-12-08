using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    internal class Caixa : Funcionario
    {
        public decimal Saldo  { get; set; }

        public decimal Getsaldo()
        {
            return Saldo = 100;
        }

        public void Depositar(decimal value)
        {
            Saldo += value;
        }

        public void Sacar (decimal value)
        {
            if (value <= Saldo)
            {
                Saldo += value;
            }
            else
            {
                Console.WriteLine("Esse saque não pode ser realizado, pois não tem saldo suficiente");
            }
        }
   
    
    
    
    
    
    
    
    
    
    }   
}
