using System;

namespace Core3Api.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return Environment.GetEnvironmentVariable("message");
        }
    }
}