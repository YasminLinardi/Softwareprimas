using LiteDB;

namespace Modelos
{
        public class Acabamento
    {
            string Acabamentos { get; set; }
            string Aviamentos { get; set; }
            string NumerodaOperação { get; set; }

            [BsonId]
            int Id { get; set; }

        
        
    }
}