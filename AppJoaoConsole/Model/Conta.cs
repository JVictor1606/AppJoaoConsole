using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    internal class Conta : Funcionario 
    {
        public void Conta(string id, string name)
        {
            id = Guid.NewGuid().ToString();
            Id = Id;
        }
    }
}
