List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Os numeros pares da lista são:");
for (int i = 0; i < numeros.Count; i++) ;
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.Write($"{numero}, ");
    }
}
    

