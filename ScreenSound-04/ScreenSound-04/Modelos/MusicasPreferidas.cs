using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListadeMuusicasFavoritas {  get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListadeMuusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListadeMuusicasFavoritas.Add(musica);
    }
    public void ExibirMuscasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas de {Nome}");
        foreach (var musica in ListadeMuusicasFavoritas)
        {
            Console.WriteLine($"-> {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListadeMuusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoridas{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso \n{Path.GetFullPath(nomeDoArquivo)}");

    }
}
