using System.Collections;

public interface IModule
{
    public string Name { get; }
    IEnumerable OnLoad();
    IEnumerable OnUnload();
}

