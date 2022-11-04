public class Biblioteca
{
    public class Documento
    {
        //Properties
        public string Id { get; }
        public string Titolo { get; }
        public int Anno { get; }
        public string Settore { get; }
        public bool Stato { get; }   
        public string Scaffale { get; }
        public string Autore { get; }

        //Construttore
        public Documento(string id, string titolo, int anno, string settore, bool stato, string scaffale, string autore)
        {
            Id = id;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Stato = stato;
            Scaffale = scaffale;
            Autore = autore;
        }
    }
}