using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class Cliente : Entidade

    {       
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
         
        public Cliente()
        {
            
        }         
}

