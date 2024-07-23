namespace Modelos
{
        public class Encomenda
    {
            string Nome;
            string CódigodePedido;
            string Telefone;
            string Email;
            string Endereço;
            string Produto;
            string ValordoProduto;
            string Quantidade; 
            string ValorTotal;
            int Id;


        public void SetNome (string n)
            {
                 Nome = n;
            }

        public string GetNome ()
            {
                 return Nome;
            }

        public void SetCódigodePedido (string cp)
            {
                CódigodePedido = cp;
            }

        public string GetCódigodePedido ()
            {
                return CódigodePedido;
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

        public void SetEndereço (string en)
            {
                Endereço = en;
            }

        public string GetEndereço ()
            {
                return Endereço;
            }

        public void SetProduto (string p)
            {
                Produto = p;
            }

        public string GetProduto ()
            {
                return Produto;
            }

        public void SetValordoProduto (string vp)
            {
                ValordoProduto = vp;

            }

        public string GetValordoProduto ()
            {
                return ValordoProduto;
            }

        public void SetQuantidade (string q)
            {
                Quantidade = q;
            }

        public string GetQuantidade ()
            {
                return Quantidade;
            }

        public void SetValorTotal (string vl)
            {
                ValorTotal = vl;

            }

        public string GetValorTotal ()
            {
                return ValorTotal;
            }
    }
}


