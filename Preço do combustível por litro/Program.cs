using System;

namespace Preço_do_combustível_por_litro
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasolina, alcool, capacidadeTanque, precoGasolina, precoAlcool;
            char combustivel;

            Console.WriteLine("Programa de preço do combustível iniciado\n");

            Console.Write("Digite o tipo do combustível que quer usar para abastecer Gasolina(G) ou Álcool(A): ");
            combustivel = char.Parse(Console.ReadLine());
            
            Console.Write("Digite a capacidade de litros do seu tanque de combustível: ");
            capacidadeTanque = double.Parse(Console.ReadLine());

            gasolina = 5.16;
            alcool = 3.29;

            if(combustivel == 'G' || combustivel == 'g'){
                precoGasolina = gasolina * capacidadeTanque;
                Console.WriteLine("Você tem que pagar {0:C2} ao frentista", precoGasolina);
                Console.WriteLine("Programa encerrado.");
                
            } else if(combustivel == 'A' || combustivel == 'a'){
                precoAlcool = alcool * capacidadeTanque;
                Console.WriteLine("Você tem que pagar {0:C2} ao frentista", precoAlcool);
                Console.WriteLine("Programa encerrado.");
            } else{
                Console.WriteLine("Combustível não existente.");
            }
            
        }
    }
}
