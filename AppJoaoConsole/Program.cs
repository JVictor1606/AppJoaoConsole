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
            Venda venda = new Venda();
            venda.Id = 1;
            venda.Valor = 90M;
            venda.Data = DateTime.Now;


            Console.WriteLine("O nome é: " + venda.Data.ToString());
            Console.WriteLine("Valor: " + venda.Valor.ToString());
            Console.Read();
        }
    }
}
