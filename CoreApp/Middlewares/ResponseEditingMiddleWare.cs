using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CoreApp.Middlewares
{

    public class ResponseEditingMiddleWare
    {
        private RequestDelegate _requestDelegate;
        public ResponseEditingMiddleWare(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;




        }
        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context); 
            if(context.Response.StatusCode==StatusCodes.Status404NotFound)
            {
                await context.Response.WriteAsync("kardesim olmayan sayfaya ulaşma");


            }
           
        }


    }
}
