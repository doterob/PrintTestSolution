using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTestWpf
{
    class StreamInfo
    {
        Stream stream;
        int length;

        public StreamInfo(Stream stream, int length)
        {
            this.stream = stream;
            this.length = length;
        }

        public Stream Stream { get { return stream; } }
        public int Length { get { return length; } }
    }
}
