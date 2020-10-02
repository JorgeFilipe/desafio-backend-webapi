using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using api.Data;
using api.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers {

    [Route ("[Controller]")]
    [ApiController]
    public class TarefasController : ControllerBase {

        private readonly DataContext _context;

        public TarefasController (DataContext context) {
            this._context = context;
        }

        // https://localhost:5001/tarefas/listarTarefas
        // Lista todas as tarefas
        [HttpGet ("listarTarefas")]
        public async Task<ActionResult> GetTarefas () {
            var tarefas = await _context.Tarefas.ToListAsync ();
            return Ok (tarefas);
        }

        // https://localhost:5001/tarefas/buscarTarefa/{id}
        // Busca uma tarefa por Id
        [HttpGet ("buscarTarefa/{id}")]
        public async Task<ActionResult<TarefasController>> id (int id) {
            var tarefa = await _context.Tarefas.FindAsync (id);

            if (tarefa == null) {
                return NotFound ();
            }

            return Ok (tarefa);
        }

        /*[HttpDelete ("deletar/{id}")]
        public async Task<ActionResult<Tarefa>> DeleteTarefas(int id) {

            var tarefas = await _context.Tarefas.FindAsync (id);

            if (tarefas == null) {
                return NotFound ();
            }

            _context.Tarefas.Remove(tarefas);
            await _context.Tarefas.SaveChangesAsync();

            return tarefas;
        }*/
    }
}