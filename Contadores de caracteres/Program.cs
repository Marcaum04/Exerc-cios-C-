using System;

namespace Contadores_de_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {

            string fraseUm, fraseDois;
            int tamanhoFraseUm, tamanhoFraseDois;

            Console.Write(@"
_________________________________________
|| Bem-vindo ao contador de caracteres ||
||_____________________________________||
|| Digite uma frase: ");
        fraseUm = Console.ReadLine();
        tamanhoFraseUm = fraseUm.Length;
        Console.Write("|| Digite outra frase: ");
        fraseDois = Console.ReadLine();
        tamanhoFraseDois = fraseDois.Length;
        Console.Write("||_____________________________________||");
        
        if(tamanhoFraseUm > tamanhoFraseDois){
            Console.Write($@"
___________________________________________________
|| A primeira frase {fraseUm}
|| Tem {tamanhoFraseUm} caracteres
||_________________________________________________
|| A segunda frase {fraseDois}
|| Tem {tamanhoFraseDois} caracteres
||_________________________________________________
|| A frase com mais caracteres é a primeira frase 
|| com {tamanhoFraseUm} caracteres
||_________________________________________________");
        }else if(tamanhoFraseUm < tamanhoFraseDois){
             Console.Write($@"
___________________________________________________
|| A primeira frase {fraseUm}
|| Tem {tamanhoFraseUm} caracteres
||_________________________________________________
|| A segunda frase {fraseDois}
|| Tem {tamanhoFraseDois} caracteres
||_________________________________________________
|| A frase com mais caracteres é a segunda frase 
|| com {tamanhoFraseDois} caracteres
||_________________________________________________");
        } else{
             Console.Write($@"
___________________________________________________
|| A primeira frase {fraseUm}
|| Tem {tamanhoFraseUm} caracteres
||_________________________________________________
|| A segunda frase {fraseDois}
|| Tem {tamanhoFraseDois} caracteres
||_________________________________________________
|| As duas frases tem o mesmo tanto de caracteres 
|| com {tamanhoFraseUm} caracteres
||_________________________________________________");
        }
        }
    }
}
