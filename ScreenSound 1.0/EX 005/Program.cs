Console.WriteLine("Quiz Verdadeiro ou Falso\nResponda somente com (v) ou (f)\n\nPressione uma tecla para JOGAR");
Console.ReadKey();
int pontos = 0;
Dictionary<string, List<string>> Quiz = new Dictionary<string, List<string>>();
Quiz.Add("A terra é o maior planeta do sistema solar?", new List<string> { "f" });
Quiz.Add("O paulo muzzi é natural?", new List<string> { "f" });
Quiz.Add("Palmeiras tem mundial?", new List<string> { "f" });
Quiz.Add("O manuel Gomesé hetero?", new List<string> { "v" });

foreach (var perguntaResposta in Quiz)
{
    Console.WriteLine($"\nPergunta: {perguntaResposta.Key}\n");
    string resposta = Console.ReadLine();
    if (perguntaResposta.Value[0] == resposta)
    {
        Console.WriteLine("Sua resposta esta correta!");
        pontos ++;
    }
    else 
    {
        Console.WriteLine("Sua ressposta esta errada");
    }
    Console.WriteLine($"Resposta correta: {perguntaResposta.Value[0]}");
}
if (pontos > 3)
{
    Console.WriteLine($"Você manja dos Paranauê teve {pontos} pontos");
}

else if (pontos < 3)
{
    Console.WriteLine("Sabe de nada inocente vai Estudar na Escola da vida");
}