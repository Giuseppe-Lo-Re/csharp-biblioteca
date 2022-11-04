using System.Runtime.ConstrainedExecution;

//Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati
//cognome,
//nome,
//email,
//recapito telefonico,
//Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.
//Mi raccomando, prima di buttarvi sul codice fate qualche schema per capire le entità principali e le loro relazioni / eredità.

//Inizializzo una nuova Biblioteca
Biblioteca Biblioteca = new Biblioteca();

public class Biblioteca
{
    public List<Utente> utenti = new List<Utente>();
    public List<Documento> documenti = new List<Documento>();
    public List<Prestito> prestiti = new List<Prestito>();

    public Documento RicercaDocumento(string id)
    {
        foreach (Documento documento in documenti)
        {
            if (documento.Id.Equals(id))
            {
                return documento;
            }
        }
        return null;
    }
    public class Utente
    {
        //Properties
        public string Cognome { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Password { get; }
        public string Telefono { get; }

        //Costruttore
        public Utente(string cognome, string nome, string email, string password, string telefono)
        {
            Cognome = cognome;
            Nome = nome;
            Email = email;
            Password = password;
            Telefono = telefono;
        }
    }

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

    public class Prestito
    {
        //Properties
        public Utente Utente { get; }
        public Documento Documento { get; }
        public string InizioPrestito { get; set; }
        public string FinePrestito { get; set; }

        //Construttore
        public Prestito(Utente utente, Documento documento, string inizioPrestito, string FinePrestito)
        {
            Utente = utente;
            Documento = documento;
            InizioPrestito = inizioPrestito;
            FinePrestito = FinePrestito;
        }
    }
}