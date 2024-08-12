using LiteDB;

namespace Modelos
{
        public class Encomenda
    {
            string Nome { get; set; }
            string CódigodePedido { get; set; }
            string Telefone { get; set; }
            string Email { get; set; }
            string Endereço { get; set; }
            string Produto { get; set; }
            string ValordoProduto { get; set; }
            string Quantidade { get; set; }
            string ValorTotal { get; set; }

            [BsonId]
            int Id { get; set; }


       
    }
}


