using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager.Models
{
    public struct SimpleFileChange
    {
        public string FileChangeKind { get; set; }
        public string Path { get; set; }
        public DateTime DateChanged { get; set; }
        public string ChangeAuthor { get; set; }
        public string Message { get; set; }
        public string Sha { get; set; }
        public string DaysAge => (DateTime.Today - DateChanged).TotalDays.ToString("n2");

        public string FileNameWithExtension => string.IsNullOrEmpty(Path) ? string.Empty : System.IO.Path.GetFileName(Path);
    }
}
