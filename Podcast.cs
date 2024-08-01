class Podcast
    {
    private List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    //public int TotalEpisodios => episodios.Count; // Na aula pede um TotalEpisodios mas pode ser substituido por um episodios.Count?
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} - {Host}\n");
        if (episodios.Count == 0)
        {
            Console.WriteLine("Nenhum episódio ainda.");
        }
        else
        {
            foreach (var ep in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"{ep.Resumo}\n");
            }
        }
        Console.WriteLine($"O podcast possui {episodios.Count} episódios");
    }
}