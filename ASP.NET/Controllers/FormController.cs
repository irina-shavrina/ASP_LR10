using Microsoft.AspNetCore.Mvc;

public class FormController : Controller
{
    [HttpGet]
    public IActionResult Form() => View();


    [HttpPost]
    public IActionResult Form(ConsultationRequest model) => (ModelState.IsValid) ? View("Ok") : View(model);

    public IActionResult Ok() => View();
    
}