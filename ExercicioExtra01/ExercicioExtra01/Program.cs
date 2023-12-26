Titular primeiroTitular = new Titular();

primeiroTitular.NomeCompleto = "Richard Nathan";

ContaBancaria primeiraConta = new ContaBancaria();

primeiraConta.Id = 0001;
primeiraConta.Titular = primeiroTitular;
primeiraConta.Saldo = 1000000.00;
primeiraConta.Senha = "123456";

primeiraConta.ExibirInformacoes();