using CarrosAPI.Data.Dtos;
using CarrosAPI.Models;
using AutoMapper;

namespace CarrosAPI.Profiles;

public class CarroProfile : Profile
{
    public CarroProfile()
    {
        CreateMap<CreateCarroDto, Carro>();
        CreateMap<UpdateCarroDto, Carro>();
    }
}
