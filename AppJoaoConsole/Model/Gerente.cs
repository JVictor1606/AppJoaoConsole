using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class Gerente : Funcionario, Ibonificacao
    {
        public Gerente(string cpf)   
        {
            Console.WriteLine("O cpf do gerente é : " + cpf);
        }
        public double Bonificacao()
        {   
            return Salario* 0.16;
        }
        public double Aumento()
        {
            return Salario += Salario * 0.2;
        }
        public void GetSalaraio()
        {
            Console.WriteLine("O seu salario atua é : " + Salario);
        }
    }
}
