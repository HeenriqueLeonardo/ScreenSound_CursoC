using ScreenSound_04.Modelos;
using System.Text.Json;
using System.Text.Json.Nodes;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasDoArtista(musicas, "Arctic Monkeys");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2004");

        //var musicasPreferidasDoHenrique = new MusicasPreferidas("Henrique");
        //musicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[456]);
        //musicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[505]);
        //musicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[22]);
        //musicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[13]);

        //musicasPreferidasDoHenrique.ExibirMuscasFavoritas();

        LinqFilter.FiltrarPorTonalidade(musicas, 1);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
