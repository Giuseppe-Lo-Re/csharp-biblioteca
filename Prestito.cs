using static Biblioteca;

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