using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Models;
using Samvad_App.Server.Services;
using Samvad_App.Shared.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Samvad_App.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IPostAssetService _PostAssetService;
        private readonly AppSettingVariables appSettingVariables;
        public FileUploadController(IPostAssetService PostAssetService, AppSettingVariables cnfg)
        {
            _PostAssetService = PostAssetService;
            this.appSettingVariables = cnfg;
        }

        [HttpPost]
        [DisableRequestSizeLimit,
    RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue,
        ValueLengthLimit = int.MaxValue)]
        [Route("save-file")]
        public async Task<IActionResult> SaveToPhysicalLocation([FromBody] SaveFile saveFile)
        {
            string rootPath = appSettingVariables.FileUploadPath;
            string fileName = "";
            if (saveFile.FileExtension.ToLower() == "pdf")
            {
                fileName = saveFile.FileName;
            }
            else
            {
                fileName = $@"{Guid.NewGuid()}.{saveFile.FileExtension}";
            }
            string fullFileName = $@"{rootPath}\{fileName}";
            using (var fileStream = System.IO.File.Create(fullFileName))
            {
                await fileStream.WriteAsync(saveFile.Data, 0, Convert.ToInt32(saveFile.Size));
            }
            PostAsset postAsset = new()
            {
                postid = saveFile.PostId,
                asseturl = fileName,
                assettype = saveFile.FileExtension,
                createddate = DateTime.Now,
                isdeleted = false
            };
            var data = await _PostAssetService.AddPostAsset(postAsset);
         
            return Ok(data);
        }
    }
}
