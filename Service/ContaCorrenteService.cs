using Banco_desafio.Model;
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

            ContaCorrente conta = new ContaCorrente()
            {
                Titular = nome,
                Agencia = 003,
                Numero = 4823,
                Saldo = 5000,
                CodigoBanco = 1
            };

            Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}! Seu saldo é de R${conta.Saldo}");

            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            conta.Saldo = Sacar(valor, conta.Saldo);
            Console.WriteLine($"Obrigado pela preferência, {conta.Titular}");
            Console.WriteLine($"Seu saldo atual é de R${conta.Saldo}!");
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();

            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            ContaCorrente conta = new ContaCorrente()
            {
                Titular = nome,
                Agencia = 003,
                Numero = 4823,
                Saldo = 5000,
                CodigoBanco = 1
            };

            Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}! Seu saldo é de R${conta.Saldo}");

            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            conta.Saldo = Depositar(valor, conta.Saldo);

            Console.WriteLine($"Obrigado pela preferência, {conta.Titular}");
            Console.WriteLine($"Seu saldo atual é de R${conta.Saldo}!");
        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine();

            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            ContaCorrente conta = new ContaCorrente()
            {
                Titular = nome,
                Agencia = 003,
                Numero = 4823,
                Saldo = 5000,
                CodigoBanco = 1
            };

            Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}! Seu saldo é de R${conta.Saldo}");

            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            ContaCorrente contaDestino = new ContaCorrente()
            {
                Titular = nome,
                Agencia = 003,
                Numero = 4823,
                Saldo = 1000,
                CodigoBanco = 1
            };

            conta.Saldo = Transferir(valor, conta.Saldo, contaDestino);
            Console.WriteLine($"Obrigado pela preferência, {conta.Titular}");
            Console.WriteLine($"Seu saldo atual é de R${conta.Saldo}!");
        }

        private double Sacar(double valor, double saldo)
        {

            if (saldo < valor)
            {
                Console.WriteLine($"Não é possível sacar R${valor}, seu saldo é de apenas R${saldo}!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Operação realizada com sucesso!");
            }

            return saldo;
        }

        private double Depositar(double valor, double saldo)
        {
            saldo += valor;
            Console.WriteLine($"Operação realizada com sucesso!");

            return saldo;
        }

        private double Transferir(double valor, double saldo, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"Não é possível transferir R${valor}, seu saldo é de apenas R${saldo}!");
            }
            else
            {
                saldo -= valor;
                contaDestino.Saldo = Depositar(valor, contaDestino.Saldo);
            }

            return saldo;
        }
    }
}
