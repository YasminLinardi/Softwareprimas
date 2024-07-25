namespace Modelos
{
        public class Costura
    {
            string Quantidade;
            string Aviamento;
            string NumerodaOperação;
            int Id;
            
        public void SetQuantidade (string q)
            {
                Quantidade = q;
            }

        public string GetQuantidade ()
            {
                return Quantidade;
            }

        public void SetAviamento (string a)
            {
                Aviamento = a;
            }

        public string GetAviamento ()
            {
                return Aviamento;
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