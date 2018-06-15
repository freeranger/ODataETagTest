using System.Collections.Generic;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;

namespace ODataETagTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get(ODataQueryOptions oDataOptions)
        {
            return new[] { "value1", "value2" };
        }
    }
}
