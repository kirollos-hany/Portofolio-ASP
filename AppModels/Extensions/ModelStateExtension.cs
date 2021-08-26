using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    }
}