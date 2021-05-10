using System;

namespace Verfifcador_de_números
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUm, numeroDois;

            Console.WriteLine("Verificador de números iniciado\n");

            Console.Write("Digite o primeiro número: ");
            numeroUm = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numeroDois = double.Parse(Console.ReadLine());

            if(numeroUm == numeroDois){
                double soma;
                soma = numeroUm + numeroDois;
                Console.WriteLine("\nNumeros iguais somando...");
                Console.WriteLine($"Resultado igual {soma}");
            }else{
                double subtracao;
                subtracao = numeroUm - numeroDois;
                Console.WriteLine("\nNumeros diferentes subtraindo...");
                Console.WriteLine($"Resultado igual = {subtracao}");
            }

            Console.WriteLine("\nPrograma finalizado");
        }
    }
}
