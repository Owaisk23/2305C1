using email.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace email.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("sajidasharmeen45@gmail.com", "eikjfbyhmpqhuqxl");

            MailMessage msg = new MailMessage("sajidasharmeen45@gmail.com", "ammaraptech02@gmail.com");
            msg.Subject = "Login Activated";
            msg.Body = "Dear User, your login credentials have been activated. Kindly login to continue";

            // msg.Attachments.Add(new Attachment(PathToAttachment));
            client.Send(msg);

            ViewBag.message = "Mail sent successfully, Role assigned";


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
