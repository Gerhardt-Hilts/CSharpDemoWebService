using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorApi.Models;

namespace SimpleCalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // POST api/calculator/add
        [HttpPost("add")]
        public ActionResult<string> Post(CalculatorRequest request)
        {
            var a = request.A;
            var b = request.B;
            
            return $"A: {a} B: {b}";
        }
    }
}