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
    public void AdicionaCarro([FromBody] Carro carro)
    {
        carro.Id = id++;
        carros.Add(carro);
        Console.WriteLine(carro.Marca);
        Console.WriteLine(carro.Modelo);
    }
    [HttpGet]
    public IEnumerable<Carro> RecuperarCarros()
    {
        return carros;
    }

    [HttpGet]
    public Carro? RecuperaCarroPorId(int id)
    {
        return carros.FirstOrDefault(carro => carro.Id == id);
    }
}

