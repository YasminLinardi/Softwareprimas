namespace Modelos
{
        public class Materia
    {
        string Nome;
        string Tipo;
        string ValorUnidade;
        string CodigodaMateria;
        int Id;

            public void SetNome (string n)
                {
                     Nome = n;
                } 

            public string GetNome ()
                {
                    return Nome;
                }

            public void SetTipo (string t)
                {
                    Tipo = t;   
                }

            public string GetTipo ()
                {
                   return Tipo;
                }

            public void SetValorUnidade (string vu)
                {
                   ValorUnidade = vu;
                }

            public string GetValorUnidade ()
                {
                   return ValorUnidade;
                }
            
            public void SetCodigodaMateria (string cm)
            {
                CodigodaMateria = cm;
            }

            public string GetCodigodaMateria ()
            {
                return CodigodaMateria;
            }
    }
}