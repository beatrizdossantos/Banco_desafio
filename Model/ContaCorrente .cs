using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_desafio.Model
{
    class ContaCorrente : ContaBase
    {
        // Também possui todos os atributos da conta base, já que herda dela
        public int CodigoBanco { get; set; }
    }
}
