using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using CodeStack.WebAPI.Data;
using CodeStack.WebAPI.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeStack.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase {
        private readonly CodeStackContext _context;
        // initiate database context  
        public OptionsController(CodeStackContext context) {
            _context = context;
        }

        [HttpPost("Contact")]
        public IActionResult Contact([FromBody] Contact contact) {
            try {
                _context.Contact.Add(contact);
                _context.SaveChanges();
                MailMessage mail = new MailMessage("ryan@codestackllc.com", "ryan@codestackllc.com");
                mail.IsBodyHtml = false;
                mail.Subject = "An email from CodeStackLLC.com";
                mail.Body = contact.FirstName + ' ' + contact.LastName + Environment.NewLine +
                    contact.EmailAddress + Environment.NewLine +
                    contact.PhoneNumber + Environment.NewLine + Environment.NewLine +
                    contact.Message;
                SmtpClient client = new SmtpClient("smtp.office365.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false; // Important: This line of code must be executed before setting the NetworkCredentials object, otherwise the setting will be reset (a bug in .NET)
                NetworkCredential cred = new System.Net.NetworkCredential("ryan@codestackllc.com", "vN99iwbv7!");
                client.Credentials = cred;
                client.Send(mail);
                return Ok(new { Data = "Email Sent" });
            } catch (Exception ex) {
                return BadRequest("Could Not Send Email: " + ex.Message.ToString());
            }
        }
    }
}