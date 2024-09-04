using LiteDB;

namespace Modelos
{
        public class Materia
    {
        public object Unidade { get; internal set; }
        string Nome { get; set; }
        string Valor { get; set; }
        string ValorUnidade { get; set; }
        
        [BsonId]
        int Id { get; set; }

            
    }
}