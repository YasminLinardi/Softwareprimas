namespace software;

public class Fornecedores
{
    string Nome;
    string Telefone;
    string CNPJ;
    string Email;
    Int Id;

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

public void SetCNPJ (string c)
{
     CNPJ = c;
}

public string GetCNPJ ()
{
    return CNPJ;
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
