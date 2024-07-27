class Musica
{
    public string Nome { set; get; }
    public string Artista { set; get; }
    public Genero Genero { get; set; }
    public int Duracao { set; get; }
    public bool Disponivel { set; get; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}