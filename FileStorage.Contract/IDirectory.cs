namespace Fuchsbau.Components.Data.FileStorage.Contract
{
    public interface IDirectory
    {
        string Path { get; }

        bool Exists();
    }
}
