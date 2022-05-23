﻿using Microsoft.AspNetCore.Diagnostics;
using NLayer.Core.DTOs;
using NLayer.Service.Exceptions;
using System.Text.Json;

namespace NLayer.API.Middlewares
{
    public static class UseCustomExceptionHandler
    {
        public static void UserCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exeptionFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exeptionFeature.Error switch
                    {
                        ClientSideException=>400,
                        _=>500
                    };
                    context.Response.StatusCode = statusCode;
                    var response=CustomResponseDto<NoContentDto>.Fail(statusCode,exeptionFeature.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}