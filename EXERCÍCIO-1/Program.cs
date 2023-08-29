using EXERCÍCIO_1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Conta conta;
            Console.WriteLine("CADASTRO DE CONTAS: ");
            Console.WriteLine("Entre com o número da conta: ");
            int numero_conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular: ");
            string nome_titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? [S/N] ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S')
            {
                Console.WriteLine("Informe o depósito inicial: ");
                double dep_inicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero_conta, nome_titular, dep_inicial); 
               
            } else
            {
                conta = new Conta(numero_conta, nome_titular, 0.0);
            }
            
            Console.WriteLine(conta.ToString());
            conta.Saque(100);
            Console.WriteLine(conta.ToString());
            conta.Deposito(100);
            Console.WriteLine(conta.ToString());




        }
    }
}