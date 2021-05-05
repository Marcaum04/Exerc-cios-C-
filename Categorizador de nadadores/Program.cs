using System;

namespace Categorizador_de_nadadores
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.WriteLine("Categorizador iniciado\n");
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            do
            {
            if (idade >= 5 && idade <= 7){
            Console.WriteLine(@"Você está na categoria Mini-Peixinhos 5 - 7 anos.
Porém devido a pandemia essa categoria está temporariamente encerrada.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 8 && idade <= 10){
            Console.WriteLine("Você está na categoria Peixinhos 8 - 10 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 11 && idade <= 13){
            Console.WriteLine("Você está na categoria Mini-Tubarões 11 - 13 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 14 && idade <= 17){
            Console.WriteLine("Você está na categoria Tubarões 14 - 17 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else if (idade >= 18){
            Console.WriteLine("Você está na categoria Mega-Tubarões maiores de 18 anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }
            else{
            Console.WriteLine("Você está não se enquadra em nenhuma categoria volte daqui alguns anos.");
            Console.WriteLine("\nCategorizador finalizado.");
            }

            } while (true);
            
                
        }
    }
}
