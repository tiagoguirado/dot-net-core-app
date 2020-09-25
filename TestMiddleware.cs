using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class TestMiddleware
{
    private readonly RequestDelegate _netx;

    public TestMiddleware(RequestDelegate netx)
    {
        _netx = netx;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("\n\r --- Before --- \n\r");
        
        await _netx(context);

        Console.WriteLine("\n\r --- After --- \n\r");
    }
}