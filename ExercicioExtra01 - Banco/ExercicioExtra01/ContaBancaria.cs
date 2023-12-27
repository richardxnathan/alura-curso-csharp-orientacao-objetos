class ContaBancaria
{
    public ContaBancaria(Titular titular, int id, double saldo, string senha, int agencia)
    {
        Titular = titular;
        Id = id;
        Saldo = saldo;
        Senha = senha;
        Agencia = agencia;
    }

    public Titular Titular {  get; set; }
    public int Id { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }
    public int Agencia { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"A conta bancária nº {Id} é da agência {Agencia} tem como titular a pessoa denominada de {Titular.NomeCompleto}, " +
            $"possuindo saldo de R${Saldo} e a sua senha é '{Senha}'.");
    }
}

