using System;
using System.IO;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    string path = "configuration.js";
    log.Info($"aa FXSTimer trigger function executed at: {DateTime.Now}");

    // Open the stream and read it back.
    using (FileStream fs = File.Open(path, FileMode.Open))
    {
        byte[] b = new byte[1024];
        UTF8Encoding temp = new UTF8Encoding(true);

        while (fs.Read(b, 0, b.Length) > 0)
        {
            log.Info(temp.GetString(b));
        }
    }
}
