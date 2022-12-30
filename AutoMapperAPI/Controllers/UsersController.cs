using AutoMapper;
using AutoMapperAPI.DTOs;
using AutoMapperAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Post(UserModel user)
        {
            var userDto = _mapper.Map<UserDTO>(user);

            return Ok(userDto);
        }
    }
}
