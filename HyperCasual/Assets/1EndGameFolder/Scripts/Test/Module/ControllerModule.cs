using System;
using System.Collections;

public class ControllerModule : IModule
{
    public string Name => "”правление 2д вид с боку";

    public IEnumerable OnUnload()
    {
        throw new NotImplementedException();
    }

    IEnumerable IModule.OnLoad()
    {
        throw new NotImplementedException();
    }
}
