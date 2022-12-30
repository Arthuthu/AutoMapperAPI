using AutoMapper;
using AutoMapperAPI.DTOs;
using AutoMapperAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public FuncionariosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Post(FuncionarioModel funcionario)
        {
            var funcionarioDto = _mapper.Map<FuncionarioDTO>(funcionario);

            return Ok(funcionarioDto);
        }
    }
}
