using Banco_desafio.Service;
using System;

namespace Banco_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exibe menu de opções para o usuário selecionar

            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Investimento");

            // obtem a opção selecionada pelo usuário
            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new ContaCorrenteService().OperacaoDeposito();
                    break;

                case '2':
                    new ContaCorrenteService().OperacaoSaque();
                    break;

                case '3':
                    new ContaCorrenteService().OperacaoTransferencia();
                    break;
                case '4':
                    new ContaInvestimentoService().OperacaoInvestimento();
                    break;
            }
        }
    }
}
