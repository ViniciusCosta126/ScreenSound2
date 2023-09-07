Banda banda = new Banda("Queen");
Album albumQueen = new Album("A night at the opera");

Musica musica1 = new Musica(banda, "Love of my life") { Duracao = 213, Disponivel = true };
Musica musica2 = new Musica(banda, "Bohemian Rhapsody") { Duracao = 354, Disponivel = false };

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirMusicasDoAlbum();


banda.AdicionarAlbum(albumQueen);
banda.ExibirDiscografia();