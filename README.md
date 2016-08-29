# AppLaunch
This program launches a shortcut. Yes you read that right, It exists becuase some other "program" is dumb.

This is the entire code.

Decompile the release if you want to check but seriously WHY AM  DOING THIS

```c#
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
```