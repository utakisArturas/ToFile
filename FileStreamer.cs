using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0223
{
    public  class FileStreamer
    {
        private string Path = @"C:\Users\utaki\Documents\Code\FileDestination\FileSaver.txt.";

        public void  StreamWriting<T>(T file)
        {
            using (var streamWriter = new StreamWriter(Path, true)){
                streamWriter.WriteLine(file.ToString());
                streamWriter.Dispose();
            }
            
        }
    }
}
