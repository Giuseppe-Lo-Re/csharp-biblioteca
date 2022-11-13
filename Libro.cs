public class Libro : Documento
{
    public int Pagine { get; set; }

    public Libro(string id, string titolo, string settore, int anno, string scaffale, Persona autore, int pagine) : base(id, titolo, settore, anno, scaffale, autore)
    {
        Pagine = pagine;
    }
}