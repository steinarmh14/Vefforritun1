using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project4.Utilities
{
    public class LogOutputWindow : LogMedia
    {
        public override void LogMessage(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}