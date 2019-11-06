using System;
using System.Collections.Generic;

namespace RepoManager.Models
{
    public class RepoModel
    {
        private List<string> solutionList = new List<string>();
        private List<string> branchesList = new List<string>();
        private List<string> dependentRepoNamesList = new List<string>();

        public string Name { get; set; }
        public string Path { get; set; }
        public string BranchName { get; set; }
        public string CommitsAheadBehind { get; set; }
        public DateTime LastChange { get; set; }
        public string CommitMessage { get; set; }
        public RepoSourceTypeEnum RepoSourceType { get; set; }
        public string RemoteURL { get; set; }
        public string Changes { get; set; }
        public string ChangeString { get; set; }
        public string SizeString { get; set; }
        public string NumberOfFilesString { get; set; }
        public bool SkipScan { get; set; }

        public void SetSolutionsList(List<string> aSolutionList)
        {
            solutionList = aSolutionList;
        }

        public List<string> GetSolutionList()
        {
            return solutionList;
        }
        public void SetBranchesList(List<string> aBranchesList)
        {
            branchesList = aBranchesList;
        }

        public List<string> GetBranchesList()
        {
            return branchesList;
        }

        public void SetDependentRepoNamesList(List<string> aDependentRepoNamesList)
        {
            dependentRepoNamesList = aDependentRepoNamesList;
        }

        public List<string> GetDependentRepoNamesList()
        {
            return dependentRepoNamesList;
        }

    }
}
