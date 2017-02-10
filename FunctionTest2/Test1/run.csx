#load "..\Entities\NewRelicEntities.csx"

using System;

public static void Run()
{
    var instances = NewRelicService.GetInstances();
}