int notaMedia = 0;
Console.Write("Qual foi sua nota? :");
int.TryParse(Console.ReadLine(), out notaMedia);
Console.WriteLine("A média é de 6!");
if (notaMedia >= 6)
{
    Console.WriteLine($"Sua nota foi {notaMedia} você foi aprovado");
}
else
{
    Console.WriteLine($"Sua nota foi {notaMedia} você foi reprovado");
}

Console.WriteLine("Qual linguagem deseja acessar?\n(0) C#\n(1) Java\n(2) JavaScript");
int selecao = 0;
int.TryParse(Console.ReadLine(), out selecao);

List<string> linguagens = new List<string>();
linguagens.Add("C#");
linguagens.Add("Java");
linguagens.Add("JavaScript");;

Console.WriteLine($"Você escolheu a linguagem {linguagens[selecao]}");