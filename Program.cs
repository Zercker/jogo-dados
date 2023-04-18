using System;

namespace JogoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo de dados!");

            Random random = new Random();

            Console.Write("Digite o nome do jogador 1: ");
            string jogador1 = Console.ReadLine();

            Console.Write("Digite o nome do jogador 2: ");
            string jogador2 = Console.ReadLine();

            int dadoJogador1 = random.Next(1, 7);
            int dadoJogador2 = random.Next(1, 7);

            Console.WriteLine($"{jogador1} jogou o dado e tirou {dadoJogador1}!");
            Console.WriteLine($"{jogador2} jogou o dado e tirou {dadoJogador2}!");

            if (dadoJogador1 > dadoJogador2)
            {
                Console.WriteLine($"{jogador1} venceu!");
            }
            else if (dadoJogador2 > dadoJogador1)
            {
                Console.WriteLine($"{jogador2} venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }
    }
}
