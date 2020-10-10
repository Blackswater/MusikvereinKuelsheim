using Database.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Mail;
using System.Text;

namespace MusikvereinKuelsheimServices
{
    public class SendEmailForReserve
    {
        public void Send(MailMessage message);

        public static void CreateReserveMessage(string server, ContactData contactData)
        {
            var to = contactData.EMail;
            String from = "noreply@musikvereineintrachtkuelsheim.de";

            MailMessage message = new MailMessage(from, to);chrome://vivaldi-webui/startpage?section=Speed-dials&activeSpeedDialIndex=0&background-color=#2e2e2e
            message.Subject = "Ihre Reservierung für das Konzert";
            message.Body = @"Test MEssage";
            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
