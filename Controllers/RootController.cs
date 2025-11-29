using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TrilhaApiDesafio.Controllers;

[ApiController]
[Route("/")]
public class RootController:Controller
{
    [HttpGet]
    public IActionResult RedirectToSwagger()
    {

        return Redirect("/swagger");
        
    }
}
