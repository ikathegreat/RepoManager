namespace RepoManager.Models
{
    public class RepoToClone
    {
        public string RemoteURL { get; set; }
        public string LocalPath { get; set; }
        public RepoSourceTypeEnum RepoSourceTypeEnum { get; set; }
    }
}
