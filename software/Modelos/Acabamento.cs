namespace Modelos
{
        public class Acabamento
    {
            string Acabamentos;
            string Aviamentos;
            string NumerodaOperação;
            int Id;

        public void SetAcabamento (string a)
            {
                Acabamentos = a;
            }

        public string GetAcamanento ()
            {
                return Acabamentos;
            }

        public void SetAviamentos (string av)
            {
                Aviamentos = av;
            }

        public string GetAviamentos ()
            {
                return Aviamentos;
            }

        public void SetNumerodaOperação (string no)
            {
                NumerodaOperação = no;
            }

        public string GetNumerodaOperação ()
            {
                return NumerodaOperação;
            }

    }
}