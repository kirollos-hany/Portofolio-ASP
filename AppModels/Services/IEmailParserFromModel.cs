using Portofolio.Models;
namespace Portofolio.AppModels.Services
{
    public interface IEmailParserFromModel<T> where T : class
    {
        MailRequest Parse(T model);
    }
}