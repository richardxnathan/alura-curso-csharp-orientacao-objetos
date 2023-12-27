class Episodio
{
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public List<string> ListaDeConvidados = []; 
    public string Resumo => $"O episódio '{Titulo}' é o nº {Ordem} e tem duração de {Duracao} minutos - {string.Join(", ", ListaDeConvidados)}";

    public Episodio( int ordem, string titulo, int duracao )
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        ListaDeConvidados.Add(convidado);
    }
}