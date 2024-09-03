using LiteDB;

namespace Modelos
{
        public class Produto
    {
            string NumerodoTecido { get; set; }
            string Preço { get; set; }
            string Unidade { get; set; }

            [BsonId]
            int Id { get; set; }


    }
}