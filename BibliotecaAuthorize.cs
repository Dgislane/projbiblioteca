using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Biblioteca
{
    public class BibliotecaAuthorize : AuthorizeAttribute
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {   
            System.Console.WriteLine("#############Authorizedddd");
        }
    }
}