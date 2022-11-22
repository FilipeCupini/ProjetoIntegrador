using ImobiliariaProjeto.Data;
using ImobiliariaProjeto.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaProjeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorretorController : ControllerBase
    {
        private CorretorContext _context;

        public CorretorController(CorretorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Corretor> GetCorretor()
        {
            return _context.Corretores;
        }

        [HttpPost]
        public IActionResult AdicionarCorretor([FromBody] Corretor corretor)
        {
            _context.Corretores.Add(corretor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { Id = corretor.Id }, corretor);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Corretor corretor = _context.Corretores.FirstOrDefault(corretor => corretor.Id == id);

            if (corretor != null)
            {
                return Ok(corretor);
            }
            return BadRequest();
        }

    }
}
