using Microsoft.AspNetCore.Mvc.ViewFeatures;
namespace Portofolio.AppModels.Services
{
    public interface IDisplayOutput
    {
        void DisplayOutput(ViewDataDictionary viewData, bool isSuccess, string message);
    }
}