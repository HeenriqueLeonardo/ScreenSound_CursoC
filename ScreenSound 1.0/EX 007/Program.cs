Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};
Console.WriteLine("DIGITE O CARRO QUE DESEJA VER AS VENDAS\nBugatti Veyron\n" +
    "Koenigsegg Agera RS\nLamborghini Aventador\nPagani Huayra\nFerrari LaFerrari");
string escolha = Console.ReadLine();
double mediavendas = vendasCarros[escolha].Average();
Console.WriteLine($"A média de vendas de {escolha} é {mediavendas}");