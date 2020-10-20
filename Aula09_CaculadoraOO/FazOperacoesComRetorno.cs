using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09_CaculadoraOO
{
    class FazOperacoesComRetorno
    {
        /*
        * Declaração dos métodos
        */
        public double Adicao(double _primeiro_numero, double _segundo_numero)
        {
            double resultado = _primeiro_numero + _segundo_numero;

            return resultado;
        }

        public double Subratracao(double _primeiro_numero, double _segundo_numero)
        {
            double resultado = _primeiro_numero - _segundo_numero;

            return resultado;

            //Console.WriteLine("O resultado da subtracao é {0}", resultado);
        }

        public void Multiplicacao(double _primeiro_numero, double _segundo_numero)
        {
            double resultado = _primeiro_numero * _segundo_numero;

            Console.WriteLine("O resultado da mutiplicação é {0}", resultado);
        }

        public void Divisao(double _primeiro_numero, double _segundo_numero)
        {
            double resultado = _primeiro_numero / _segundo_numero;

            Console.WriteLine("O resultado da divisao é {0}", resultado);
        }
    }
}
