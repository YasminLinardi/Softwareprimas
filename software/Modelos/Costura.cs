using LiteDB;

namespace Modelos
{
        public class Costura
    {
            string Quantidade { get; set; }
            string Aviamento { get; set; }
            string NumerodaOperação { get; set; }

            [BsonId]
            int Id { get; set; }
            
        
    }
}