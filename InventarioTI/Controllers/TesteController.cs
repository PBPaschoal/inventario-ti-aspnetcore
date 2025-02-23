namespace InventarioTI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using InventarioTI.Data; // Importa seu DbContext
    using System.Linq;
    using InventarioTI.Data.InventarioTI.Data;

    [Route("api/teste")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TesteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dados = _context.Equipamentos.ToList(); // Substitua NomeDaTabela pela sua entidade
            return Ok(dados);
        }
    }
}
