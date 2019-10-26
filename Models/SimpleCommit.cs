using System;

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
