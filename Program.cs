Genero alternativeMetal = new Genero("Alternative Metal");

Banda sleepToken = new Banda("Sleep Token");

Album sleepToken2023 = new Album("Take Me Back To Eden");

Musica musica1 = new Musica(sleepToken, "Chokehold", alternativeMetal)
{
    Duracao = 304,
    Disponivel = true,
};

Musica musica2 = new Musica(sleepToken, "The Summoning", alternativeMetal)
{
    Duracao = 395,
    Disponivel = false,
};

sleepToken2023.AdicionarMusica(musica1);
sleepToken2023.AdicionarMusica(musica2);
sleepToken.AdicionarAlbum(sleepToken2023);
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
sleepToken2023.ExibirMusicasAlbum();
sleepToken.ExibirDiscografia();