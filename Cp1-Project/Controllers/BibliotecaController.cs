using Cp1_Project.Interfaces;
using Cp1_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cp1_Project.Controllers
{
    public class BibliotecaController : Controller
    {

        private readonly List<IBibliotecaItem> _bibliotecaItems;

        public BibliotecaController()
        {
            // Inicializando a lista de itens da biblioteca (simulação)
            _bibliotecaItems = new List<IBibliotecaItem>
            {
                 new Livro("Harry Potter", "J. K. Rowling", 123456),
                new Gibi("Turma da monica", "Panini", 10)
            };
        }

        public IActionResult Index()
        {
            {
                return View(_bibliotecaItems);
            }
            
        }
        public IActionResult Details(int id)
        {
            var item = _bibliotecaItems[id];
            return View(item);
        }
    }
}
