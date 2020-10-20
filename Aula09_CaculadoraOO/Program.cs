using System;

namespace Aula09_CaculadoraOO
{
    class Program
    {
        static void Main(string[] args)
        {
            FazOperacoes op = new FazOperacoes();

            op.primeiro_numero = 5;
            op.segundo_numero = 3;

            op.Adicao();
            op.Subratracao();
            op.Multiplicacao();
            op.Divisao();

            Console.WriteLine("_________________________________________________");

            /**
             * Passando os valores para o método construtor no momento da criação do
             * objeto. Sem os dois valores o objeto não poderá ser criado.
             */ 
            FazOperacoesComConstrutor op2 = new FazOperacoesComConstrutor(5, 3);

            op2.Adicao();
            op2.Subratracao();
            op2.Multiplicacao();
            op2.Divisao();


            Console.WriteLine("_________________________________________________");

            // Qual é a diferença entre Parâmetro e Argumento?
            // R: O parâmetro é declarado no método, ex: _n1, _primeiro_numero e funciona
            //    como uma variável, já o argumento é o valor do parâmetro, passado quando
            //    chamamos esse método que possui parametro.

            FazOperacoesComParametros op3 = new FazOperacoesComParametros();

            op3.Adicao(5, 3); // Passagem de dois argumentos para o método Adicao.
            op3.Multiplicacao(10, 30);
            op3.Adicao(66, 1);


            Console.WriteLine("_________________________________________________");

            FazOperacoesComRetorno op4 = new FazOperacoesComRetorno();

            // Neste exemplo o método Adicao retorna um valor, isso significa que não
            // necessariamente o método mostratá uma mensagem na tela, mas sim disponibilizará
            // um retorno para que possamos trabalhar com ele, mostrando na tela ou fazendo
            // outras operações, por exemplo.
            double res_adicao = op4.Adicao(10, 10);
            Console.WriteLine("O retorno do método adição foi {0}", res_adicao);

            // Aqui pegamos o retorno do método substração é já mostramos na tela diretamente
            // através do uso do marcador.
            Console.WriteLine("O retorno do método subtração foi {0}", op4.Subratracao(63.5, 0.5));

            









            Console.ReadKey();
        }
    }
}
