namespace LMS.Application.Constants.Enums
{
    public enum ResponseStatusCodes:byte
    {
        None = 0,
        Success = 1,
        Faild = 2,
        ValidationError = 3,
        NotFound = 4,
        Unauthorized = 5,
        ServerError = 6
    }
}
