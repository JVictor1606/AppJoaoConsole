﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJoaoConsole.Model
{
    public class Cliente : Funcionario
    {
        public int NumeroDeIdentificacao { get; set; }

        public Caixa Caixa { get; set; }
    }
}
