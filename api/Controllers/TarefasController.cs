using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers {

    [Route ("api/[Controller]")]
    public class TarefasController : ControllerBase {

        private readonly DataContext _context;

        public TarefasController (DataContext context) {
            this._context = context;
        }

        [HttpGet ("listartarefas")]
        public async Task<ActionResult> listarfilmes () {
            var tarefas = await _context.Tarefas.ToListAsync ();
            return Ok (tarefas);
        }
    }
}