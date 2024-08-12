using LiteDB;

namespace Modelos
{
        public class Produto
    {
            string NumerodaOperação { get; set; }
            string NumerodoTecido { get; set; }
            string QuantidadedeTecido { get; set; }
            string Preço { get; set; }
            string Linhas { get; set; }
            string Aviamentos { get; set; }
            string Cortador { get; set; }
            string Estampa { get; set; }
            string Grade { get; set; }

            [BsonId]
            int Id { get; set; }


    }
}