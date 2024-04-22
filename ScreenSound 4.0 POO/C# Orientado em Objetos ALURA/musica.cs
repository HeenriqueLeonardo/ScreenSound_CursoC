﻿using System.Xml;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista {  get; }
    public int Duracao {  get; set; }
    public bool  Disponivel {  get; set; }


    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista}";
  
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracão: {Duracao}");
        if (Disponivel == true)
        {
            Console.WriteLine("Disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine("\n");
    }   
}
