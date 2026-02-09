namespace Restaurants.Domain.Interfaces;

public interface IBlobStorageService
{
    Task<string> UploadToBlobAsync(Stream data, string fileName);
    public string? GetBlobSasUrl(string? blobUrl);
}