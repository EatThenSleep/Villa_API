using System.Net;

namespace FLC_Web.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; } = new List<string>();
        public object? Result { get; set; }

        public void AppendMessage(string message)
        {
            ErrorMessages.Add(message);
        }
    }
}
