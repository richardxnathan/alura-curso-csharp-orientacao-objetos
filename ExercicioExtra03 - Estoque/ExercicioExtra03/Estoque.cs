class Estoque
{
    public List<Produto> listaDeProdutos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        listaDeProdutos.Add(produto);
    }

    public void MostrarProdutos()
    {
        Console.WriteLine("Lista de produtos registrados:");

        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine($"- {produto.nome}");
        }
    }
}