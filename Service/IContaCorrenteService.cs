using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_desafio.Service
{
    interface IContaCorrenteService
    {
        public void OperacaoSaque();
        public void OperacaoDeposito();
        public void OperacaoTransferencia();
    }
}
