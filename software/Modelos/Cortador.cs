using LiteDB;

namespace Modelos
{
        public class Cortador
    {
            string Nome { get; set; }

            [BsonId]
            int Id { get; set; }
                
    
    }
}