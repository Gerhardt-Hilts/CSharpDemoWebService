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
        public ActionResult<string> Add(CalculatorRequest request)
        {
            var a = request.A;
            var b = request.B;
            
            return $"A: {a} B: {b}, a + b = {a + b}";
        }
        // POST api/calculator/subtract
        [HttpPost("subtract")]
        public ActionResult<string> Subtract(CalculatorRequest request)
        {
            var a = request.A;
            var b = request.B;
            
            return $"A: {a} B: {b}, a + b = {a - b}";
        }
        // POST api/calculator/multiply
        [HttpPost("multiply")]
        public ActionResult<string> Multiply(CalculatorRequest request)
        {
            var a = request.A;
            var b = request.B;
            
            return $"A: {a} B: {b}, a + b = {a * b}";
        }
        // POST api/calculator/divide
        [HttpPost("divide")]
        public ActionResult<string> Divide(CalculatorRequest request)
        {
            var a = request.A;
            var b = request.B;
            
            return $"A: {a} B: {b}, a + b = {a / b}";
        }
    }
}