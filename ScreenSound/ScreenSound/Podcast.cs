class Podcast
{
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => ListaDeEpisodios.Count;
    public List<Episodio> ListaDeEpisodios = [];

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        ListaDeEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Bem vindo ao Podcast '{Nome}' apresentado por {Host}.");
        Console.WriteLine("\nLista de episódios já gravados:");

        foreach (var Episodio in ListaDeEpisodios.OrderBy(episodio => episodio.Ordem))
        {
            Console.WriteLine($"- {Episodio.Resumo}");
        }

        Console.WriteLine($"\nAo total já foram gravados {ListaDeEpisodios.Count} episódios.");
    }
}