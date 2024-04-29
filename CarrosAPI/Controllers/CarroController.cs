using CarrosAPI.Data;
using CarrosAPI.Data.Dtos;
using CarrosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net.NetworkInformation;

namespace CarrosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    private CarroContext _context;

    public CarroController(CarroContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AdicionaCarro([FromBody] CreateCarroDto carroDto)
    {

        _context.Carros.Add(carro);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaCarroPorId),
            new { id = carro.Id },
            carro);

    }
    [HttpGet]
    public IEnumerable<Carro> RecuperarCarros([FromQuery] int skip = 0, [FromQuery] int take = 5)
    {
        return _context.Carros.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaCarroPorId(int id)
    {
        var carro = _context.Carros.FirstOrDefault(carro => carro.Id == id);
        if (carro == null) return NotFound();
        return Ok();
    }
}

