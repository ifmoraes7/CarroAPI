using AutoMapper;
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
    private IMapper _mapper;

    public CarroController(CarroContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaCarro([FromBody] CreateCarroDto carroDto)
    {
        Carro carro = _mapper.Map<Carro>(carroDto);
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

    [HttpPut("{id}")]
    public IActionResult AtualizarCarro(int id, [FromBody] UpdateCarroDto carroDto)
    {
        var carro = _context.Carros.FirstOrDefault(
           carro => carro.Id == id);
        if(carro == null) return NotFound();
        _mapper.Map(carroDto,  carro);
        _context.SaveChanges();
        return NoContent();
    }
}

