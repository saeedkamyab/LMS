using LMS.Application.Constants.Enums;

namespace LMS.Application.Dtos.Common
{
    public class BaseCommandResponse
    {
        public ResponseStatusCodes Status { get; set; }
        public string? Message { get; set; }
        public List<string> Errors { get; set; } = [];
    }
}
