using System.IO;
using System.Diagnostics;

namespace Applaunch
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Process.GetCurrentProcess().MainModule.FileName;
            fileName = Path.GetFileNameWithoutExtension(fileName) + ".lnk";
            if (File.Exists(fileName))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.Start();
            }
        }
    }
}
