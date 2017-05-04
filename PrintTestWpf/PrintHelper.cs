using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrintTestWpf
{
    abstract class PrintHelper
    {
        private bool IsLocalPath(string p)
        {
            return new Uri(p).IsFile;
        }

        public StreamInfo GetStream(String file)
        {
            Stream stream = null;
            int length = 0;

            if (IsLocalPath(file))
            {
                stream = new FileStream(file, FileMode.Open);
                length = Convert.ToInt32(((FileStream)stream).Length);
            }
            else
            {
                WebRequest webRequest = WebRequest.Create(file);
                WebResponse response = webRequest.GetResponse();
                stream = response.GetResponseStream();
                length = Convert.ToInt32(response.ContentLength);
            }

            return new StreamInfo(stream, length);
        }

        public abstract void Print(String printer, String file);
    }
}
