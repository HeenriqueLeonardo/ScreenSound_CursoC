using ScreenSound_04.Modelos;
using System.Linq;
namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in TodosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var ArtistasPorGenero = musicas.Where
            (musica => musica.Genero!.Contains(genero)).Select
            (musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas por genero musical >>> {genero}");

        foreach (var artista in ArtistasPorGenero)
        {
            Console.WriteLine($"-> {artista}");
        }
    }

    public static void FiltrarMusicasDoArtista
        (List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!
        .Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-> {musica.Nome}");
        }
    }

    public static void FiltrarPorTonalidade(List<Musica> musicas, int tonalidade)
    {
        var musicasNoTom = musicas.Where(musica => musica.Key == tonalidade).ToList();
        Console.WriteLine($"Tonalidade - {tonalidade}");
        Console.WriteLine("Musicas em C#");

        foreach (var musica in musicasNoTom)
        {
            Console.WriteLine($"-> {musica.Nome}");
        }
    }
}