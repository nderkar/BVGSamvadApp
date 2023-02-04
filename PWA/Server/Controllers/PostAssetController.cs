using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Models;
using Samvad_App.Server.Services;

namespace Samvad_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostAssetController : ControllerBase
    {
        private readonly IPostAssetService _PostAssetService;
        public PostAssetController(IPostAssetService PostAssetService)
        {
            _PostAssetService = PostAssetService;
        }
        [HttpGet("{id}")]
        public async Task<List<PostAsset>> Get(long id)
        {
            return await _PostAssetService.GetPostAssetsByPostId(id);
        }
    }
}
