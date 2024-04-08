using Microsoft.AspNetCore.Mvc;
using System;
namespace accounts.Controller 
{    class HomeController : Controller
    {
        public IActionResult among(){
        return Ok("C# function executed successfully!");
        }
    }
}