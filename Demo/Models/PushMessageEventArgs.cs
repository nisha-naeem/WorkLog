using System;

namespace Demo.Models
{
    public class PushMessageEventArgs: EventArgs
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public MessageButton Buttons { get; set; }
    }
}