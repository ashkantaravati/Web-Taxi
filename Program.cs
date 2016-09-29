using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;

namespace SimpleWebBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            HTTPReceiver hr = new HTTPReceiver("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            hr.Receive(s);
        }
    }
}
