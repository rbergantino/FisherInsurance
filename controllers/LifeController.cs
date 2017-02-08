using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
public class LifeController : Controller
{
 public IActionResult Index()
 {
 //return Ok("This is the index of the LifeController");
 return View();
 }
 public IActionResult Quote()
 {
 //return Ok("This is the Quotes page of the LifeController");
 Quote quote = new Quote
{
 Id = 345,
 Product = "Life Insurance",
 ExpireDate = DateTime.Now.AddDays(45),
 Price = 45.00M
 };
 return View(quote);
 }
}