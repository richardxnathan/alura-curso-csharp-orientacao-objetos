Musica primeiraMusica = new Musica();

primeiraMusica.Nome = "Mulher de Fases";
primeiraMusica.Artista = "Raimundos";
primeiraMusica.Duracao = 180;
primeiraMusica.Disponivel = true;

Console.WriteLine(primeiraMusica.ConjuntoArtistaNome);
primeiraMusica.ExibirFichaTecnica();

Musica segundaMusica = new Musica();
segundaMusica.Nome = "Disorder";
segundaMusica.Artista = "Joy Division";
segundaMusica.Duracao = 165;
segundaMusica.Disponivel = false;

segundaMusica.ExibirFichaTecnica();

