namespace RepoManager
{
    public class SummaryRecord
    {
        private readonly RepoModel repoModel;
        public SummaryRecord(RepoModel aRepoModel)
        {

            repoModel = aRepoModel;
        }

        public string RepositoryName => repoModel.Name;
        public RepoActionEnum RepoActionEnum { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        
    }
}
