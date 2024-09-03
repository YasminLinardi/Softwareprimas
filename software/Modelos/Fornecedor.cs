using LiteDB;

namespace Modelos
{

        public class Fornecedores ; pessoa
    {
        string Nome { get; set; }
        string Telefone { get; set; }
        string CNPJ { get; set; }
        string Email { get; set; }
        string QualMateria { get; set; }
        string PreçodaMateria { get; set; }

        [BsonId]
        int Id { get; set; }
        
    }
}
