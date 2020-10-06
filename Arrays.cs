using System;
using System.Linq;

namespace Practice
{
    class Arrays
    {
        static void array1()
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

        static void array2()
        {
            // Criando um array com dados prontos e imprimindo seus elementos

            int[] array = {2, 4, 6, 3, 5, 9 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void array3()
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

        static void array4()
        {
            //lendo um array pronto de 6 posições e imprimindo o elemento da posição 3
            int[] numeros_loteria = new int[6] {2, 23, 34, 12, 29, 44};
            int valor;
            valor = numeros_loteria[3];
            Console.WriteLine("O elemento é {0}", valor.ToString());
        }

        static void array5()
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

        static void array6() //Colocando elementos de um Array em ordem crescente
        {
            int[] grades = {37, 42, 15, 2, 5, 23};
            Array.Sort(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        static void array7() //Colocando elementos de um Array em ordem decrescente
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

        static void array8() //Colocando elementos de um Array de trás para frente
        {
            int[] grades = {37, 42, 15, 2, 5, 23};
            Array.Reverse(grades);

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        static void array9() //Verifica se os elementos de dois arrays são iguais e imprime a mensagem
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

        static void array10() //Procura por um elemento dentro de um array e informa na tela
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

        static void Main(string[] args)=> array10();       

        
    }
}