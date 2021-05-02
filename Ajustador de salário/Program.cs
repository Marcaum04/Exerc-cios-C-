using System;

namespace Ajustador_de_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioAjustado, ajuste;


            Console.WriteLine("Ajustador de salário iniciado\n");
            
            Console.Write("Qual o valor do seu salário atual: ");
            salario = double.Parse(Console.ReadLine());

            if(salario < 500){
                ajuste = salario * 0.15;
                salarioAjustado = salario * 1.15;
                Console.WriteLine("Seu salário teve um ajuste de 15% e foi aumentado em {0:C2}.", ajuste);
                Console.WriteLine("O seu salário atual agora é de {0:C2}.", salarioAjustado);
            }
            else if(salario >= 500 && salario <= 1000){
                ajuste = salario * 0.1;
                salarioAjustado = salario * 1.1;
                Console.WriteLine("Seu salário teve um ajuste de 10% e foi aumentado em {0:C2}.", ajuste);
                Console.WriteLine("O seu salário atual agora é de {0:C2}.", salarioAjustado);
            }
            else{
                ajuste = salario * 0.05;
                salarioAjustado = salario * 1.05;
                Console.WriteLine("Seu salário teve um ajuste de 5% e foi aumentado em {0:C2}.", ajuste);
                Console.WriteLine("O seu salário atual agora é de {0:C2}.", salarioAjustado);
                Console.WriteLine("Programa finalizado.");
            }
        }
    }
}
