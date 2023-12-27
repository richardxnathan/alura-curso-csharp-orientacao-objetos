class Produto
{
    public string nome;
    public string marca;
    public double Preco 
    {
        get => Preco;
        set
        {
            if (Preco <= 0)
            {
                Console.WriteLine("Insira um preço válido!");
            } else
            {
                Preco = value;
            }
        }
    }
    public int Quantidade
    {
        get => Quantidade;
        set
        {
            if (Quantidade > 0)
            {
                Quantidade = value;
            }
            else
            {
                Quantidade = 0;
            }
        }
    }
    public string DescricaoDetalhada => $"O produto '{nome}' da marca {marca} custando R${Preco}";

}