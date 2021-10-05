using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.Facades
{
    public interface ILoginFacade 
    {
        Task<(ClaimsPrincipal, UserCredentials)> Login(Data data, string returnUrl = "/");
        Task Register(Data data, string returnUrl = "/");
    }
}
