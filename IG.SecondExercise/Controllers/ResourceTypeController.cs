using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace IG.SecondExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceTypeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return typeof(Enum.ResourceTypes).GetEnumNames().ToList();
        }
    }
}