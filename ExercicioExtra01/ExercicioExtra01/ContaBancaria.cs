class ContaBancaria
{
    public int id;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine(@$"A conta bancária nº {id} tem como titular a pessoa denominada de {titular}, possuindo saldo de R${saldo} e a sua senha é '{senha}'.");
    }
}

