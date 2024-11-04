using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.IO;
namespace glossary1.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class GlossaryController: ControllerBase
{
private static List <GlossaryItem>Glossary = new
List<GlossaryItem>
{
new GlossaryItem
{
Term= "HTML",
Definition = "Hypertext Markup Language"
},
new GlossaryItem
{
Term= "MVC",
Definition = "Model View Controller"
},
new GlossaryItem
{
Term= "OpenID",
Definition = "An open standard for authentication"
}
};
[HttpGet]
public ActionResult<List<GlossaryItem>> Get()
{ return Ok(Glossary);
}
[HttpGet]
[Route("{term}")]
public ActionResult<GlossaryItem> Get(string term)
{
var glossaryItem = Glossary.Find(item =>
item.Term.Equals(term,
StringComparison.InvariantCultureIgnoreCase));
if (glossaryItem == null)
{
return NotFound();
} else
{ return Ok(glossaryItem);
}
}
}
}
