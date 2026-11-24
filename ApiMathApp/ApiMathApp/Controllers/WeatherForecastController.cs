using Microsoft.AspNetCore.Mvc;

namespace ApiMathApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        leason1.Math clsMathService = new leason1.Math();

        [HttpGet("percent")]
        public double GetPercent(double num, double percent) => clsMathService.percent(num, percent);

        [HttpGet("multiply")]
        public double GetMultiply(double num1, double num2) => clsMathService.multiply(num1, num2);

        [HttpGet("divide")]
        public double GetDivide(double num1, double num2) => clsMathService.divide(num1, num2);

        [HttpGet("subtract")]
        public double GetSubtract(double num1, double num2) => clsMathService.subtract(num1, num2);

        [HttpGet("sum2")]
        public int GetSum(int num1, int num2) => clsMathService.sum(num1, num2);

        [HttpPost("sumArray")]
        public double GetSumArray([FromBody] double[] numbers) => clsMathService.sumArray(numbers);

        [HttpPost("count")]
        public int GetCount([FromBody] double[] numbers) => clsMathService.count(numbers);

        [HttpPost("max")]
        public double GetMax([FromBody] double[] numbers) => clsMathService.max(numbers);

        [HttpPost("min")]
        public double GetMin([FromBody] double[] numbers) => clsMathService.min(numbers);

        [HttpGet("factorial")]
        public int GetFactorial(int num) => clsMathService.factorial(num);

        [HttpGet("intDivision")]
        public int GetIntDivision(int num1, int num2) => clsMathService.intDivision(num1, num2);

        [HttpGet("modulus")]
        public int GetModulus(int num1, int num2) => clsMathService.modulus(num1, num2);

        [HttpGet("reversePercent")]
        public double GetReversePercent(double val, double percent) => clsMathService.reversePercent(val, percent);

    }
}
