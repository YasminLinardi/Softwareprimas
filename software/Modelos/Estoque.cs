using System.Reflection.Metadata;

namespace Modelos
{
        public class Estoque
    {
            string  Quantidade;
            string Cliente; 
            string NumerodeOperação;
            int Id;

            public void SetQuantidade (string q)
                {
                    Quantidade = q;
                }
            public string GetQuantidade ()
                {
                    return Quantidade;
                }
            
            public void SetCliente (string c)
                {
                    Cliente = c;
                }

            public string GetCliente ()
                {
                    return Cliente;
                }

            public void SetNumerodeOperação (string no)
                {
                    NumerodeOperação = no;
                }
            
            public string GetNumerodaOperação ()
                {
                    return NumerodeOperação;
                }
            
    }
}