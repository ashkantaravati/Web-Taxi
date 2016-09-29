using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebBrowser
{
    class HTTPReceiver
    {
        string Headers;
        string AgentName;
        string Response;
        public HTTPReceiver(string agentName,string headers)
        {
            Headers = headers;
            AgentName = agentName;
        }
        public void Receive(string resourceAddress)
        {
            WebClient client = new WebClient();
            // Add a user agent header in case the 
            // requested URI contains a query.

            client.Headers.Add(AgentName, Headers);
            
            Stream data = client.OpenRead(resourceAddress);
            StreamReader reader = new StreamReader(data);
            string response = reader.ReadToEnd();
            
            data.Close();
            reader.Close();
            Response=response;
        }
    }
}
