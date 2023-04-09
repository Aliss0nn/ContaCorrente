using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{

    internal class ContaCorrente
    {
        public string nome;
        public int operacao;
        public int movimentacoes;        
        public int numeroDaConta = 0;
        public int saldo = 0;
        public bool ehEspecial = true;
        public int limite = 0;
        ArrayList movimentacoesEntreContas = new ArrayList();
        private string movOperacao;

        public ContaCorrente(string nome , int saldo , int limite , bool ehEspecial , int numeroDaConta)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.limite = limite;
            this.numeroDaConta = numeroDaConta;
            this.ehEspecial = ehEspecial;
        }

        public ContaCorrente()
        {
        }

        public void Movimentações(int quantidade, string nomeOperacao)
       
        {
            ContaCorrente movimentacao = new ContaCorrente();
            {
                movOperacao = nomeOperacao + " " + quantidade;

            }

            movimentacoesEntreContas.Add(movimentacao.movOperacao);


        }
             
        public void Deposito(int valor)
        {
            saldo += valor;
            Movimentações(valor, "Deposito + ");
        }

        public void Saque(int valor)
        {
            if (saldo > valor)
                return;
            saldo -= valor;


            Movimentações(valor, "Saque - ");
        }

        public int VisualizarSaldo()
        {
            return this.saldo;
        }

        public void Tranferencia(int valor, ContaCorrente valorEntrada)
        {
            if (saldo > valor)
                return;

            saldo -= valor;

            valorEntrada.saldo += valor;

            Movimentações(valor, "Tranferência - ");

            valorEntrada.Movimentações(valor, "Tranferência + ");

        }

        public void ExibirExtrato()
        {
            foreach (var item in movimentacoesEntreContas)
            {
                Console.WriteLine(item);
            }
        
        } 

    }
}
