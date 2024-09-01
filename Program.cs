using System;

namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Bem Vindo a Calculadora!");
            Thread.Sleep(1000);
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Potencia");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma opção: ");
            short operador = short.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Resto(); break;
                case 6: Potencia(); break;
                case 0: System.Environment.Exit(0); break;
                default: 
                    Console.WriteLine("Digite um operador válido!!!");
                    Thread.Sleep(2000);
                    Menu();
                break;
            }

        }
        static void Soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float r = v1 + v2;

            Console.WriteLine($"O resultado da soma é {r}");
            Thread.Sleep(2000);

            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float r = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {r}");
            Thread.Sleep(2000);
            
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float r = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {r}");
            Thread.Sleep(2000);

            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (v2 == 0) {
                Console.WriteLine("Não é possível dividir por zero.");
                Thread.Sleep(1000);
                Menu();
            }
            else {
                float r = v1 / v2;

                Console.WriteLine($"O resultado da divisão é {r}");
                Thread.Sleep(2000);

                Menu();
            }
        }

        static void Resto()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (v2 == 0) 
            {
                Console.WriteLine("Não é possível dividir por zero.");
                Thread.Sleep(1000);
                
                Menu();
            }
            else {
                float r = v1 % v2;

                Console.WriteLine($"O resto da divisão é {r}");
                Thread.Sleep(2000);

                Menu();
            }

        }

        static void Potencia()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            double r = Math.Pow(v1, v2);

            Console.WriteLine($"O resultado de {v1} elevado a {v2} é {r}");
            Thread.Sleep(2000);

            Menu();
        }
    }
}