namespace Cp1_Project.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int ClienteId { get; set; }

        public Cliente(string nome, int clienteId)
        {
            Nome = nome;
            ClienteId = clienteId;
        }
    }
}
