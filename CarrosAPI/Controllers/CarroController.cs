using CarrosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net.NetworkInformation;

namespace CarrosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    private static List<Carro> carros = new List<Carro>();
    private static int id = 0;
    [HttpPost]
    public IActionResult AdicionaCarro([FromBody] Carro carro)
    {
        carro.Id = id++;
        carros.Add(carro);
        return CreatedAtAction(nameof(RecuperaCarroPorId),
            new { id = carro.Id },
            carro);

    }
    [HttpGet]
    public IEnumerable<Carro> RecuperarCarros([FromQuery] int skip = 0, [FromQuery] int take = 5)
    {
        return carros.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaCarroPorId(int id)
    {
        var carro = carros.FirstOrDefault(carro => carro.Id == id);
        if (carro == null) return NotFound();
        return Ok();
    }
}

