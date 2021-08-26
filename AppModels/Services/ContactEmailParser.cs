using Portofolio.Models;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
namespace Portofolio.AppModels.Services
{
    public class ContactEmailParser : IEmailParserFromModel<Contact>
    {
        private readonly MailSettings mailSettings;
        public ContactEmailParser(IOptions<MailSettings> mailSettings)
        {
            this.mailSettings = mailSettings.Value;
        }
        public MailRequest Parse(Contact contact)
        {
            var request = new MailRequest();
            request.ToEmail = mailSettings.Mail;
            request.Subject = "Service Request";
            string body = $"Contact name: {contact.ContactName}<br>Contact message: {contact.Message}<br>Requested Services:<br>";
            foreach (var service in contact.RequestedServices)
            {
                body += $"{service.AssociatedService.ServiceName}<br>";
            }
            body += $"Contact phone number: {contact.Phone}<br>";
            body += $"Contact email: {contact.Email}<br>";
            request.Body = body;
            return request;
        }
    }
}