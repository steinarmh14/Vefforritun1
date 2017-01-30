using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Project4.Utilities
{
    public class TextFileLogMedia : LogMedia
    {
        public override void LogMessage(string message)
        {
            FileInfo fInfo = new FileInfo(ConfigurationManager.AppSettings["LogFile"]);

            if (!System.IO.Directory.Exists(fInfo.DirectoryName))
            {
                System.IO.Directory.CreateDirectory(fInfo.DirectoryName);
            }

            File.AppendAllText(ConfigurationManager.AppSettings["LogFile"], message);
        }
    }
}