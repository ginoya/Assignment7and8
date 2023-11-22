using Assignment7.Utils;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assignment7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        private readonly IMath _math;

        public MathController(IMath math)
        {
            _math = math;
        }

        [HttpGet("add/{a}/{b}")]
        public double Add(double a, double b)
        {
            return _math.Add(a, b);
        }

        [HttpGet("subtract/{a}/{b}")]
        public double Subtract(double a, double b)
        {
            return _math.Subtract(a, b);
        }

        [HttpGet("multiply/{a}/{b}")]
        public double Multiply(double a, double b)
        {
            return _math.Multiply(a, b);
        }

        [HttpGet("divide/{a}/{b}")]
        public double Divide(double a, double b)
        {
            return _math.Divide(a, b);
        }
    }
}
