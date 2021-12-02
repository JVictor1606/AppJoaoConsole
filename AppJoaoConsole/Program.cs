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
            Cliente cli1 = new Cliente("Primeiro Cliente");

            Cliente cli2 = new Cliente("Segundo Cliente");

            Cliente cli3 = new Cliente();

            

            //cli1.ExibirCliente();
            //cli2.ExibirCliente();

            Console.WriteLine(cli1.Id);
            Console.WriteLine(cli2.Id);



            Console.Read();
        }
    }
}
