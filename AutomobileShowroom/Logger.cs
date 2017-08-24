using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class Logger
    {
        private Stream _logStream;
        public Logger(Stream stream)
        {
            _logStream = stream;
        }
        public void Log(Invoice invoice)
        {
            byte[] invoicebytes = Encoding.ASCII.GetBytes(invoice.ToString());
            _logStream.Write(invoicebytes, 0, invoicebytes.Length);
        }
        
    }
}
