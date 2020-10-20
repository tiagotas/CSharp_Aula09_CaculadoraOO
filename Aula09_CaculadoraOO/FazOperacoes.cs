using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09_CaculadoraOO
{
    /**
     * Declaração da classe
     */ 
    public class FazOperacoes
    {
        /**
         * Declaração dos Atributos
         */ 
        public double primeiro_numero;
        public double segundo_numero;

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
