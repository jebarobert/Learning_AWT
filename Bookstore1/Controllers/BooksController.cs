using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookstore1.Models;
using System.Collections.Generic;
namespace Bookstore1.Controllers
{
public class BooksController:Controller
{
public IActionResult Index()
{
return View();
}
public IActionResult Details()
{
Book book=new Book()
{
 Id=1,
 Title="ASP.NET Core 3.1",
 Genre="Programming for Web Development",
 Price=300,
 PublishDate=new System.DateTime(2019,12,28),
 Authors=new List<string>{"Ajay","Atul"}
};
return View(book);
}
}
}
