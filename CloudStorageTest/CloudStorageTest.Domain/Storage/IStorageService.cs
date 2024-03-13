namespace CloudStorageTest.Domain.Storage;

public interface IStorageService
{
    string Upload(IFormFile file, User user);
}