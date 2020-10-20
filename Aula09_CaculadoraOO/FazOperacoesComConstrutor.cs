using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09_CaculadoraOO
{
    class FazOperacoesComConstrutor
    {
        /**
         * Declaração dos Atributos
         */
        public double primeiro_numero;
        public double segundo_numero;


        /*
         * Construtor da classe com passagem de parâmetros (a passagem de parametros
         * é opcional, ou seja, não preciso necessariamente declarar parametros).
         */ 
        public FazOperacoesComConstrutor(double _n1, double _n2)
        {
            primeiro_numero = _n1;
            segundo_numero = _n2;

            //Console.WriteLine("Chamou o construtor no momento da criação do objeto.");
        }


        /*
         * Declaração dos métodos
         */
        public void Adicao()
        {
            double resultado = primeiro_numero + segundo_numero;

            Console.WriteLine("O resultado da adição é {0}", resultado);
        }

        public void Subratracao()
        {
            double resultado = primeiro_numero - segundo_numero;

            Console.WriteLine("O resultado da subtracao é {0}", resultado);
        }

        public void Multiplicacao()
        {
            double resultado = primeiro_numero * segundo_numero;

            Console.WriteLine("O resultado da mutiplicação é {0}", resultado);
        }

        public void Divisao()
        {
            double resultado = primeiro_numero / segundo_numero;

            Console.WriteLine("O resultado da divisao é {0}", resultado);
        }
    }
}
