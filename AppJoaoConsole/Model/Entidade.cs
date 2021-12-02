using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public abstract class Entidade
    {
        public string Id { get; private set; }

        public Entidade()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
