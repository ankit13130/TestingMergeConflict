using Microsoft.AspNetCore.Mvc;

namespace TestingMergeConflict.Controllers;

[Route("[Controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly List<string> employeeName =
    [
        "Ankit",
        "Naitik",
        "Ram",
        "Ganesh"
    ];
    //[HttpGet]
    //public IActionResult GetAllEmployee()
    //{
    //    return Ok(employeeName);
    //}
}
