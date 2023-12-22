class Carro
{
    public int ano;
    public string modelo;
    public int velocidade;

    public void Acelerar()
    {
        Console.WriteLine("Aumentando a velocidade...");
        velocidade += 10;
        Console.WriteLine($"Velocidade atual: {velocidade}");
    }

    public void Frear()
    {
        if ( velocidade > 0 ) {
            Console.WriteLine("Diminuindo a velocidade...");
            velocidade -= 5;
            Console.WriteLine($"Velocidade atual: {velocidade}");

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