using System.IO;
using System.Threading.Tasks;
namespace Portofolio.AppModels.Models
{
    public class HTMLModel
    {
        public string Path { get; set; }


        public string PlaceHolder { get; set; }

        public string PlaceHolderValue { get; set; }

        public string ToEmail { get; set; }
        
        public async Task<string> GetHTMLAsync()
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                return await sr.ReadToEndAsync();
            }
        }
    }
}