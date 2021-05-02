using System;

namespace Calculadora_de_peso_ideal
{
    class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            double h, pesoIdeal;

            Console.WriteLine("Calculadora de peso ideal iniciada\n");
            
            Console.Write("Digite seu sexo (M/F): ");
            escolha = char.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            h = double.Parse(Console.ReadLine());

            if(escolha == 'm' || escolha == 'M'){
                pesoIdeal = (72.7 * h) - 58;
                Console.WriteLine($@"Seu peso ideal é {pesoIdeal.ToString("N2")}
Programa encerrado.");

            } else if(escolha == 'f' || escolha == 'F'){
                pesoIdeal = (62.1 * h) - 44.7;
                Console.WriteLine($@"Seu peso ideal é {pesoIdeal.ToString("N2")}
Programa encerrado.");

            } else {
                Console.WriteLine($@"{escolha} não é um sexo
Programa encerrado.");
            }

        }
    }
}
