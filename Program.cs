Album sleepToken2023 = new Album();
sleepToken2023.Nome = "Take Me Back To Eden";

Musica musica1 = new Musica();
musica1.Nome = "Chokehold";
musica1.Artista = "Sleep Token";
musica1.Duracao = 304;

Musica musica2 = new Musica();
musica2.Nome = "The Summoning";
musica2.Artista = "Sleep Token";
musica2.Duracao = 395;

sleepToken2023.AdicionarMusica(musica1);
sleepToken2023.AdicionarMusica(musica2);
sleepToken2023.ExibirMusicasAlbum();