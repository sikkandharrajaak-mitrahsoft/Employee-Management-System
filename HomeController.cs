using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MyFirstApp.Models;
using System.Text.Json; 
namespace MyFirstApp.Controllers
{

  
    public class HomeController : Controller
    {
      private readonly EmployeeRepository employeeRepository;
     

      public HomeController(EmployeeRepository employeeRepository)
      {
        this.employeeRepository = employeeRepository;
        
      }
      // [HttpPost]
      // public IActionResult Post(EmployeeRequest employee)
      // {
      //  var employees=mapper.Map<Employee>(employee);

      //   employeeRepository.save(employees);
      //   return Ok();
      // }
      // [HttpGet]
      // public IActionResult Get()
      // {
      //   var employees = employeeRepository.GetAllEmployees();
      //   var employeeResponses = mapper.Map<List<EmployeeResponse>>(employees);
      //   return Ok(employeeResponses);
      // }
     [HttpPost]
     public IActionResult Reject([FromBody] RequestModel model){
          Console.WriteLine(model.reason);
          Console.WriteLine(model.status);
          Console.WriteLine(model.id);
          return Json(new { success = true });
     }    
     public IActionResult Accept(){
      return View();
     }
}}
