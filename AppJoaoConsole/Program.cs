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
            
            Caixa Paulo = new Caixa();
            Paulo.Nome = " Paulo";
            Paulo.Getsaldo();
            Console.WriteLine(Paulo.Saldo);
            Paulo.Depositar(500);
            Console.WriteLine(Paulo.Saldo);

            Console.WriteLine("TENTATIVA DE SAQUE :" );
            Paulo.Sacar(1000);
            Console.WriteLine("TOTAL DE SALDO :" + Paulo.Saldo);

            Conta Joao = new Conta();


            Joao.Cliente.Nome = "João";
            Joao.Cliente.Cpf = "547.736.874 - 73";
            Joao.Agencia = 866;
            Joao.NumeroConta = 8669473;


            Console.WriteLine("Nome do Cliente: " + Joao.Cliente.Nome);
            Console.WriteLine("Saldo do Cliente : " + Joao.Cliente.Id);







            Console.ReadLine();
        }
    }
}
