using LiteDB;

namespace Modelos
{
        public class Materia
    {
        string Nome { get; set; }
        string Valor { get; set; }
        string ValorUnidade { get; set; }
        
        [BsonId]
        int Id { get; set; }

            
    }
}