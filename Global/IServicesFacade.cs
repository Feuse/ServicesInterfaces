using Microsoft.AspNetCore.Http;
using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.Global
{
    public interface IServicesFacade
    {
        Task<Data> LoginToService(Data data);
        Task<IDictionary<string, string>> GetImages(Data data);
        Task<IDictionary<string, string>> RemoveImage(Data data);
        Task<IDictionary<string, string>> UploadImage(Data data);
        Task<string> ScheduleTask(List<Data> data,string id);
        Task<List<Service>> AuthenticateUserServices(string id);
        Task <string> UpdateAboutMe(Data data);
        Task SeenTutorial(Data data);
        Task<UserCredentials> GetUserInfo(string id);
        Task<(ClaimsPrincipal,UserCredentials)> Login(Data data, string returnUrl = "/");
        Task Register(Data data, string returnUrl = "/");
    }
}
