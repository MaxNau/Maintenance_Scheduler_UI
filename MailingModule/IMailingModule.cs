
namespace MailingModule
{
    interface IMailingModule
    {
        bool Send(string recipient, string subject, string body);
    }
}
