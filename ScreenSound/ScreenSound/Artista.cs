class Artista
{

    public string NomeCompleto { get; }
    public string Biografia { get; }
    public List<Musica> MusicasEscritas { get; }

    public Artista(string nomeCompleto, string biografia)
    {
        NomeCompleto = nomeCompleto;
        Biografia = biografia;
        MusicasEscritas = [];
    }

    public void AdicionarMusica(Musica musica)
    {
        if (!MusicasEscritas.Contains(musica))
        {
            MusicasEscritas.Add(musica);
            Console.WriteLine("Música escrita registrada com sucesso!");
        }
        else
        {
            Console.WriteLine("Falha ao adicionar, esta música já foi registrada pelo artista!");
        }

    }
}