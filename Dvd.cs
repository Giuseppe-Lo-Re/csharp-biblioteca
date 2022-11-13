public class Dvd : Documento
{

    public int Durata { get; set; }

    public Dvd(string id, string titolo, string settore, int anno, string scaffale, Persona autore, int durata) : base(id, titolo, settore, anno, scaffale, autore)
    {
        Durata = durata;
    }
}