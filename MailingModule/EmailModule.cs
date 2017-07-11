using System;
using System.Net;
using System.Net.Mail;

namespace MailingModule
{
    public class EmailModule : IMailingModule
    {
        private EmailServerConfiguration configuration;

        /// <summary>
        /// Creates mailing object instance 
        /// </summary>
        /// <param name="configuration"> Email server configureation </param>
        public EmailModule(EmailServerConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Sends email to the recipient
        /// </summary>
        /// <param name="recipient"></param>
        /// <returns> Return true if e-mail was successfully sent </returns>
        public bool Send(string recipient, string subject, string body)
        {
            try
            {
                var message = new MailMessage(configuration.Sender, recipient, subject, body);
                var smtpClient = new SmtpClient(configuration.SmtpDomain, configuration.Port);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(configuration.Sender, configuration.Password);
                smtpClient.EnableSsl = configuration.EnableSsl;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
