using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Common
{
    /// <summary>
    /// Defines way to convention response api error.
    /// </summary>
    internal sealed class ApiErrorsConventionHandler
    {
        /// <summary>
        /// Occurs when not found resource by route.
        /// </summary>
        private static readonly object ResourceNotFoundErrorResponse = new
        {
            Type = ApiResponseErrorType.ResourceNotFound.ToString(),
            Error = "Uri not found",
            Detail = "Endpoint does not exist",
        };

        /// <summary>
        /// Occurs when authentication failed.
        /// </summary>
        private static readonly object AuthenticationErrorResponse = new
        {
            Type = ApiResponseErrorType.AuthenticationError.ToString(),
            Error = "Invalid authentication token",
            Detail = "The provided authentication token has expired or is invalid",
        };

        /// <summary>
        /// Handle bad request when is invalid mvc model validation.
        /// </summary>
        /// <param name="context">Action context</param>
        /// <returns>Action result</returns>
        public static IActionResult HandleBadRequestOnInvalidModelValidation(ActionContext context)
        {
            var error = context.ModelState.FirstOrDefault(_ => _.Key.StartsWith('$'), context.ModelState.FirstOrDefault());
            var problemDetails = new
            {
                Type = ApiResponseErrorType.ValidationError.ToString(),
                Error = "Invalid input data",
                Detail = error.Value?.Errors.Select(e => e.ErrorMessage).FirstOrDefault() ?? "Error",
            };

            return new BadRequestObjectResult(problemDetails);
        }

        /// <summary>
        /// Handle error by status code.
        /// </summary>
        /// <param name="context">Status code context</param>
        /// <returns>Asynchronous task.</returns>
        public static Task HandleByStatusCode(StatusCodeContext context)
        {
            var errorResponse = context.HttpContext.Response.StatusCode switch
            {
                StatusCodes.Status401Unauthorized => AuthenticationErrorResponse,
                StatusCodes.Status404NotFound => ResourceNotFoundErrorResponse,
                _ => null,
            };

            return context.HttpContext.Response.WriteAsJsonAsync(errorResponse);
        }
    }

}
