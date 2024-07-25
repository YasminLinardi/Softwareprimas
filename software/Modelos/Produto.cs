namespace Modelos
{
        public class Produto
    {
            string NumerodaOperação;
            string NumerodoTecido;
            string QuantidadedeTecido;
            string Preço;
            string Linhas;
            string Aviamentos;
            string Cortador;
            string Estampa;
            string Grade;
            int Id;


        public void SetNumerodaOperação (string no)
            {
                NumerodaOperação = no;
            }

        public string GetNumerodaOperação ()
            {
                return NumerodaOperação;
            }

        public void SetNumerodoTecido (string nt)
            {
                NumerodoTecido = nt;
            }

        public string GetNumerodoTecido ()
            {
                return NumerodoTecido;
            }

        public void SetQuantidadedeTecido (string qt)
            {
                QuantidadedeTecido = qt;
            }

        public string GetQuantidadedeTecido ()
            {
                return QuantidadedeTecido;
            }

        public void SetPreço (string p)
            {
                Preço = p;
            }

        public string GetPreço ()
            {
                return Preço;
            }

        public void SetLinhas (string l)
            {
                Linhas = l;
            }

        public string GetLinhas ()
            {
                return Linhas;
            }

        public void SetAviamentos (string a)
            {
                Aviamentos = a;
            }

        public string GetAviamentos ()
            {
                return Aviamentos;
            }

        public void SetCortador (string c)
            {
                Cortador = c;
            }

        public string GetCortador ()
            {
                return Cortador;
            }

        public void SetEstampa (string e)
            {
                Estampa = e;
            }

        public string GetEstampa ()
            {
                return Estampa;
            }

        public void SetGrade (string g)
            {
                Grade = g;
            }

        public string GetGrade ()
            {
                return Grade;
            }


    }
}