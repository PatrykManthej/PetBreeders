using PetBreeders.Application.Common.Interfaces;

namespace PetBreeders.Infrastructure.FileStore;

public class DirectoryWrapper : IDirectoryWrapper
{
    public void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }
}