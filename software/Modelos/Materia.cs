using LiteDB;

namespace Modelos
{
        public class Materia
    {
        string Nome { get; set; }
        string Tipo { get; set; }
        string ValorUnidade { get; set; }
        string CodigodaMateria { get; set; }

        [BsonId]
        int Id { get; set; }

            
    }
}