using System.Runtime.ConstrainedExecution;

//Richiesta:
//Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati
//cognome,
//nome,
//email,
//recapito telefonico,
//Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
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

Biblioteca biblioteca = new Biblioteca();

biblioteca.documenti.Add(new Libro("666", "Il coraggio di non piacere", "Crescita personale", 2019, "C48", new Persona("Ichiro", "Kishimi"), 288));
biblioteca.documenti.Add(new Libro("957", "Washoku. L'arte della cucina giapponese", "Cucina", 2016, "F02", new Persona("Hirohiko", "Shoda"), 320));
biblioteca.documenti.Add(new Libro("336", "Il Suggeritore", "Thriller", 2010, "T82", new Persona("Carrisi", "Donato"), 469));

biblioteca.utenti.Add(new Utente("Rossi", "Mario", "rossi.mario@mail.it", "1234567890"));
biblioteca.utenti.Add(new Utente("Verdi", "Giuseppe", "verdi.giuseppe@mail.it", "1234567890"));
biblioteca.utenti.Add(new Utente("Giallo", "Maria", "giallo.maria@mail.it", "1234567890"));


biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[0], biblioteca.documenti[0], "13/11/22", "20/11/22"));
biblioteca.documenti[0].Disponibile = false;

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[1], biblioteca.documenti[1], "13/11/22", "17/11/22"));
biblioteca.documenti[1].Disponibile = false;

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[2], biblioteca.documenti[2], "13/11/22", "17/11/22"));
biblioteca.documenti[2].Disponibile = false;

biblioteca.RicercaPrestito();


public class Biblioteca
{
    public List<Documento> documenti = new List<Documento>();
    public List<Utente> utenti = new List<Utente>();
    public List<Prestito> prestiti = new List<Prestito>();

    public Documento TrovaDocumento(string id)
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

    public Utente TrovaUtente(string cognome, string nome)
    {
        foreach (Utente utente in utenti)
        {
            if (utente.Cognome.Equals(cognome) && utente.Nome.Equals(nome))
            {
                return utente;
            }
        }

        return null;
    }

    public Persona ChiediDatiUtente()
    {
        Console.WriteLine("Inserisci il cognome dell'utente");
        string cognome = Console.ReadLine();
        Console.WriteLine("Inserisci il nome dell'utente");
        string nome = Console.ReadLine();

        return new Persona(cognome, nome);
    }

    public Utente UtenteRegistrato()
    {
        Persona daCercare = ChiediDatiUtente();

        Utente utente = TrovaUtente(daCercare.Cognome, daCercare.Nome);
        if (utente != null)
        {
            Console.WriteLine($"{utente.Cognome} {utente.Nome} è registrato");
            Console.WriteLine("I suoi dati sono: ");
            Console.WriteLine($"telefono : {utente.Telefono}");
            Console.WriteLine($"email    : {utente.Email}");
            return utente;
        }
        else
        {
            Console.WriteLine("L'utente NON è registrato");
            return null;
        }
    }

    public void InserisciPrestito()
    {
        Utente utente = UtenteRegistrato();
        if (utente != null)
        {
            Console.WriteLine("Inserire il codice del documento");
            Documento documento = TrovaDocumento(Console.ReadLine());
            if (documento != null)
            {
                if (!documento.Disponibile)
                {
                    Console.WriteLine($"Il libro attualmente è preso in prestito");
                    return;
                }
                Console.WriteLine("Inserire la data d'inizio del prestito");
                string dataInizio = Console.ReadLine();
                Console.WriteLine("Inserire la data d'inizio del prestito");
                string dataFine = Console.ReadLine();

                prestiti.Add(new Prestito(utente, documento, dataInizio, dataFine));
                documento.Disponibile = false;
                Console.WriteLine($"Il prestito è stato inserito corettamene");
                return;
            }
            Console.WriteLine("Documento non trovato");
        }
    }

    public List<Prestito> RicercaPrestito()
    {
        Persona utente = ChiediDatiUtente();
        List<Prestito> noleggio = new List<Prestito>();

        foreach (Prestito prestito in prestiti)
        {
            if (prestito.Utente.Cognome.Equals(utente.Cognome) && prestito.Utente.Nome.Equals(utente.Nome))
            {
                noleggio.Add(prestito);
            }
        }

        StampaPrestiti(noleggio);

        return noleggio;
    }

    public void StampaPrestiti(List<Prestito> prestiti)
    {
        foreach (Prestito prestito in prestiti)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Titolo: {prestito.Documento.Titolo}");
        }
    }
}