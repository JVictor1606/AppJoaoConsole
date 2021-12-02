using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Tipo { get; set; }
        
        public Cliente() 
        {

        }

        public Cliente(string Nome)
        {
            this.Nome = Nome;
        }

        public void ExibirCliente() 
        {
            Console.WriteLine("Nome: " + Nome);
        }
        
    }
}
