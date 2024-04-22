Console.WriteLine("Olá Mundo");
Console.Write("Qual o seu nome?: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome} quantos anos você tem ?");
int idade = 0;
int.TryParse(Console.ReadLine(), out idade);
Console.WriteLine($"Então você tem {idade} anos, que legal {nome}");
Console.WriteLine("Agora me Fale seus 3 filme favoritos para lista");
string filme1 = Console.ReadLine();
string filme2 = Console.ReadLine();
string filme3 = Console.ReadLine();
List<string> filmes = new List<string>();
filmes.Add(filme1);
filmes.Add(filme2);
filmes.Add(filme3);
foreach (string filme in filmes)
{
    Console.WriteLine(filme);
}