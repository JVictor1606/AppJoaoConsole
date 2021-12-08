using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    internal class Conta 
    {

        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public Cliente Cliente { get; set; }

        public string Id { get; set; }

        public Conta()
        {
            Cliente = new Cliente();
        }


        public  string SetId(string id)
        {
            id = Guid.NewGuid().ToString();
            Id = id;
            return id;
        }

        public string GetId()
        {
            return Id;
        }
    }
}