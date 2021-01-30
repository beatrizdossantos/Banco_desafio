using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_desafio.Model
{
    class ContaInvestimento : ContaBase
    {
        // Também possui todos os atributos da conta base, já que herda dela
        public string TipoInvestimento { get; set; }

        public class Investimento
        {
            public double ValorInvestir { get; set; }
            public double ValorRetorno { get; set; }
        }
    }
}
