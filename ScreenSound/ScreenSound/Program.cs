Album albumJoyDivison = new Album();

albumJoyDivison.Nome = "Unknown Pleasures";


Musica primeiraMusica = new Musica();

primeiraMusica.Nome = "Disorder";
primeiraMusica.Duracao = 212;

Musica segundaMusica = new Musica();
segundaMusica.Duracao = 289;

segundaMusica.Nome = "Day Of The Lords";

albumJoyDivison.AdicionarMusica(primeiraMusica);
albumJoyDivison.AdicionarMusica(segundaMusica);

albumJoyDivison.ExibirMusicasDoAlbum();