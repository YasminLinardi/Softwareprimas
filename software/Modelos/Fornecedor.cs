namespace Modelos
{

        public class Fornecedores
    {
        string Nome;
        string Telefone;
        string CNPJ;
        string Email;
        string QualMateria;
        string PreçodaMateria;
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

        public void SetQualMateria (string qm)
            {
                QualMateria = qm;
            }

        public string GetQualMateria ()
            {
                return Email;
            }

        public void SetPreçodaMateria (string pm)
            {
                PreçodaMateria = pm;
            }

        public string GetPreçodaMateria ()
            {
                return PreçodaMateria;
            }
    }
}
