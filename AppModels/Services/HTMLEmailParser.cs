using Portofolio.AppModels.Models;
using Portofolio.Models;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
namespace Portofolio.AppModels.Services
{
    public class HTMLEmailParser : IEmailParserFromModelAsync<HTMLModel>
    {
        

        public async Task<MailRequest> ParseAsync(HTMLModel model)
        {
            var request = new MailRequest();
            request.ToEmail = model.ToEmail;
            request.Subject = "Portofolio Password Reset";
            string body = await model.GetHTMLAsync();
            body = body.Replace(model.PlaceHolder, model.PlaceHolderValue);
            request.Body = body;
            return request;
        }
    }
}