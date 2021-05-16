using System;

namespace Comparador_de_números
{
    class Program
    {
        static void Main(string[] args)
        {
           double numeroUm, numeroDois;

           Console.Write(@"
_______________________________________
|| Bem-vindo ao comparador de números||
|| Digite o primeiro número: ");
           numeroUm = double.Parse(Console.ReadLine());

           Console.Write("|| Digite o segundo número: ");
           numeroDois = double.Parse(Console.ReadLine());

           if(numeroUm == numeroDois){
               double soma = numeroUm + numeroDois;
               Console.WriteLine($@"
___________________________________________________________________
|| Os dois números que você digitou são iguais então eu os somei ||
||              O resultado dessa soma é {soma}
||_______________________________________________________________||");
           }else{
               double subtracao = numeroUm - numeroDois;
               Console.WriteLine($@"
_________________________________________________________________________
|| Os dois números que você digitou são diferentes então eu os subtrai ||
||              O resultado dessa subtracao é {subtracao}
||_____________________________________________________________________||");
           }
        }
    }
}
