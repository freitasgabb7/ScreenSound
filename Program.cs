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

//sleepToken2023.AdicionarMusica(musica1);
//sleepToken2023.AdicionarMusica(musica2);
//sleepToken.AdicionarAlbum(sleepToken2023);
//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//sleepToken2023.ExibirMusicasAlbum();
//sleepToken.ExibirDiscografia();

Podcast placeholder = new("Zatt", "Placeholder");

Episodio ep1 = new(1, "Pilot", 46);

Episodio ep2 = new(2, "Where Are We?", 43);

placeholder.AdicionarEpisodio(ep1);
ep1.AdicionarConvidados("Amanda");
ep1.AdicionarConvidados("Gabriel");
placeholder.AdicionarEpisodio(ep2);
ep2.AdicionarConvidados("Phaxe");
placeholder.ExibirDetalhes();