namespace BadBellyApi.Controllers
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    using Models;

    [ApiController]
    [Route("[controller]")]
    public class BadBellyController : ControllerBase
    {
        private readonly ILogger<BadBellyController> _logger;

        public BadBellyController(ILogger<BadBellyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ingredient> GetMostIntolerantIngredients()
        {
            var rng = new Random();
            return new List<Ingredient>
            {
                new Ingredient
                {
                    Name = "Cheese",
                    IntoleranceOutOfTen = 6
                },
                new Ingredient
                {
                    Name = "Gluten",
                    IntoleranceOutOfTen = 3
                }
            };
        }
    }
}
