
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFromTheMountain.ImageResizer.ApiLayer.Controllers;

[Route("api/uploads")]
public class UploadController : Controller
{
    [HttpPost]
    public async Task<IActionResult> GetAsync(UploadImageRequestDto request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok();
    }
}

public record UploadImageRequestDto
{
    [Required]
    [MinLength(10)]
    [MaxLength(512)]
    public string Name { get; set; }

    [Required]
    public IFormFile Image { get; set; }
}