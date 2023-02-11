namespace Samvad_App.Shared.Models
{
    public class ChangePasswordResult
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
