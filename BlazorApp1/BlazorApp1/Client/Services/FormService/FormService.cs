using Blazored.Toast.Services;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.FormService
{
    public class FormService : IFormService
    {

        private readonly IToastService _toastService;

        public  async  Task  FormSucess()


        {

            string message;
            message = ".";
            _toastService.ShowSuccess( message, "Form sucessfully submitted");
        }
    }
}
