using LiteDB;

namespace Modelos
{
        public class Cliente
        {
                string Nome { get; set; }
                string Telefone { get; set; }
                string CPF { get; set; }
                string Email { get; set; }
                string Endereço { get; set; }

                [BsonId]
                int Id { get; set; }

        }
}