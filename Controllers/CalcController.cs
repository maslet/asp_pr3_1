using Microsoft.AspNetCore.Mvc;
using usov_402_lr3.Services;

namespace usov_402_lr3.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CalcController : ControllerBase {
        private readonly CalcService _calcService;
        public CalcController(CalcService calcService) {
            _calcService = calcService;
        }
        [HttpGet("add")]
        public IActionResult Add(double x, double y) {
            return Ok(_calcService.Add(x, y));
        }
        [HttpGet("subtract")]
        public IActionResult Subtract(double x, double y) {
            return Ok(_calcService.Subtract(x, y));
        }
        [HttpGet("multiply")]
        public IActionResult Multiply(double x, double y) {
            return Ok(_calcService.Multiply(x, y));
        }
        [HttpGet("divide")]
        public IActionResult Divide(double x, double y) {
            try {
                return Ok(_calcService.Divide(x, y));
            }
            catch (ArgumentException e) {
                return BadRequest(e.Message);
            }
        }
    }
}
