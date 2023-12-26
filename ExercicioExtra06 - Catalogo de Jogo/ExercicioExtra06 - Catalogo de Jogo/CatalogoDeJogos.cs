class CatalogoDeJogos
{
    public List<Jogo> ListaDeJogos { get; }
    public CatalogoDeJogos()
    {
        ListaDeJogos = [];
    }

    public void AdicionarJogo(Jogo jogo)
    {
        ListaDeJogos.Add(jogo);
    }

    public void MostrarJogos()
    {
        Console.WriteLine("Lista de Jogos do Catálogo:");

        foreach (var jogo in ListaDeJogos)
        {
            Console.WriteLine($"- {jogo}");
        }
    }

}