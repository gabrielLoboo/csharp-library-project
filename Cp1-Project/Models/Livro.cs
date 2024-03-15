using System;
using Cp1_Project.Interfaces;

namespace Cp1_Project.Models
{
    public class Livro : IBibliotecaItem
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }

        public Livro(string titulo, string autor, int isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}");
        }

        public override string ToString()
        {
            return $"Título do Livro: {Titulo}, Autor: {Autor}, ISBN: {ISBN}";
        }
    }
}