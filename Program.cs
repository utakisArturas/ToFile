using System;
using System.Collections.Generic;
using System.Linq;

namespace CA0223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newFile = new FileClass("RandomFile",15,true,'$');
            //newFile.WriteToFile(newFile.ToString());
            var fileNumber2 = new FileClass("RandomFile2", 14, false, '@');
            var fileNumber3 = new FileClass("RandomFile3", 13, true, '!');
            var fileNumber4 = new FileClass("RandomFile4", 12, false, '^');
            List<FileClass> fileList = new List<FileClass>() { newFile, fileNumber2, fileNumber3, fileNumber4, };
            fileList.ForEach(file => file.WriteToFile(file.ToString()));

            



        }
    }
}
