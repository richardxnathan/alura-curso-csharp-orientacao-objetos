Produto primeiroProduto = new Produto();
primeiroProduto.nome = "Macarrão";

Produto segundoProduto = new Produto();
segundoProduto.nome = "PTS";

Estoque estoque = new Estoque();

estoque.AdicionarProduto(primeiroProduto);
estoque.AdicionarProduto(segundoProduto);

estoque.MostrarProdutos();