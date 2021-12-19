using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class Conta : Entidade 
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public Cliente Cliente { get; set; }

        public Conta()
        {
            Cliente = new Cliente();
        }      
    }
}