using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using api.Data;
using api.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace api.Controllers {
    
    [Route ("[Controller]")]
    [ApiController]
    public class TarefasController : ControllerBase {

        private readonly DataContext _context;

        public TarefasController (DataContext context) {
            this._context = context;
        }

        [HttpGet ("listarTarefas")]
        public async Task<ActionResult> GetTarefas() {
            var tarefas = await _context.Tarefas.ToListAsync ();
            return Ok (tarefas);
        }
    }
}