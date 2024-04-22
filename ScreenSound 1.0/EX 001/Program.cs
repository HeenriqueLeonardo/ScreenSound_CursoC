// Jogo da Adivinhacão
Random gerador = new Random();
int numeroBot = gerador.Next(1, 100);
int numeroJogador = 0;
int tentativas = 0;
Console.WriteLine(@"
░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║███████║██║░░╚═╝███████║██║░░██║
██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══██║██║░░██╗██╔══██║██║░░██║
██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");

Console.WriteLine(@"
█▀▀ █▀█ █▀▄▀█ █▀█   █▀▀ █░█ █▄░█ █▀▀ █ █▀█ █▄░█ ▄▀█ ▀█
█▄▄ █▄█ █░▀░█ █▄█   █▀░ █▄█ █░▀█ █▄▄ █ █▄█ █░▀█ █▀█ ░▄

█▀█   ░░█ █▀█ █▀▀ ▄▀█ █▀▄ █▀█ █▀█   █▀▄ █▀▀ █░█ █▀▀   ▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ ▄▀█ █▀█   █▀█
█▄█   █▄█ █▄█ █▄█ █▀█ █▄▀ █▄█ █▀▄   █▄▀ ██▄ ▀▄▀ ██▄   █▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ █▀█ █▀▄   █▄█

█▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█   █▀█ █░█ █▀▀   █▀█   █▄▄ █▀█ ▀█▀   █░█ ▄▀█ █
█░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█   ▀▀█ █▄█ ██▄   █▄█   █▄█ █▄█ ░█░   ▀▄▀ █▀█ █

█▀ █▀█ █▀█ ▀█▀ █▀▀ ▄▀█ █▀█   █▀▀ █▀█ █▀▄▀█   █▀█   █▀▄▀█ █ █▄░█ █ █▀▄▀█ █▀█   █▀▄ █▀▀
▄█ █▄█ █▀▄ ░█░ ██▄ █▀█ █▀▄   █▄▄ █▄█ █░▀░█   █▄█   █░▀░█ █ █░▀█ █ █░▀░█ █▄█   █▄▀ ██▄

▀█▀ █▀▀ █▄░█ ▀█▀ ▄▀█ ▀█▀ █ █░█ ▄▀█ █▀   █▀█ █▀█ █▀ █▀ █ █░█ █▀▀ █ █▀
░█░ ██▄ █░▀█ ░█░ █▀█ ░█░ █ ▀▄▀ █▀█ ▄█   █▀▀ █▄█ ▄█ ▄█ █ ▀▄▀ ██▄ █ ▄█");

do
{
    Console.Write("\n(Escolha um numero de 1 a 100)\n:");
    int.TryParse(Console.ReadLine(), out numeroJogador);

    //Dicas
    if (numeroJogador > numeroBot)
    {
        Console.WriteLine($"O numero sorteado é menor que {numeroJogador}");
        Console.WriteLine("Tente novamente");
    }

    else if (numeroJogador == numeroBot)
    {
        Console.WriteLine($"PARABENS VOCÊ ACERTOU \nO NUMERO ERA {numeroBot}\nNUMERO DE TENTATIVAS {tentativas}");
        break;
    }

    else
    { Console.WriteLine($"O numero sorteado é maior que {numeroJogador}");
        Console.WriteLine("Tente novamente");
    }
    
        tentativas++;
} while (true);
