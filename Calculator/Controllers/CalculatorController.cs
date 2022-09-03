using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorContext _db;
        public CalculatorController(CalculatorContext context)
        {
            _db = context;
        }

    }
}
