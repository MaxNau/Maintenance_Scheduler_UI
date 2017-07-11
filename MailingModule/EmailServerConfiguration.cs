
namespace MailingModule
{
    public class EmailServerConfiguration
    {
        public string Sender { get; set; }
        public string SmtpDomain { get; set; }
        public short Port { get; set; }
        public bool EnableSsl { get; set; }
        public string Password { get; set; }

        public EmailServerConfiguration(string sender, string smtpDomain, short port,
            bool enableSsl, string password)
        {
            Sender = sender;
            SmtpDomain = smtpDomain;
            Port = port;
            EnableSsl = enableSsl;
            Password = password;
        }
    }
}
