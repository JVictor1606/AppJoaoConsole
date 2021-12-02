using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class ContaBancaria
    {
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }


    }
}
