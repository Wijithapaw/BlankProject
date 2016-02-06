using BlankProject.Domain;
using BlankProject.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BlankProject.Services
{
    public class EmailService: IEmailService
    {  
        public void Send(string to, string subject, string body)
        {
            var email = new MailMessage
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            email.To.Add(to);

            Send(email);

            email.Dispose();
        }

        public void Send(MailMessage email)
        {
            email.From = new MailAddress("noreply@blank-project.com", "Blank Project Team");
            email.Sender = new MailAddress("noreply@blank-project.com", "Blank Project Team");

            email.Bcc.Add("blank-project@yopmail.com");

            using (var client = new SmtpClient())
            {
                client.Send(email);
            }
        }
    }
}
