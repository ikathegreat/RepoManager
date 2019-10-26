using System;

namespace RepoManager.Models
{
    public enum RepoActionEnum
    {
        Open,
        Delete,
        [Description("Delete bin and obj folders for")]
        DeleteBinObj,
        [Description("Perform a git reset for")]
        GitReset,
        [Description("Perform a git pull for")]
        GitPull,
        [Description("Delete .vs folder for")]
        DeleteVS,
        [Description("Perform a git fetch for")]
        GitFetch,
        [Description("Run batch files for")]
        RunBatch,
        ManageNuget
    }
    public class Description : Attribute
    {
        public string Text;

        public Description(string text)
        {
            Text = text;
        }
    }
}
