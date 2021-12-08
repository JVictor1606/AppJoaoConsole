using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class Funcionario
    {
       
        public int Id {  get;  set; }

        public virtual string SetId(string id)
        {
          id = Guid.NewGuid().ToString();
            
            return id;
        }
        public string Cpf { get; set; }
        public string Nome {  get; set; }
        public string Endereco {  get; set; }
    }
}
