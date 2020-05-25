using System;

namespace Exercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];

            Console.WriteLine("Digite o número de estudantes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do estudante: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o email do estudante: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o quarto: ");
                int numero = int.Parse(Console.ReadLine());

                quartos[numero] = new Estudante { Nome = nome, Email = email, Quarto = numero };
            }

            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i].Quarto + ": " + quartos[i].Nome + "," + quartos[i].Email);
                }
            }

            Console.ReadKey();
        }
    }
}
