class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        NomeCompleto = nome;
        CPF = cpf;
        Endereco = endereco;
    }

    public string NomeCompleto { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
}
