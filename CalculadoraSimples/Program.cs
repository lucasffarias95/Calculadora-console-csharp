using System;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, essa é uma calculadora simples");
            int opcao = -1;
            double numero1, numero2;

            while (opcao != 0)
            {
                Console.WriteLine(" -- Escolha a operaçao -- ");
                Console.WriteLine("-- Opcao 0 - Sair -- ");
                Console.WriteLine("-- Opçao 1 - Somar --");
                Console.WriteLine("-- Opçao 2 - Subtrair --");
                Console.WriteLine("-- Opçao 3 - Multiplicar --");
                Console.WriteLine("-- Opçao 4 - Dividir --");

                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Resultado: {numero1 + numero2}");
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Resultado: {numero1 - numero2}");
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Resultado: {numero1 * numero2}");
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número:");
                        numero1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número:");
                        numero2 = double.Parse(Console.ReadLine());

                        if (numero2 == 0)
                        {
                            Console.WriteLine("Nao é possivel dividir por zero");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {numero1 / numero2}");
                        }
                        break;
                    case 0:
                        Console.Write("Encerrando a calculadora..");
                        break;

                    default:
                        Console.WriteLine("Opcao inválida");
                        break;
                }
            }
        }
    }
}

