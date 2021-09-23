using Microsoft.AspNetCore.Mvc.ViewFeatures;
using static Portofolio.AppModels.Utils.KeyConstants;
using Portofolio.ViewModels;
namespace Portofolio.AppModels.Services
{
    public class OutputDisplayer : IDisplayOutput
    {
        public void DisplayOutput(ViewDataDictionary viewData, bool isSuccess, string message)
        {
            var viewModel = new ResultMsgViewModel();
            if(isSuccess)
            {
                viewModel.CssClass = ResultMsgViewModel.CssClassSuccess;
            }
            viewModel.Message = message;
            viewModel.CssClass = ResultMsgViewModel.CssClassFailed;
            viewData[ResultMessageKey] = viewModel;
        }
    }
}