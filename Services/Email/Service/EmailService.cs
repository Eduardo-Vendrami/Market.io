﻿using System.Net;
using System.Net.Mail;

namespace CRUD_Products.Services.Email.Service
{
    public class EmailService : IEmailService
    {
        public async Task<string> SendEmail(
            string address)
        {

            var message = new MailMessage
            {
                From = new MailAddress("eduardovlmartins@outlook.com"),
                To = { address },
                Subject = "Código de confirmação",
                Body = "TESTE"
            };

            var smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("eduardovlmartins@outlook.com", "74774172Du."),
                EnableSsl = true
            };

            try
            {
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {

                throw;
            }

            return "E-mail enviado com sucesso";
        }
    }
}