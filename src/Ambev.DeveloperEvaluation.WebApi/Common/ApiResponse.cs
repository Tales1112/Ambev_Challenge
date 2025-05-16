using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.WebApi.Common;

public class ApiResponse
{
    public bool Success { get; set; }
    public string Type { get; private set; } = ApiResponseErrorType.ValidationError.ToString();
    public string Message { get; set; } = string.Empty;
    public IEnumerable<ValidationErrorDetail> Errors { get; set; } = [];

    public static ApiResponse CreateAsValidationError(string error, string detail) =>
       CreateAsValidationError([
           new()
            {
                Error = error,
                Detail = detail,
            }
       ]);

    public static ApiResponse CreateAsValidationError(IEnumerable<ValidationErrorDetail> errors) => new()
    {
        Success = false,
        Type = ApiResponseErrorType.ValidationError.ToString(),
        Message = "Validation Failed",
        Errors = errors,
    };

    public static ApiResponse CreateAsNotFound(string error, string detail) => new()
    {
        Success = false,
        Type = ApiResponseErrorType.ResourceNotFound.ToString(),
        Message = error,
        Errors =
        [
            new()
            {
                Error = error,
                Detail = detail,
            },
        ],
    };

    public static ApiResponse CreateAsNotFound(string message = "Resource not found") => new()
    {
        Success = false,
        Type = ApiResponseErrorType.ResourceNotFound.ToString(),
        Message = message,
    };
}
