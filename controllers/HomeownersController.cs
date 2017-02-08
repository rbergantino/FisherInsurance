using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
public class HomeownersController : Controller
{
 public IActionResult Index()
 {
 //return Ok("This is the index of the HomeownersController");
 return View();
 }
 public IActionResult Quote()
 {
 //return Ok("This is the Quotes page of the HomeownersController");
 Quote quote = new Quote
{
    Id = 345,
    Product = "Home Insurance",
    ExpireDate = DateTime.Now.AddDays(45),
    Price = 45.00M
 };
   return View(quote);

 }
}