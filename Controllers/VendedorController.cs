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
    public class VendedorController : ControllerBase
    {
        private VendedorContext _context;

        public VendedorController(VendedorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Vendedor> GetVendedor()
        {
            return _context.Vendedores;
        }

        [HttpPost]
        public IActionResult AdicionarVendedor([FromBody] Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { Id = vendedor.Id }, vendedor);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Vendedor vendedor = _context.Vendedores.FirstOrDefault(vendedor => vendedor.Id == id);

            if (vendedor != null)
            {
                return Ok(vendedor);
            }
            return BadRequest();
        }

    }
}
