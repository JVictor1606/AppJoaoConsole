using AppJoaoConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppJoaoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Cor = "Vermelho";
            carro.Placa = "RDU-456";
            carro.Ano = 2015;


            Console.WriteLine("O nome é: " + carro.Cor);
            Console.WriteLine("Valor: " + carro.Placa);
            Console.Read();
        }
    }
}
