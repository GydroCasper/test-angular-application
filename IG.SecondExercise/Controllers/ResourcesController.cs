using System.Collections.Generic;
using System.Linq;
using IG.SecondExercise.Dto;
using Microsoft.AspNetCore.Mvc;

namespace IG.SecondExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        [HttpPost("check")]
        public List<(string ResourceType, int Amount)> Check([FromBody] Store value)
        {
            var result = new List<(string ResourceType, int Amount)>();
            if (value?.Provider == null || !value.Provider.Any()) return result;

            var provider = value.Provider.ToDictionary(x => x.ResourceType, x => x.Amount);


            foreach (var requirement in value.Demand)
            {
                if (provider.ContainsKey(requirement.ResourceType))
                {
                    result.Add(
                        (
                            requirement.ResourceType.ToString("g"), 
                            provider[requirement.ResourceType] > requirement.Amount ? requirement.Amount : provider[requirement.ResourceType]
                            )
                        );
                }
            }

            return result;
        }
    }
}
