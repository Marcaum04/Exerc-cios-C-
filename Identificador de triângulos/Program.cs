using System;

namespace Identificador_de_triângulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoUm, ladoDois, ladoTres;

            Console.Write(@"
_________________________________________________
||   Bem-Vindo ao identificador de triângulos  ||
||_____________________________________________||
||     Digite qual o tamanho dos lados do      ||
||      triângulo que deseja identifica        ||
|| Primeiro lado: ");
            ladoUm = double.Parse(Console.ReadLine());
            Console.Write("|| Segundo lado: ");
            ladoDois = double.Parse(Console.ReadLine());
            Console.Write("|| Terceito lado: ");
            ladoTres = double.Parse(Console.ReadLine());

            if (ladoUm == ladoDois && ladoDois == ladoTres && ladoTres == ladoUm)
            {
                Console.Write(@"
__________________________________________________________________
||   Seu triângulo é Equilátero – possui os três lados iguais   ||
||______________________________________________________________||
 ");
            }
            else if (ladoUm == ladoDois || ladoDois == ladoTres || ladoTres == ladoUm)
            {
                Console.Write(@"
__________________________________________________________________
||     Seu triângulo é Isósceles – possui dois lados iguais     ||
||______________________________________________________________||
 ");
            }else{
                Console.Write(@"
__________________________________________________________________
||  Seu triângulo é Escaleno – possui os três lados diferentes  ||
||______________________________________________________________||
 ");
            }
        }
    }
}
