﻿class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => listaDeMusicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica) 
    { 
        listaDeMusicas.Add(musica);
        
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de Músicas do Álbum '{Nome}': \n");

        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        Console.WriteLine($"\nEste álbum tem {DuracaoTotal} segundos.");
    }
}