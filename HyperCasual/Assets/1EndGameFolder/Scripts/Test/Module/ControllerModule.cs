using System;
using System.Collections;

public class ControllerModule : IModule
{
    public string Name => "���������� 2� ��� � ����";

    public IEnumerable OnUnload()
    {
        throw new NotImplementedException();
    }

    IEnumerable IModule.OnLoad()
    {
        throw new NotImplementedException();
    }
}
