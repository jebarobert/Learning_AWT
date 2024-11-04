using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMvcApp.Models;
namespace MyMvcApp.Controllers
{
public class HomeController : Controller
{
public async Task <IActionResult>Index()
{
var model= new StockQuote{ Symbol="HELLO", Price=3200};
return View(model);
}
}
} 