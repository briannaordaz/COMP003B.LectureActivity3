using Microsoft.AspNetCore.Mvc;
using COMP003B.LectureActivity3.Models;


namespace COMP003B.LectureActivity3.Controllers;


// The StoreController class is a controller that handles requests for the store section of the website.
//The [Route("store")] attribute specifies that the controller will handle requests that start with "/store".
[Route("store")]

public class StoreController : Controller
{
    // Get: store/product/5
    [Route("product/{id:int")]
    public IActionResult ViewProduct(int id)
    {
        // The View() method returns a view result that renders a view to the response.
        // The id parameter is passed to the view.
        return ViewProduct(id);
    }
    
    // Get: store/product/search?category=electronics
    [HttpGet("product/search")]
    public IActionResult Search([FromQuery] string category)
    {
        // The View() method returns a view result that renders a view to the response.
        // The category parameter is passed to the view.
        // The category parameter is retrieved from the query string.
        // The [FromQuery] attribute specifies that the parameter should be bound using the query string.
        return ViewProduct("Search", category);
    }
}