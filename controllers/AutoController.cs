using Microsoft.AspNetCore.Mvc;
public class AutoController : Controller
{
 public IActionResult Index()
 {
 //return Ok("This is the index of the AutoController");

 return View();
 }
 public IActionResult Quote()
 {
 return Ok("This is the Quotes page of the AutoController");
 }
}