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
    [HttpPut]
    public IActionResult PutEmployee()
    {
        return Ok(employeeName);
    }

    [HttpPost]
    public IActionResult PostEmployee()
    {
        return Ok("added");
    }

    [HttpGet]
    public IActionResult GetAllEmployee()
    {
        return Ok(employeeName);

    }

    [HttpGet]
    public IActionResult GetEmployee()
    {
        return Ok(employeeName);

    }

    [HttpDelete]
    public IActionResult DeleteEmployee()
    {
        return Ok("Deleted");
    }


}
