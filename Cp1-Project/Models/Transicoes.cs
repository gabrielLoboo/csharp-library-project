using Cp1_Project.Interfaces;

namespace Cp1_Project.Models
{
    public class Transicoes
    {
        public IBibliotecaItem BibliotecaItem{ get; set; }
        public Cliente Cliente{ get; set; }
        public DateTime DataTransacao{ get; set; }
        public string TipoTransacao{ get; set; } // Exemplo: Empréstimo, Devolução, Renovação, etc.

        public Transicoes(IBibliotecaItem bibliotecaItem, Cliente cliente, DateTime dataTransacao, string tipoTransacao)
        {
            BibliotecaItem = bibliotecaItem;
            Cliente = cliente;
            DataTransacao = dataTransacao;
            TipoTransacao = tipoTransacao;
        }

    }
}
