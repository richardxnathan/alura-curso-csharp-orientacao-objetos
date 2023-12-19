
class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string ConjuntoArtistaNome => $"{Artista} - {Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }

}

