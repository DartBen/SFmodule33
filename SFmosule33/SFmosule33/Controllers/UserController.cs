using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace SFmosule33.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        private ILogger _logger;
        private IUserRepository _userRepository;
        public UserController(ILogger logger, IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _userRepository = userRepository;
            _logger.WriteEvent("Сообщение о событии в программе");
            _logger.WriteError("Сообщение об ошибки в программе");
            _userRepository = userRepository;
        }
        [HttpGet]
        public User GetUser()
        {

            return new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "TestName",
                LastName = "TestLastName",
                Email = "Test@mail.ru",
                Login = "TestLogin",
                Password = "12345678"
            };
        }

        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };

            var userViewModel = _mapper.Map<UserViewModel>(user);

            return userViewModel;
        }

    }
}
