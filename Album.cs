class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
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
        Console.WriteLine($"Este álbum contém {DuracaoTotal} segundos!");
    }
}