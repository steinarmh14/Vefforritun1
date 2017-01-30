using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Project4.Utilities
{
    public class EmailLogMedia : LogMedia
    {
        public override void LogMessage(string message)
        {
            try
            {
                using(MailMessage theMessage = new MailMessage())
                {
                    theMessage.To.Add(ConfigurationManager.AppSettings["Email"]);
                    theMessage.Subject = "Error";
                    theMessage.Body = message;
                    using(SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.Send(theMessage);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}