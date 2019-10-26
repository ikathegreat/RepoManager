using System.IO;

namespace RepoManager.Models
{
    public class BatchFileModel
    {
        public bool RunBatchFile { get; set; }
        public string FullPath { get; set; }

        public string FileName => !string.IsNullOrEmpty(FullPath) ? 
            Path.GetFileNameWithoutExtension(FullPath) : string.Empty;
    }
}
