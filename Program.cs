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
