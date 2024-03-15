using Cp1_Project.Interfaces;

namespace Cp1_Project.Models
{
    public class Gibi : IBibliotecaItem
    {
        public string Titulo { get; set; }
        public string Editora{ get; set; }
        internal int Numero_Emissao { get; set; }

        public Gibi(string titulo, string editora, int numero_emissao)
        {
            Titulo = titulo;
            Editora = editora;
            Numero_Emissao = numero_emissao;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Titulo: {Titulo}, Editora: {Editora}, Numero_Emissao: {Numero_Emissao}");
        }
    }
}
