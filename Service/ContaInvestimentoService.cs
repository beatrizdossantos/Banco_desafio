using Banco_desafio.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Banco_desafio.Service
{
    class ContaInvestimentoService : IContaInvestimentoService
    {
        public void OperacaoInvestimento()
        {
            Console.WriteLine();

            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            ContaInvestimento conta = new ContaInvestimento()
            {
                Titular = nome,
                Agencia = 003,
                Numero = 4823,
                Saldo = 5000
            };

            Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}! Seu saldo é de R${conta.Saldo}");

            Console.WriteLine("Informe o valor que deseja investir: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            conta.Saldo = Investir(valor, conta.Saldo);

            string saldoFormatado = conta.Saldo.ToString("#.00", CultureInfo.InvariantCulture);

            Console.WriteLine($"Obrigado pela preferência, {conta.Titular}");
            Console.WriteLine($"Seu saldo atual é de R${saldoFormatado}!");
        }

        private double Investir(double valor, double saldo)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"Não é possível investir R${valor}, seu saldo é de apenas R${saldo}!");
            }
            else
            {
                saldo -= valor;

                Random random = new Random();
                var porcentagem = random.NextDouble();

                var valorObtido = (porcentagem * valor);
                saldo += valorObtido + valor;

                string valorFormatado = valor.ToString("#.00", CultureInfo.InvariantCulture);
                string valorObtidoFormatado = valorObtido.ToString("#.00", CultureInfo.InvariantCulture);

                Console.WriteLine($"Você investiu R${valorFormatado} e ganhou R${valorObtidoFormatado}!");
            }
            return saldo;
        }
    }
}
