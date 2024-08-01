class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}\n");
        int i = 1;
        foreach (var musica in musicas)
        {
            Console.WriteLine($"{i}. {musica.Nome}");
            i++;
        }
        Console.WriteLine($"\nEste álbum contém {DuracaoTotal} segundos!\n");
    }
}