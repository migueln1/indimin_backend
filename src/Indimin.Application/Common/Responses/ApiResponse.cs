namespace Indimin.Application.Responses
{
    public class ApiResponse
    {
        public ApiResponse(object entity)
        {
            Success = true;
            Data = entity;
        }
        public ApiResponse(string error)
        {
            Success = false;
            Message = error;
        }

        public bool Success { get; init; }
        public string? Message { get; init; }
        public object? Data { get; init; }
    }
}
