using AutoMapper;
using AutoMapperAPI.DTOs;
using AutoMapperAPI.Models;

namespace AutoMapperAPI.Mapping;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<FuncionarioModel, FuncionarioDTO>()
			.ForMember(destino => destino.Sexo, map =>
			map.MapFrom(origem => origem.Sexo == SexoModel.Masculino ? "M" : "F"))
			.ForMember(destino => destino.NomeCompleto, map =>
			map.MapFrom(origem => $"{origem.Nome} {origem.Sobrenome}"))
			.ForMember(destino => destino.IsAtivo, origem =>
			origem.MapFrom(origem => origem.Salario > 0 ? true : false))
			.ReverseMap();

		CreateMap<EnderecoModel, EnderecoDTO>();

		CreateMap<UserModel, UserDTO>()
			.ForMember(destination => destination.FullName, map =>
			map.MapFrom(source => $"{source.FirstName} {source.LastName}"))
			.ReverseMap();
	}
}
