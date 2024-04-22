//Screen Sound
string MensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";
Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8 });
BandasRegistradas.Add("21 Pilots", new List<int> { 10, 10, 10 });

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(MensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{//Mostrando opcoes
    ExibirLogo();
    Console.WriteLine("\nDigite (1) para registrar uma banda");
    Console.WriteLine("Digite (2) para mostrar todas as bandas");
    Console.WriteLine("Digite (3) para avaliar uma banda");
    Console.WriteLine("Digite (4) para mostrar a média de uma banda");
    Console.WriteLine("Digite (0) para sair");

    //Recebendo váriavel
    Console.Write("\nDigite a sua opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    switch (opcaoEscolhidaNumerica)
    {
        case 1: ResgistrarBanda();
            break;

        case 2: MostrarBandasRegistradas();
            break;

        case 3: AvaliarBanda();
            break;

        case 4: MostrarMedia();
            break;

        case 0: Console.WriteLine("Até Mais Tchau Tchau");
            break;
        default: Console.WriteLine("Opcão invalida!");
                break;
    }
}

void ResgistrarBanda()
{
    Console.Clear();
    ExibirTituloDasOpcopes("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar :");
    string nomeBanda = Console.ReadLine()!;
    BandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDasOpcopes("Exibindo todas bandas registradas.");
    
    foreach (string banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda : {banda}");
    }
    Console.WriteLine("\nDigite uma Tecla e volte para o Menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu() ;


}

void ExibirTituloDasOpcopes(string titulo) 
{
    int caracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(caracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDasOpcopes("Avaliando Banda");
    Console.Write("Digite o nome da banda que deseja valiar: ");
    string NomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(NomeDaBanda))
    {
        Console.Write($"Qual nota a banda {NomeDaBanda} vai receber : ");
        int nota = int.Parse(Console.ReadLine()!);
        BandasRegistradas[NomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para banda {NomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {NomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MostrarMedia()
{
    Console.Clear();
    ExibirTituloDasOpcopes("Exibindo Média");
    Console.Write("Escreva o nome da banda que Deseja ver a média:");
    string NomeDaBanda = Console.ReadLine()!;
    if(BandasRegistradas.Keys.Contains(NomeDaBanda))
    {
        Double media = BandasRegistradas[NomeDaBanda].Average();
        Console.WriteLine($"A média da Banda {NomeDaBanda} é {media}");
        Console.WriteLine("Digite uma tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else {
        Console.WriteLine("Esta banda não foi encontrada");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu(); }
}


ExibirOpcoesDoMenu();   
