using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        //método construtor da classe (tem o mesmo nome da classe). 
        public Operacoes()
        {

        }

        //public = modificador
        //double  tipo de retorno
        //somaValor = nome do metodo
        //double v1 e v2 = parâmetros
        //double (p) = tipo
        //v1 / v2 = nome
        public double somaValor(double v1, double v2) // <-- assinatura do método (o que ele precisa para ser usado quando for acionado)
        {
            return (v1 + v2);
        }
        public double subtraiValor(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double multiplicaValor(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double divideValor(double v1, double v2)
        {
            return (v1 / v2);
        }
    }
}
