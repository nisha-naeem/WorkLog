using System;
using System.Windows.Forms;

namespace Demo.Models
{
    public class PushMessageEventArgs: EventArgs
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public MessageBoxButtons Buttons { get; set; }
    }
}