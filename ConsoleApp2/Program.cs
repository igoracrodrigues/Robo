using System;
namespace Robo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            while (true)
            {
                Console.WriteLine("Robo Tupiniquim");

                Console.WriteLine();

                Console.WriteLine("Digite E para virar o robô 90 graus para a esquerda: ");

                Console.WriteLine("Digite D para virar o robô 90 graus para a direita: ");

                Console.WriteLine("Digite M para mover o robô para frente: ");

                Console.WriteLine("Digite S para sair: ");

                opcao = Console.ReadLine();

                if (opcao !="E" && opcao !="D"
                    && opcao !="M" && opcao !="S") 
                {


                
                
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Comando Inválido! Tente novamente.");

                    Console.ResetColor();

                    Console.ReadLine();

                    Console.Clear();

                    continue;

                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                float primeiraLetra, segundaLetra;

                Console.Write("Digite uma letra de direção: ");
                primeiraLetra = Convert.ToChar(Console.ReadLine());

                do
                {
                    Console.Write("Digite outra letra de direção: ");
                    segundaLetra = Convert.ToChar(Console.ReadLine());

                    if (opcao == "m" && segundaLetra == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Comando Inválido! Tente novamente.");

                        Console.ResetColor();

                        Console.ReadLine();

                    }

                } while (opcao == "m" && segundaLetra == 0);

                double resultado = 0;

                string direcao = "";

                switch(opcao)
                {
                    case "1":
                        resultado = primeiraLetra + segundaLetra;
                        direcao = "X";
                        break;

                    case "2":
                        resultado = primeiraLetra + segundaLetra;
                        direcao = "Y";
                        break;

                    case "3":
                        resultado = primeiraLetra + segundaLetra;
                        direcao = "Z";
                        break;

                    default:
                        break;
                }

                string movimentosRealizados =
                    primeiraLetra.ToString() + " " + direcao + " " +
                    segundaLetra.ToString() + " = " + resultado.ToString();

                Console.WriteLine(resultado);

                Console.WriteLine();

                Console.WriteLine(movimentosRealizados);

                Console.ReadLine();

                Console.Clear();

                      
            
            }
        }
    }
}


    


