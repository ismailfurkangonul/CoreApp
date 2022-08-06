using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CoreApp.Middlewares
{
    public class RequestEditingMiddleWare
    {

        private RequestDelegate _requestDelegate;

        public  RequestEditingMiddleWare(RequestDelegate requestDelegate)
        {

            _requestDelegate = requestDelegate;

        }
        public async Task Invoke(HttpContext context)
        {

            if (context.Request.Path.ToString()=="/Furkan")
            {
                await context.Response.WriteAsync("hosgeldin mertens");


            }
            else
            {
               await _requestDelegate.Invoke(context);


            }

        }
    }
}
