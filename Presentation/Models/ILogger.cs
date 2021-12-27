using System;

namespace TestWebBlog.Models
{
    public interface ILogger
    {
        void LogError(Exception ex);
        void LogWarning(string message);
    }
}