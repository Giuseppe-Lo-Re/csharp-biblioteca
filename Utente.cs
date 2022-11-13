public class Utente : Persona
{
    public string Email { get; }
    public string Telefono { get; }

    public Utente(string cognome, string nome, string email, string telefono) : base(cognome, nome)
    {
        Email = email;
        Telefono = telefono;
    }
}
