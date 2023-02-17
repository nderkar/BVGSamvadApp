using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Models;
using Samvad_App.Server.Services;

namespace Samvad_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _PostService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public PostController(IPostService PostService , SignInManager<ApplicationUser> signInManager)
        {
            _PostService = PostService;
            _signInManager = signInManager;
        }
        [HttpGet("{page}/{size}")]
        public async Task<List<Post>> GetAll(int page=0,int size=10)
        {
            return await _PostService.GetAllPost(page,size);
        }
        [HttpGet("{id}")]
        public async Task<Post> Get(long id)
        {
            return await _PostService.GetPost(id);
        }
        [HttpPost]
        public async Task<Post> AddPost([FromBody] Post post)
        {
            var user = await _signInManager.UserManager.FindByEmailAsync(User.Identity.Name);
            post.createdby =  user.Id;
            post.createdate = DateTime.Now;
            post.modifiedby = user.Id;
            post.modifieddate = DateTime.Now;
            post.isdeleted = false;
            return await _PostService.AddPost(post);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeletePost(long id)
        {
            await _PostService.DeletePost(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdatePost(long id, [FromBody] Post Object)
        {
            await _PostService.UpdatePost(id, Object);
            return true;
        }
    }
}
