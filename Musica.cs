class Musica {
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";

    public Musica(Banda artista, string nome) {
        Artista = artista;
        Nome = nome;
    }
    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel) {
            Console.WriteLine("Disponivel no plano");
        }
        else {
            Console.WriteLine("Adiquira o plano Plus+");
        }
    }

    public void ExibirNomeArtista() {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}