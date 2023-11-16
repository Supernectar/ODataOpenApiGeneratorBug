using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace WebApplication1;

public class CustomersController : ODataController
{
    public ActionResult<List<Customer>> Get()
    {
        return Ok(new List<Customer>()
            {
                new() {
                    Id = Guid.NewGuid(),
                    Name = "Name1",
                },
                new() {
                    Id = Guid.NewGuid(),
                    Name = "Name2",
                }
            }
        );
    }
}