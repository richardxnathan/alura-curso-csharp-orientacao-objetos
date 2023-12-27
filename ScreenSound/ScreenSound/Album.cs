class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => listaDeMusicas.Sum(musica => musica.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }

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