using mf_desenvolvimento_dev_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_desenvolvimento_dev_backend.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        {
            var dados = await _context.Usuario.ToListAsync();
            return View(dados);
        }
    }
}
