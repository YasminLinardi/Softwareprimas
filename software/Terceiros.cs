namespace software;

public class Terceiros
{
    string Nome;
    string Telefone;
    string Email;
    int id;

    public void SetNome (string n)
{
    Nome = n;
}

public string GetNome ()
{
    return Nome;
}

public void SetTelefone (string t)
{
     Telefone = t;
}

public string GetTelefone ()
{
    return Telefone;
}

public void SetEmail (string em)
{
     Email = em;
}

public string GetEmail ()
{
    return Email;
}

}