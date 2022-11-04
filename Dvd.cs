using static Biblioteca;

public class Dvd : Documento
{
    //Properties
    public int Durata { get; set; }

    //Construttore
    public Dvd(string id, string titolo, int anno, string settore, bool stato, string scaffale, string autore, int durata) : base(id, titolo, anno, settore, stato, scaffale, autore)
    {
        Durata = durata;
    }
}
