using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSettings _emailSettings { get; }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            Execute(email, subject, message).Wait();
            return Task.CompletedTask;
        }
        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                string toEmail = string.IsNullOrEmpty(email)
                                 ? _emailSettings.ToEmail
                                 : email;
                MailMessage mail = new MailMessage()
                {
                    // From = new MailAddress(_emailSettings.UsernameEmail, "sutanto test dulu")
                    From = new MailAddress("sutanto.gasali@gmail.com", "sutanto test dulu")
                };
                mail.To.Add(new MailAddress(toEmail));
                //  mail.CC.Add(new MailAddress(_emailSettings.CcEmail));
                //  mail.Attachments.Add(new Attachment(Server.MapPath("~/myimage.jpg")));
                //mail.To.Add("test@email.com");
                //mail.To.Add("test2@email.com");
                // //You can send HTML e - mails, instead of the default plaintext mails
                //mail.IsBodyHtml = true;
                //mail.Body = "Testing <b>123!</b>";

                mail.Subject = "Personal Management System - " + subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                //using (SmtpClient smtp = new SmtpClient(_emailSettings.SecondayDomain, _emailSettings.SecondaryPort))
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    //smtp.Credentials = new NetworkCredential(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);
                    smtp.Credentials = new NetworkCredential("suzuki.sumber.mas.motor@gmail.com", "sutan168");
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                //do something here
            }
        }

    }
}
