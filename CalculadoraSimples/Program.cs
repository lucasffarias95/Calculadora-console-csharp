using System;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, esta é uma calculadora simples");
            int opcao = -1;
            double numero1, numero2;

            while (opcao != 0)
            {
                Console.WriteLine(" -- Escolha a Operação -- ");
                Console.WriteLine("-- Opção 0 - Sair -- ");
                Console.WriteLine("-- Opção 1 - Somar --");
                Console.WriteLine("-- Opção 2 - Subtrair --");
                Console.WriteLine("-- Opção 3 - Multiplicar --");
                Console.WriteLine("-- Opção 4 - Dividir --");

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
                            Console.WriteLine("Não é possivel dividir por zero");
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
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}

