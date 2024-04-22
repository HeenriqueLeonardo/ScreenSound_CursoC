int numero1 = 0;
Console.Write("Escreva o primeiro numero: ");
int.TryParse(Console.ReadLine(), out numero1);
int numero2 = 0;
Console.Write("Escreva o segundo numero: ");
int.TryParse(Console.ReadLine(), out numero2);
//Declarando as variaveis

Console.WriteLine($"A soma de {numero1} + {numero2 } é = {numero1 + numero2}");
Console.WriteLine($"A subtracão de {numero1} - {numero2} é = {numero1 - numero2}");
Console.WriteLine($"A multiplicacão de {numero1} x {numero2} é = {numero1 * numero2}");
Console.WriteLine($"A divisão de {numero1} / {numero2} é = {numero1 / numero2}");