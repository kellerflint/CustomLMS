using Microsoft.AspNetCore.Mvc;

namespace CustomLMSAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new TestObject("hi"));
        }
    }

    class TestObject
    {
        public TestObject(string word)
        {
            Word = word;
        }
        public string Word { get; set; }
    }
}
