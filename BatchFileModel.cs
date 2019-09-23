using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager
{
    public class BatchFileModel
    {
        public bool RunBatchFile { get; set; }
        public string FullPath { get; set; }

        public string FileName => !string.IsNullOrEmpty(FullPath) ? 
            Path.GetFileNameWithoutExtension(FullPath) : string.Empty;
    }
}
