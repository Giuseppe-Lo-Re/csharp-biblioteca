public class Prestito
{
    public Utente Utente { get; }
    public Documento Documento { get; }
    public string InizioPrestito { get; set; }
    public string FinePrestito { get; set; }

    public Prestito(Utente utente, Documento documento, string inizioPrestito, string finePrestito)
    {
        Utente = utente;
        Documento = documento;
        InizioPrestito = inizioPrestito;
        FinePrestito = finePrestito;
    }
}