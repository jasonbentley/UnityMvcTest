using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityMvcTest.Code
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello, World!";
        }
    }
}