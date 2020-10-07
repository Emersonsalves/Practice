using System;
using System.Diagnostics;

namespace getting_started
{
    class SwitchCase
    {
        static void pratica1() // Utilizando o comando Switch case
        {
            int tempo=0;
            char escolha;

            Console.WriteLine("Blumenau/SC a Belo Horizonte/MG");
            Console.WriteLine("Escolha o meio de transporte: [a] Avião | [c] Carro | [o] Ônibus");
            
            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                tempo = 240;
                break;
                
                case 'c':
                case'C':
                tempo = 900;
                break;

                case 'o':
                case 'O':
                tempo = 1440;
                break;
                default:
                tempo = -1;
                break;
            }
            double horas = tempo/60;
            if (tempo<0)
            {
                Console.WriteLine("Transporte indisponível");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é de: {0} horas de viagem", horas);
            }

        }
        static void pratica2() // Utilizando o comando Switch case
        {
            string clima = "nublado";
            switch (clima)
            {
                case "chuvoso":
                Console.WriteLine("Vá brincar lá fora, o dia esta ensolarado.");
                break;
                case "nublado":
                Debug.WriteLine("Vá brincar lá fora, mas leve seu guarda-chuva, pois está nublado.");
                break;
                default:
                Console.WriteLine("Não foi possível determinar o clima.");
                break;
            }
        }

        static void pratica3()
        {
            int sorteio = 451876;
            switch (sorteio)
            {
                case 467681:
                Console.WriteLine("Você ganhou um celular.");
                break;
                case 451876:
                Console.WriteLine("Você ganhou um PS4.");
                break;
                case 742167:
                Debug.WriteLine("Desculpe, você não ganhou nada.");
                break;
                case 741963:
                Debug.WriteLine("Você ganhou um ingresso para o cinema.");
                break;
                default:
                Console.WriteLine("Desculpe, você não ganhou nada.");
                break;
            }
            Console.Read();
        }

        static void pratica4()
        {
            Console.WriteLine("Digite um número e tecle enter.");
            var number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                case 20:
                case 30:
                Console.WriteLine("O número é: " + number);
                break;
                default:
                Console.WriteLine("O número não é 10, 20 ou 30");
                break;
            }
            Console.ReadKey();
        }

        static void pratica5()
        {
            Console.WriteLine("Digite a nota do aluno (A,B,C,D ou F)");
            char nota = char.Parse(Console.ReadLine().ToUpper());

            switch(nota)
            {
                case 'A':
                    Console.WriteLine("Excelenete !");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Muito bem !");
                    break;
                case 'D':
                    Console.WriteLine("O aluno foi para recuperação.");
                    break;
                case 'F':
                    Console.WriteLine("O aluno foi Reprovado.");
                    break;
                default:
                    Console.WriteLine("Nota Inválida.");
                    break;
            }
            Console.WriteLine(" Nota do Aluno :  {0} ", nota);
            Console.ReadKey();
        }

        public enum Volume
        {
            Baixo,
            Medio,
            Indefinido,
            Alto
        }

        static void pratica6()
        {
           Volume volume = Volume.Alto;

            switch(volume)
            {
                case Volume.Baixo:
                    Console.WriteLine("O volume está baixo");
                    break;
                case Volume.Medio:
                    Console.WriteLine("O volume está médio");
                    break;
                case Volume.Alto:
                    Console.WriteLine("O volume está alto");
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }
            Console.ReadKey(); 
        }

        static void Main(string[] args)=> pratica6();
        
    }
}