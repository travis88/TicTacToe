using Microsoft.AspNetCore.Builder;
using TicTacToe.Middleware;

namespace TicTacToe.Extensions
{
    public static class CommunicationMiddlewareExtension
    {
        public static IApplicationBuilder UseCommunicationMiddleware(this IApplicationBuilder app) =>
            app.UseMiddleware<CommunicationMiddleware>();
    }
}