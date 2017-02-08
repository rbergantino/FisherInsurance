using Microsoft.AspNetCore.Mvc;
public class HomeownersController : Controller
{
 public IActionResult Index()
 {
 //return Ok("This is the index of the HomeownersController");
 return View();
 }
 public IActionResult Quote()
 {
 return Ok("This is the Quotes page of the HomeownersController");
 }
}