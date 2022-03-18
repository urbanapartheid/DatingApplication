using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        #region Variables
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        #endregion

        #region CTOR
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();

            return Ok(users);
        }

        [HttpGet("{username}")]
        public async Task<MemberDto> GetUser(string username)
        {
            return await _userRepository.GetMemberAsync(username);
        } 
        #endregion
    }
}
