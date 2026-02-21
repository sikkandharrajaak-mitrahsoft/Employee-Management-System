// // using MailKit.Net.Smtp;
// // using MailKit.Security;
// // using Microsoft.AspNetCore.Authorization;
// // using Microsoft.AspNetCore.Mvc;
// // using Microsoft.IdentityModel.Tokens;
// // using MimeKit;
// // using MyFirstApp.Models;
// // using Serilog;
// // using System.Diagnostics;
// // using System.IdentityModel.Tokens.Jwt;
// // using System.Security.Claims;
// // using System.Text;

// // namespace MyFirstApp.Controllers
// // {

// //   [ApiController]
// //   [Route("[controller]/api")]
// //     public class HomeController : ControllerBase
// //     {
// //       private readonly RequestDelegate global;

// // public HomeController(RequestDelegate global){

// //   this.global=global;
// // }
// //        private readonly IConfiguration configuration;

// //        public HomeController(IConfiguration configuration){

// //         this.configuration=configuration;
// //        }
// //      public IActionResult Goto()
// //         {
// //             return View();
// //         }
// // public async Task handleException(HttpContext context){

// //       try
// //       {
// //         await global(context);
// //       }
// //       catch{
// //        context.Response.StatusCode=500;
// //        context.Response.ContentType="application/json";
// //        var respnse =new{
// //       status="hi hello",


// //        };
 

// //       }
// // }




// // [HttpGet("/get")]
// // public IActionResult getstatement(){

// //   Log.Information("Section find succesfull{Time}",DateTime.Now);
// //   return Ok("Hi How are u");

// // }



// //      [HttpPost]
// //      public IActionResult sendemail(string to,string subject,string body){
// //      var email=new MimeMessage();
// //      email.From.Add(new MailboxAddress(configuration["MailConfiguration:SenderName"],configuration["MailConfiguration:SenderEmail"]));
// //      email.To.Add(MailboxAddress.Parse(to));
// //      email.Subject=subject;
// //      email.Body=new TextPart("Plain"){
// //        Text=body
// //      };
// //     using var smtp=new SmtpClient();
// //      smtp.Connect(configuration["MailConfiguration:Server"], Convert.ToInt32(configuration["MailConfiguration:Port"]), SecureSocketOptions.StartTls);
// //      smtp.Authenticate(configuration["MailConfiguration:Username"], configuration["MailConfiguration:Password"]);
// //      smtp.Send(email);
// //      smtp.Disconnect(true);
// //             return View();
//     }       
// }}
