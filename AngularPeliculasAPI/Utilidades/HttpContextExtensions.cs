using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPeliculasAPI.Utilidades
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosEnCabecera<T>(this HttpContext httpContext, IQueryable<T> queryable)
        {
            if(httpContext != null)
            {
                double cantidad = await queryable.CountAsync();

                Console.WriteLine("CANTIDAD: " + cantidad);

                httpContext.Response.Headers.Add("cantidadTotalRegistros", cantidad.ToString());
            }
        }
    }
}
