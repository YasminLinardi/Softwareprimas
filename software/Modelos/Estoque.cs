using System.Reflection.Metadata;
using LiteDB;

namespace Modelos
{
        public class Estoque
    {
            string  Quantidade { get; set; }
            string Cliente { get; set; }
            string NumerodeOperação { get; set; }

            [BsonId]
            int Id { get; set; }

    
        
    }
}