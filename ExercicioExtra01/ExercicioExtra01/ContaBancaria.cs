class ContaBancaria
{
    public Titular Titular {  get; set; }
    public int Id { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"A conta bancária nº {Id} tem como titular a pessoa denominada de {Titular.NomeCompleto}, " +
            $"possuindo saldo de R${Saldo} e a sua senha é '{Senha}'.");
    }
}

