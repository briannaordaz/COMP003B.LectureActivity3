using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers;

// The [Route("product")] attribute specifies that the controller will handle requests that start with "/product"
[Route("product")]

public class ProductController : Controller
{
    // Get: product/create
    [HttpGet("create")]
    public IActionResult Create()
    {
        // The View() method returns a view result that renders a view to the response.
        return View();
    }
    
    // Post: product/create
    [HttpPost("create")]
    public IActionResult Create([FromForm] Product product)
    {
        // The ModelState.IsValid property checks if the model state is valid.
        if (!ModelState.IsValid)
        {
            return View(product);
        }
        
        // The RedirectToAction() method returns a redirect result that redirects to an action.
        return RedirectToAction("Success", product);
    }
    
    // Get: product/success
    [Route("success")]
    public IActionResult Success(Product product)
    {
        // The View() method returns a view result that renders a view to the response.
        return View(product);
    }
}