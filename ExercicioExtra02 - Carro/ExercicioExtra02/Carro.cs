class Carro
{
    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public int Velocidade { get; set; }

    public string DescricaoDetalhada => $"O carro é da {Fabricante}, modelo {Modelo} do ano de {Ano}.";

    public int Ano 
    {
        get => Ano;
        set
        {
            if (Ano < 1960 || Ano > 2023) 
            {
                Console.WriteLine("Ano inválido, insira um ano entre 1960 e 2023.");
            } else
            {
                Ano = value;
            }
        }
    }

    public void Acelerar()
    {
        Console.WriteLine("Aumentando a velocidade...");
        Velocidade += 10;
        Console.WriteLine($"Velocidade atual: {Velocidade}");
    }

    public void Frear()
    {
        if ( Velocidade > 0 ) {
            Console.WriteLine("Diminuindo a velocidade...");
            Velocidade -= 5;
            Console.WriteLine($"Velocidade atual: {Velocidade}");

        } else
        {
            Console.WriteLine("Você está parado não adianta freiar.");
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi bi");
    }



}