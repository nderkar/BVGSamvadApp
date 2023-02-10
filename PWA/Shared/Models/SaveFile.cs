using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samvad_App.Shared.Models
{
    public class SaveFile
    {
        public long PostId { get; set; }
        public byte[] Data { get; set; }
        public string FileExtension { get; set; }
        public long Size { get; set; }
        public string FileName { get; set; }
        //public List<FileData> Files { get; set; }
    }

    public class FileData
    {
        public byte[] Data { get; set; }
        public string FileType { get; set; }
        public string FileExtension { get; set; }
        public long Size { get; set; }
    }
}
