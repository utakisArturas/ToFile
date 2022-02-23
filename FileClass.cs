using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0223
{
    public class FileClass :IWriteableToFile
    {
        private string Path = @"C:\Users\utaki\Documents\Code\FileDestination\FileSaver.txt.";
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsAlive { get; set; }
        public char AChar { get; set; }
        public FileClass(string name, int id, bool isAlive, char aChar)
        {
            Name = name;
            Id = id;
            IsAlive = isAlive;
            AChar = aChar;
        }

        public override string ToString()
        {
            return $"File : {Name}, {Id}, {IsAlive}, {AChar}";
        }

        public void WriteToFile(string fileName)
        {
            var fs = new FileStreamer();
            fs.StreamWriting(fileName);
        }
    }
}
