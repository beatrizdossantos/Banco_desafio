using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_desafio.Model
{
    class ContaBase
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Titular { get; set; }
    }
}
