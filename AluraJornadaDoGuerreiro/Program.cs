using System;

class Program{

    static void Main() {

        int energia = 100;
        string escolhas;
        bool continuar = true;

        do
        {

            Console.WriteLine("1 - Procura inimigos");
            Console.WriteLine("2 - Ver energia");
            Console.WriteLine("3 - Sair da floresta");
            Console.Write("Escolha uma opção: ");

            escolhas = Console.ReadLine()!;

            switch (escolhas)
            {
                case "1":
                    Console.WriteLine("Você encontrou um inimigo");
                    energia -= 25;
                    Console.WriteLine($"Energia atual:{energia}");
                    break;
                case "2":
                    if (energia >= 50)
                    {
                        Console.WriteLine("Você ainda esta forte ");

                    }
                    else
                    {
                        Console.WriteLine("Você esta cansado! Precisa descansar.");
                    }
                    break;

                case "3":
                    continuar = false;
                    Console.WriteLine("Você saiu da floresta com segurança");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;

            }

        } while (continuar);
    }

 }