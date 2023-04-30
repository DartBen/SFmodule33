using Microsoft.AspNetCore.Mvc;

namespace SFmosule33.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        public UserController(ILogger logger)
        {
            _logger = logger;
            _logger.WriteEvent("Сообщение о событии в программе");
            _logger.WriteError("Сообщение об ошибки в программе");

            _logger.WriteEventLogToFile("Сообщение о событии в программе");
            _logger.WriteErrorLogToFile("Сообщение об ошибки в программе");
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
    }
}
