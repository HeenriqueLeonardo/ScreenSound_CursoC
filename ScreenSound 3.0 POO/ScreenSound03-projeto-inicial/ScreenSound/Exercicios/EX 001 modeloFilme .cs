class filme
{
    public filme(string titulo, float duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }
    private List<string> elenco = new();

    public string Titulo { get; }
    public float Duracao { get; }

    public void AdicionarElenco()
    {
        Console.WriteLine();
    }
}
