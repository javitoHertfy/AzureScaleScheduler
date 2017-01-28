using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"aa FXSTimer trigger function executed at: {DateTime.Now}");
}
