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
            ComponentesTela ct = new ComponentesTela();
            ct.ExibirTopo();
            ComponentesTela quebra = new ComponentesTela();

            Conta contaAngela = new Conta();
            contaAngela.Cliente.Nome = "Angela";
            contaAngela.Agencia = 546;
            contaAngela.NumeroConta = 546849;
      
            Caixa caixaJoao = new Caixa();      
            caixaJoao.Depositar(100);
            caixaJoao.Sacar(200);  

            ct.QuebraLinha();
            Gerente carlos = new Gerente("745.647.753-99");
            carlos.Nome = "Carlos";
            carlos.Salario = 5000;
            Console.WriteLine("Nome do Gerente : " + carlos.Nome);
            Console.WriteLine("A bonificacao do gerente é : " + carlos.Bonificacao());
            Console.WriteLine("O Aumento do gerente é : " + carlos.Aumento());

            ct.QuebraLinha();
            Gerente sousa = new Gerente("598.457.264-22");
            sousa.Nome = "Sousa";
            sousa.Salario = 4500;
            Console.WriteLine("Nome do Gerente : " + sousa.Nome);
            Console.WriteLine("A bonificacao do gerente é : " + sousa.Bonificacao());
            Console.WriteLine("O Aumento do gerente é : " + sousa.Aumento());
            sousa.GetSalaraio();


            Console.ReadLine();
        }
    }
}
