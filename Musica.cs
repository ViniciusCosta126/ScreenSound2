class Musica {
    public string nome;
    private bool disponivel;
    public string artista;
    public int duracao;


    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel) {
            Console.WriteLine("Disponivel no plano");
        }
        else {
            Console.WriteLine("Adiquira o plano Plus+");
        }
    }

    public void ExibirNomeArtista() {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
    }
}