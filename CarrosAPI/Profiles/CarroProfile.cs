using CarrosAPI.Data.Dtos;
using CarrosAPI.Models;

namespace CarrosAPI.Profile;

public class CarroProfile : Profile
{
    public CarroProfile()
    {
        CreateMap<CreateCarroDto, Carro>();
    }
}
