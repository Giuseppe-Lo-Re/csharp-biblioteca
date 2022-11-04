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

    public void RegistrazioneUtente()
    {
        Console.WriteLine("Registrazione in corso...");
        Console.WriteLine("Cognome:");
        string cognome = Console.ReadLine();
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Email:");
        string email = Console.ReadLine();
        Console.WriteLine("Password:");
        string password = Console.ReadLine();
        Console.WriteLine("Telefono:");
        string telefono = Console.ReadLine();

        Utente utenti = new Utente(cognome, nome, email, password, telefono);
        utentiList.Add(utenti);
    }
}
