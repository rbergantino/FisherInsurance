using Microsoft.AspNetCore.Mvc;

public class CustomerCareController : Controller
{
 public IActionResult Index()
 {
    return Ok("This is the index of the CustomerCareController");
 }


public IActionResult Quote()
 {
    return Ok("This is the Quote page of the CustomerCareController");
 }

public IActionResult Claims()
 {
    return Quote();
 }

}