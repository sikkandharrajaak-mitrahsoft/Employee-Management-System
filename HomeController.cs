using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MyFirstApp.Models;
using System.Text.Json; 
namespace MyFirstApp.Controllers
{

  
    public class HomeController : Controller
    {
      private readonly EmployeeRepository employeeRepository;
      private  readonly ApplicationDbContext Context;     

      public HomeController(EmployeeRepository employeeRepository,ApplicationDbContext Context )
      {
        this.employeeRepository = employeeRepository;
        this.Context=Context;
        
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

     public IActionResult Employee(int id){
      var dept=Context.dept.FromSqlRaw("Exec SelectDepartments").AsNoTracking().ToList();
       
       var SelectDept=new EmployeeViewModel{
        Id=id,
        Name="Rajaak",
        DepartmentId=1,
        Departments=new SelectList(dept,"id","DeptName",1)


       };

     return View(SelectDept);

     }


}}
