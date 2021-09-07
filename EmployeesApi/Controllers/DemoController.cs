using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class DemoController : ControllerBase
    {
        // In the Url itself (RouteData)
        // GET /products/83989389

        [HttpGet("products/{sku:int}")]
        public ActionResult LookUpProduct(int sku)
        {
            return Ok($"Here is product {sku}");
        }
    }
}
