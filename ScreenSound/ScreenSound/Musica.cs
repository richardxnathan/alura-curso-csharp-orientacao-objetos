class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string ConjuntoArtistaNome => $"{Artista} - {Nome}";
    public Genero Genero { get; set; }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel == true)
        {
            Console.WriteLine("Disponível no plano.");
        } 
        else 
        {
            Console.WriteLine("Adquira o plano premium para ter acesso a música.");
        }
    }
    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}");
    }

}

