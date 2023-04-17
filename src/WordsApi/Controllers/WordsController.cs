using Microsoft.AspNetCore.Mvc;

namespace WordApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        string[] words = new string[] { "hi", "yo", "chow", "hello" };

        private readonly ILogger<WordController> _logger;

        public WordController(ILogger<WordController> logger) => _logger = logger;

        [HttpGet]
        [Route("")]
        public string GetWord() => words[new Random().Next(0, 3)];
    }
}