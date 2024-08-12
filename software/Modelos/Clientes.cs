using LiteDB;

namespace Modelos
{
        public class Clientes
    {
            string Nome  { get; set; }
            string Telefone  { get; set; }
            string CPF  { get; set; }
            string Email  { get; set; }
            string Endereço  { get; set; }
           
            [BsonId]
            int Id  { get; set; }
    
    }
}