using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageTest.Application.UseCases.Users.UploadProfilePhoto;

public class UploadProfilePhotoUseCase
{
    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        var isImage = fileStream.Is<JointPhotographicExpertsGroup>(); // é JPG de fato?

        if (isImage == false)
            throw new Exception("The file is not an image.");

        
    }
}