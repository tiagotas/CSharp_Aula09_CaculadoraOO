using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09_CaculadoraOO
{
    class FazOperacoesComParametros
    {

        /*
         * Declaração dos métodos
         */
        public void Adicao(double _primeiro_numero, double _segundo_numero)
        {
            double resultado = _primeiro_numero + _segundo_numero;

            Console.WriteLine("O resultado da adição é {0}", resultado);
        }

        public void Subratracao(double _primeiro_numero, double _segundo_numero)
        {
            double resultado = _primeiro_numero - _segundo_numero;

            Console.WriteLine("O resultado da subtracao é {0}", resultado);
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
