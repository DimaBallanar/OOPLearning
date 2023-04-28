using Microsoft.AspNetCore.Mvc;
using OnlineShop.Repository;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository m_userRepository;
        public UserController(UserRepository userRepository)
        {
            m_userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(m_userRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
