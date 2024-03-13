using CloudStorageTest.Application.UseCases.Users.UploadProfilePhoto;
using Microsoft.AspNetCore.Mvc;

namespace CloudStorageTest.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StorageController : ControllerBase
{
    [HttpPost]
    public IActionResult UploadImage(
        [FromForm] IFormFile file
    )
    {
        var useCase = new UploadProfilePhotoUseCase();

        return Ok();
    }
}