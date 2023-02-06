using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public abstract class FileHandler
    {
        public abstract string Read(string path);
    }
    internal class FileReader : FileHandler
    {
        public override string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
