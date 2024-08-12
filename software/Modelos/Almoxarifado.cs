using LiteDB;

namespace Modelos
{
        public class Almoxarifado
    {
            string Quantidades { get; set; }
            string EntradadeMateriais { get; set; }
            string SaidadeMateriais { get; set; }
            string MateriaisEsgotados { get; set; }
            string NumerodaOperação { get; set; }

            [BsonId]
            int Id { get; set; }

       
    }
}