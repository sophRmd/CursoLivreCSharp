using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Conta
    {
        //usado para preservar a lógica
        //quando utiliza-se private ou protected, usa-se os métodos acessores get()(lê) e set()(escreve)
        private double saldo;
        private double valor;
        private int numeroConta;

        public double Saldo { get => saldo; set => saldo = value; }
        public double Valor { get => valor; set => valor = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }

        //public double getValor() //não necessita de parâmetro mas precisa de retorno
        //{
        //    return this.valor; //this é apontar para a classe ou variável
        //}

        //public void setValor(double valor) //não precia de retorno mas precisa de parâmetro
        //{
        //    this.valor = valor;
        //}

        public double depositar(double valor)
        {
            this.saldo = this.valor + valor;
            return this.saldo;
        }
        public void sacar()
        {

        }
        public void transferir()
        {

        }
    }
}
