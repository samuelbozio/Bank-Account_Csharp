using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCÍCIO_1
{
    internal class Conta
    {

        public int numero_conta { get; }
        public string nome_titular { get; private set; }
        public double saldo { get; private set; }
        public double deposito_inicial { get; private set; }

        public Conta(int numero_conta, string nome_titular, double saldo)
        {
            this.numero_conta = numero_conta;
            this.nome_titular = nome_titular;
            this.saldo = saldo;
            
        }

    

        public void Saque(double valor)
        {
            if (saldo >= (valor + 5))
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            
            }
        }

        public void Deposito(double valor)
        {
            saldo += valor;
           
        }

        public override string ToString()
        {
            return numero_conta +  ", " + nome_titular + ", " + saldo;
        }

    }

    }

