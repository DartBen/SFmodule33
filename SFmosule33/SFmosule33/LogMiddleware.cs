namespace SFmosule33
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string IpAdress = httpContext.Connection.RemoteIpAddress.ToString();
            _logger.WriteEvent($"Сообщение из LogMiddleware. Ip - {IpAdress}");
            await _next(httpContext);
        }
    }
}
