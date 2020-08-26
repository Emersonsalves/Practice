using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void pratica1()
        {
            //criando um array com dados prontos e usando os laços de repetição for e foreach

            int[] numbers = {1,2,6,7,9,10};
        
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.Write(numbers[i]);
            
            }
                System.Console.WriteLine("\n");
            foreach (int n in numbers)
            {
                System.Console.Write(n); 
            }    
        
        }

        static void pratica2()
        {
            // Criando um array com dados prontos e imprimindo seus elementos

            int[] array = {2, 4, 6, 3, 5, 9 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void pratica3()
        {
            //criando um array com dados fornecidos e imprimindo os mesmos

            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

                Console.WriteLine();

            //for (int i = 0; i < array.Length; i++)
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
            //{
                //Console.WriteLine("Posição {0}: {1}", i, array[i]);
                
            //}    
        }

        static void pratica4()
        {
            //lendo um array pronto de 6 posições e imprimindo o elemento da posição 3
            int[] numeros_loteria = new int[6] {2, 23, 34, 12, 29, 44};
            int valor;
            valor = numeros_loteria[3];
            Console.WriteLine("O elemento é {0}", valor.ToString());
        }

        static void pratica5()
        {
            //mesmo exercício anterior porém lendo uma posição do array informada pelo usuário
            //lendo um array pronto de 6 posições e imprimindo o elemento da posição 4 alterado pelo usuário
            int[] numeros_loteria = new int[6] {2, 23, 34, 12, 29, 44};
            int valor;
            Console.WriteLine("Digite um valor");
            valor = Convert.ToInt32(Console.ReadLine());
            numeros_loteria[4] = valor;
            Console.WriteLine("O elemento é {0}", valor.ToString());
        }

        static void pratica6()
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

        static void pratica7()
        {
            // utilização o laço de repetição FOR vai imprimir os números de 1 a 50
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void pratica8()
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

        static void pratica9()
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

        static void pratica10()
        {
            // Utilizando o Bloco Try...Catch
            int n1, n2, res;
            res = n1 = n2 = 0;
            
            n1 = 10;
            n2 = 0;
            try
            {
               res = n1/n2;
               Console.WriteLine("{0}/{1} = {2}", n1, n2, res); 
            }
            //catch
            catch(Exception e)
            {
              //Console.WriteLine("ERRO");
              Console.WriteLine("ERRO : {0}", e.Message);            
            }
        }

        static void pratica11() //Colocando elementos de um Array em ordem crescente
        {
            int[] grades = {37, 42, 15, 2, 5, 23};
            Array.Sort(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        static void pratica12() //Colocando elementos de um Array em ordem decrescente
        {
            int[] grades = {37, 42, 15, 2, 5, 23};

            Console.WriteLine();

            Array.Sort(grades);
            Array.Reverse(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        static void pratica13() //Colocando elementos de um Array de trás para frente
        {
            int[] grades = {37, 42, 15, 2, 5, 23};
            Array.Reverse(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        static void pratica14() //Verifica se os elementos de dois arrays são iguais e imprime a mensagem
        {
            int[] grades1 = {37, 42, 15, 2, 5, 23};
            int[] grades2 = {37, 42, 15, 2, 5, 23};

            if (Enumerable.SequenceEqual(grades1,grades2))
            {
                Console.WriteLine("Os valores dos Arrays são iguais");
            }
            else
            {
                Console.WriteLine("Os valores dos Arrays não são iguais");
            }
            
        }

        static void pratica15() //Procura por um elemento dentro de um array e informa na tela
        {
            int[] grades = {37, 42, 15, 2, 5, 23};
            bool found = false;

            for (int i = 0; i < grades.Length; i++)
            {
                if(grades[i] == 25)
                {
                    Console.WriteLine("Encontrado!");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Não encontrado!");
            }
        }
        static void Main(string[] args)=> pratica15();
        

        
    }
}