using Microsoft.AspNetCore.Mvc;

namespace SingletonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CounterController : ControllerBase
    {

        private readonly ICounterService _counterService;

        public CounterController(ICounterService counterService)
        {
            _counterService = counterService;
        }

        [HttpGet(Name = "GetCounter")]
        public int Get()
        {
            _counterService.Increment();

            return _counterService.Valor;
        }
    }
}
