using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoDepartamento.Api.Data;
using ProjetoDepartamento.Api.Models;
using ProjetoDepartamento.Api.DTOs;


namespace ProjetoDepartamento.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DepartamentosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Departamento>>> GetDepartamento()
        {
            return await _context.Departamentos.ToListAsync();
        }
        [HttpPost]

        public async Task<IActionResult> CriarDepartamento (CriarDepartamentoDTO departamentoDto)
        {
            var novoDepartamento = new Departamento
            {
                Nome = departamentoDto.Nome,
                CodigoDeAcesso = departamentoDto.CodigoAcesso
            };

            _context.Departamentos.Add(novoDepartamento);

            await _context.SaveChangesAsync();

            return Ok("Deartamento criado com sucesso!");
        }
    }
}