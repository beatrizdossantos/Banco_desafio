using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_desafio.Service
{
    class ContaCorrenteService : IContaCorrenteService
    {
        /// <summary>
        /// Nesta classe vamos manter todas as regras de negócio da nossa pequena aplicação
        /// </summary>
        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");


            // implemente a ação sacar aqui e exiba as informações para o usuário...
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");


            // implemente a ação depositar aqui e exiba as informações para o usuário...
        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");

            // implemente a ação transferir aqui e exiba as informações para o usuário
        }

        // criar os métodos Sacar, Depositar e Transferir como private
    }
}
