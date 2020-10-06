using System;
using System.Linq;

namespace Practice
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
        static void Main(string[] args)=> pratica1();
        
    }
}