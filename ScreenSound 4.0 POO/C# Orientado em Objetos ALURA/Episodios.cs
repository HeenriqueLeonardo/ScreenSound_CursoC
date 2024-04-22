using System.Threading.Channels;

class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, float duracao)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public float Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo}. ({Duracao} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}
