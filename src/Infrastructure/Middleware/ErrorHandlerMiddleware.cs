﻿// <copyright file="ErrorHandlerMiddleware.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Garuda.Infrastructure.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                switch (error)
                {
                    case DataNotFoundExceptions e:
                        // not found error
                        _logger.LogError($"{error.Message}");
                        response.StatusCode = Codes.NOT_FOUND;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.MessageIdn, e.MessageEng));
                        break;
                    case ErrorTransactExceptions e:
                        _logger.LogError($"{error.Message}");
                        response.StatusCode = Codes.ERROR_TRANSACT;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.MessageIdn, e.MessageEng));
                        break;
                    case InvalidSessionExceptions e:
                        // not found error
                        _logger.LogError($"{error.Message}");
                        response.StatusCode = Codes.INVALID_SESSION;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.MessageIdn, e.MessageEng));
                        break;
                    case HttpResponseLibraryException e:
                        // not found error
                        _logger.LogError($"{error.Message}");
                        response.StatusCode = Codes.HTTP_RESPONSE;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.MessageIdn, e.MessageEng));
                        break;
                    case UnauthorizedException e:
                        // custom Error
                        _logger.LogError($"{error.Message}");
                        response.StatusCode = Codes.UNAUTHORIZED;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.MessageIdn, e.MessageEng));
                        break;
                    case BadRequestException e:
                        // custom Error
                        _logger.LogError($"{error.Message}");
                        response.StatusCode = Codes.BAD_REQUEST;
                        await response.WriteAsJsonAsync(new MessageErrorDto(e.Status, e.Title, e.MessageIdn, e.MessageEng));
                        break;
                    default:
                        // unhandled error
                        _logger.LogInformation($"{error.Message}");
                        response.StatusCode = BadRequestException.Code;
                        await response.WriteAsJsonAsync(new MessageErrorDto(BadRequestException.Code, "Oops! Something went wrong!", "Terjadi Kesalahan", "Something went wrong"));
                        break;
                }
            }
        }
    }
}
