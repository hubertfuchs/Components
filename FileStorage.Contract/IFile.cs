namespace Fuchsbau.Components.Data.FileStorage.Contract
{
    public interface IFile
    {
        string Name { get; }

        bool Exists();
    }
}
