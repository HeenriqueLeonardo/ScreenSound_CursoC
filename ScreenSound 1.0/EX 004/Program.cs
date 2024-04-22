Console.WriteLine("LOJAS TABARTO");

Dictionary<string, List<int>> Estoque = new Dictionary<string, List<int>>();
Estoque.Add("Macarrão" , new List<int> {10});
Estoque.Add("Detergente", new List<int> { 8});
Estoque.Add("Bolacha", new List<int> { 2 });

foreach ( string produtos in Estoque.Keys)
{
    Console.WriteLine(produtos);
}
Console.Write("Qual produto deseja consultar? : ");
string NomeProduto = Console.ReadLine();
if (Estoque.ContainsKey(NomeProduto))
{
    int quantidade = Estoque[NomeProduto][0];
    Console.WriteLine($"O produto {NomeProduto} tem {quantidade} unidades");
}
else
{
    Console.WriteLine($"O produto {NomeProduto} não esta cadastrado!");
}
