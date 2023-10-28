using System;

    namespace MeuProjeto {
           class Program
        {
                static void Main(string[] args)
            {
                    while (true) {
                Console.WriteLine("Calculadora Simples:");
                Console.WriteLine("Escolha uma operação");

                Console.WriteLine("1. Adição ");
                Console.WriteLine("2. Subtração ");
                Console.WriteLine("3. Multiplicação ");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");

                Console.WriteLine("Opção:");

                int escolha = int.Parse(Console.ReadLine());

                    if(escolha == 5) 
                {
                    Console.WriteLine("Encerrando a calculadora.");
                    break;
                }
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                    switch (escolha)
                    {
                        case 1:
                        resultado = num1 + num2;
                        break;

                        case 2:
                        resultado = num1 - num2;
                        break;

                        case 3:
                        resultado = num1 * num2;
                        break;

                        case 4:
                        if (num2 != 0)
                            resultado = num1 / num2;

                        else
                            Console.WriteLine("Erro: Divisão por zero.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;


                }
                    Console.WriteLine($"Resultado: {resultado}\n\n");
            }

            }
        }
    }