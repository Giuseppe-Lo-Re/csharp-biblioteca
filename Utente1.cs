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
