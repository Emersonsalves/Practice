using System;
using System.Linq;

namespace getting_started
{
    class Loop
    {
        static void loop1()
        {
           //usando a estrutura de repetição while , esta estrutura de loop se repete até que a instrução
           // retorne False
           int i = 1;
           while (i <= 50)
           {
               Console.WriteLine(i);
               //desta forma vai criar um loop infinito então é necessário um contador para que
               // o valor chegue a 51 e desta forma retorne False
               i++;
           }
        }

        static void loop2()
        {
            // utilização o laço de repetição FOR vai imprimir os números de 1 a 50
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void loop3()
        {
            // utilizando o laço de repetição DO ao informar o número 10 encerra o programa
            int i;
            do
            {
                Console.WriteLine("Digite um número:");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}", i);
            } 
            while (i != 10);
           
        }

        static void loop4()
        {
            // Utilizando a declaração BREAK para encerrar um loop
            int numero;
            while (true)
            {
                Console.WriteLine("Digite um número; o número 15 encerra o loop");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 15)
                break;
                else
                    Console.WriteLine("Número digitado foi: {0}", numero);

            }
                Console.WriteLine("Esta mensagem aparece após o encerramento do loop");
        }


        static void Main(string[] args)=> loop1();
        
    }
}