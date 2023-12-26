class Playlist
{
    public List<Musica> Playlista { get; }

    public Playlist() 
    {
        Playlista = [];
    }

    public void AdicionarNaPlaylist(Musica musica)
    {
        if (!Playlista.Contains(musica))
        {
            Playlista.Add(musica);
            Console.WriteLine("Música adicionada com sucesso!");
        } else
        {
            Console.WriteLine("Falha ao adicionar, esta música já está na playlist!");
        }

    }
}