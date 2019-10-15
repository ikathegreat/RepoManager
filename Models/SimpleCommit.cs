using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager.Models
{
    public struct SimpleCommit
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Merges { get; set; }
        public string Message { get; set; }
        public int ChangeCount { get; set; }
    }
}
