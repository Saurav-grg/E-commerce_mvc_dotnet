using Microsoft.AspNetCore.Mvc;
using Ecom_mvc.Models;
public class CartController : Controller
{
 public IActionResult Index()     // This will be accessed as /Cart
    {
        return View();
    }
}