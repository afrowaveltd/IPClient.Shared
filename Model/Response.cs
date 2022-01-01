using System.Collections.Generic;

namespace IPClient.Shared.Model
{
    public class Response
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "";
        public List<string> Errors { get; set; }
    }
}