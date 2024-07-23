namespace Modelos
{
public class Pessoa
{
    string Nome;
    string Telefone;
    string CPF;
    string Email;
    string Endereço;
    int Id; 
    
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

public void SetCPF (string c)
{
     CPF = c;
}

public string GetCPF ()
{
    return CPF;
}


public void SetEmail (string em)
{
     Email = em;
}

public string GetEmail ()
{
    return Email;
}

public void SetEndereço (string en)
{
     Endereço = en;
}

public string GetEndereço ()
{
    return Endereço;
}

}
}
