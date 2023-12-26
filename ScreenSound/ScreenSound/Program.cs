Banda primeiraBanda = new Banda("Joy Division");

Album albumJoyDivison = new Album("Unknown Pleasures");

Musica primeiraMusica = new Musica(primeiraBanda, "Disorder")
{
    Duracao = 212,
    Disponivel = true,
};


Musica segundaMusica = new Musica(primeiraBanda, "Day Of The Lords")
{
    Duracao = 289,
    Disponivel = false,
};


albumJoyDivison.AdicionarMusica(primeiraMusica);
albumJoyDivison.AdicionarMusica(segundaMusica);

primeiraMusica.ExibirFichaTecnica();
segundaMusica.ExibirFichaTecnica();
primeiraBanda.AdicionarAlbum(albumJoyDivison);
primeiraBanda.MostrarDiscografia();