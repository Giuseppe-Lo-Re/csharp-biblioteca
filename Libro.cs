using static Biblioteca;

public class Libro : Documento
{
    //Properties
    public int Pagine { get; set; }

    //Construttore
    public Libro(string id, string titolo, int anno, string settore, bool stato, string scaffale, string autore, int pagine) : base(id, titolo, anno, settore, stato, scaffale, autore)
    {
        Pagine = pagine;
    }


}
