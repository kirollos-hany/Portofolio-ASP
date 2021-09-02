using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Json.Net;
using Portofolio.ViewModels;
using static Portofolio.AppModels.Utils.KeyConstants;
namespace Portofolio.AppModels.Extensions
{
    public static class ModelStateExtension
    {
        public static string GetErrors(this ModelStateDictionary modelState)
        {
            string errors = string.Join("\n", modelState.Values.SelectMany((ms) =>
            {
                return ms.Errors.Select((err)=>{
                    return err.ErrorMessage;
                });
            }));
            return errors;
        }

        public static void AssignTempDataWithErrors(this ModelStateDictionary modelState, ITempDataDictionary tempData)
        {
            tempData[ResultMessageKey] = JsonNet.Serialize(new ResultMsgViewModel
            {
                Message = modelState.GetErrors(),
                CssClass = ResultMsgViewModel.CssClassFailed
            });
        }
    }
}