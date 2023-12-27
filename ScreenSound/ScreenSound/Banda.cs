class Banda
{
    public string Nome { get; }
    private List<Album> albums = [];

    public Banda(String nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void MostrarDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");

        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }

}