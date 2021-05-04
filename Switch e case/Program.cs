using System;

namespace Switch_e_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, letra;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            letra = nome.Substring(0,1).ToLower();

            switch(letra){
                case "a":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Águia");    
                    break;
                case "b":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Banana");    
                    break;
                case "c":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Carro");    
                    break;
                case "d":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Dado");    
                    break;
                case "e":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Escola");    
                    break;
                case "f":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Furão");    
                    break;
                case "g":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Gato");    
                    break;
                case "h":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Horta");    
                    break;
                case "i":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Iguana");    
                    break;
                case "j":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Jade");    
                    break;
                case "k":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Kenan e kel");    
                    break;
                case "l":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Lebre");    
                    break;
                case "m":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Macaco");    
                    break;
                case "n":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Navio");    
                    break;
                case "o":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Olho");    
                    break;
                case "p":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Pato");    
                    break;
                case "q":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Queijo");    
                    break;
                case "r":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Rua");    
                    break;
                case "s":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Selva");    
                    break;
                case "t":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Trator");    
                    break;
                case "u":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Uva");    
                    break;
                case "v":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Vida");    
                    break;
                case "w":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Website");    
                    break;
                case "x":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Xuxa");    
                    break;
                case "y":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Youtuber");    
                    break;
                case "z":
                    letra.ToUpper();
                    Console.WriteLine(letra + " a primeira letra do seu nome também é a inicial de Zebra");    
                    break;
                
            }
        }
    }
}
