using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orcamento_dotnet6_api.Models;

namespace orcamento_dotnet6_api.Services
{
    public interface ILoginService
    {
        Task<object> SignIn(Login login);
    }
}
