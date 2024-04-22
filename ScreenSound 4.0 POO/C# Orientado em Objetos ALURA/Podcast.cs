class Podcast
{
    public Podcast(string nome, string host) 
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;
    
     
    private List<Episodio> episodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
       episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast - {Nome} Host - {Host}\nTotal de Episódios {TotalEpisodios}");
        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Esse Podcast possui {TotalEpisodios} episodios");
        Console.WriteLine("\n\n");
    }
}