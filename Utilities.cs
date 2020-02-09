using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DevExpress.Utils.Extensions;
using LibGit2Sharp;
using NugetManagement;
using RepoManager.Models;

namespace RepoManager
{
    public static class Utilities
    {
        private const string RFC2822Format = "ddd dd MMM HH:mm:ss yyyy K";
        public static async Task GetRepoModelSolutionsList(RepoModel repoModel, string reposPath, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    var solutionsList = Directory
                        .EnumerateFiles(repoModel.Path, "*.sln", SearchOption.AllDirectories).ToList();
                    repoModel.SetSolutionsList(solutionsList);

                    if (!Processor.IsValidSearchPath(repoModel.Path))
                        return;

                    var modelSolutionList = (from solutionPath in solutionsList
                                             let solutionDirectory = Path.GetDirectoryName(solutionPath)
                                             where solutionDirectory != null
                                             select new ModelSolution(solutionPath)).ToList();

                    var dependentRepoNamesList = new List<string>();

                    foreach (var modelSolution in modelSolutionList)
                    {
                        foreach (var modelProject in modelSolution.ProjectList)
                        {
                            var truncatedPath = Path.GetFullPath(modelProject.FullPath)
                                .Replace(reposPath, "").TrimStart('\\').Split('\\')[0];
                            if (Path.GetFileName(repoModel.Path) != truncatedPath)
                                dependentRepoNamesList.Add(truncatedPath);
                        }
                    }

                    //Do this weird thing for distinct items for mixed cases
                    var tempDependentRepoNamesList = new List<string>();
                    foreach (var repoName in dependentRepoNamesList)
                    {
                        if (tempDependentRepoNamesList.Any(x =>
                             string.Equals(x, repoName, StringComparison.CurrentCultureIgnoreCase)))
                            continue;
                        tempDependentRepoNamesList.Add(repoName);
                    }
                    repoModel.SetDependentRepoNamesList(tempDependentRepoNamesList);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GetRepoModelSolutionsList: {ex.Message}");
                }
            }, ct);
        }
        public static async Task GetRepositoryChanges(RepoModel repoModel, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    //Todo: SX_Core and AutoDEMO_DemoFiles take 20+ seconds
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    using (var repo = new Repository(repoModel.Path))
                    {
                        var statusOptions = new StatusOptions
                        {
                            IncludeIgnored = false,
                            IncludeUnaltered = false,
                            IncludeUntracked = false,
                            Show = StatusShowOption.WorkDirOnly, //don't check index dir for performance
                            RecurseIgnoredDirs = false,
                            RecurseUntrackedDirs = false,
                            ExcludeSubmodules = true
                        }; //this is slower?!

                        statusOptions = new StatusOptions();
                        var repoStatus = repo.RetrieveStatus(statusOptions);
                        GetFileStatusInfo(repoStatus, out var Changes, out var ChangeString);

                        repoModel.ChangeString = ChangeString;
                        repoModel.Changes = Changes;

                        stopWatch.Stop();
                        var ts = stopWatch.Elapsed;
                        Debug.WriteLine($"GetRepositoryChanges: {repoModel.Name} - {ts.Hours:D2}h:{ts.Minutes:D2}m:{ts.Seconds:D2}s:{ts.Milliseconds:D3}ms");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GetRepoModelSolutionsList: {ex.Message}");
                }
            }, ct);
        }
        public static async Task GetRepoNumberOfFiles(RepoModel repoModel, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    repoModel.NumberOfFilesString = "0";

                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    repoModel.NumberOfFilesString = Directory.GetFiles(repoModel.Path, "*.*",
                        SearchOption.AllDirectories).ToList().Count.ToString();
                    stopWatch.Stop();
                    var ts = stopWatch.Elapsed;
                    Debug.WriteLine($"GetRepoNumberOfFiles: {repoModel.Name} - {ts.Hours:D2}h:{ts.Minutes:D2}m:{ts.Seconds:D2}s:{ts.Milliseconds:D3}ms");


                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GetRepoModelSolutionsList: {ex.Message}");
                }
            }, ct);
        }
        public static async Task GetRepositorySize(RepoModel repoModel, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    repoModel.SizeString = "0 bytes";

                    var stopWatch = new Stopwatch();
                    stopWatch.Start();

                    repoModel.SizeString = BytesToFormattedString(GetDirectorySize(repoModel.Path));
                    stopWatch.Stop();
                    var ts = stopWatch.Elapsed;
                    Debug.WriteLine($"GetRepositorySize: {repoModel.Name} - {ts.Hours:D2}h:{ts.Minutes:D2}m:{ts.Seconds:D2}s:{ts.Milliseconds:D3}ms");


                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GetRepoModelSolutionsList: {ex.Message}");
                }
            }, ct);
        }
        private static long GetDirectorySize(string p)
        {
            if (!Directory.Exists(p))
                return 0;
            var a = Directory.GetFiles(p, "*.*", SearchOption.AllDirectories);
            return a.Select(name => new FileInfo(name)).Select(info => info.Length).Sum(); //Todo: This throws if you delete directory while running
        }

        private static string BytesToFormattedString(long value)
        {
            string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            if (value < 0) { return "-" + BytesToFormattedString(-value); }
            if (value == 0) { return "0.0 bytes"; }

            var mag = (int)Math.Log(value, 1024);
            var adjustedSize = (decimal)value / (1L << (mag * 10));

            return $"{adjustedSize:n1} {SizeSuffixes[mag]}";

        }

        public static async Task GetRepoGitInfoAsync(RepoModel repoModel, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    var iniFile = new IniFile(FormMain.OptionsIni);
                    var azureDevOpsHostUrl = iniFile.ReadString(OptionsForm.AuthenticationSection, "AzureDevOpsHostUrl", "");

                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    using (var repo = new Repository(repoModel.Path))
                    {
                        //Active branch name
                        var branchNameNoRefHead =
                            repo.Head.UpstreamBranchCanonicalName.Replace("refs/heads/", "");

                        repoModel.BranchName = branchNameNoRefHead;

                        var remote = repo.Network.Remotes.FirstOrDefault();

                        if (remote != null)
                        {
                            repoModel.RemoteURL = remote.Url;

                            if (remote.Url.Contains("github.com"))
                            {
                                repoModel.RepoSourceType = RepoSourceTypeEnum.GitHub;
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(azureDevOpsHostUrl) && remote.Url.Contains(azureDevOpsHostUrl))
                                {
                                    repoModel.RepoSourceType = RepoSourceTypeEnum.AzureDevOps;
                                }
                                else
                                {
                                    repoModel.RepoSourceType = RepoSourceTypeEnum.Unknown;
                                }
                            }
                        }

                        repoModel.ChangeString = "";
                        repoModel.Changes = "-";

                        if (repoModel.SkipScan)
                            return;

                        //Commit ahead/behind
                        var commitsAhead = repo.Head.TrackingDetails.AheadBy;
                        var commitsBehind = repo.Head.TrackingDetails.BehindBy;

                        repoModel.CommitsAheadBehind = $"+{commitsAhead}/-{commitsBehind}";

                        var commit = repo.Head.Commits.First();
                        if (commit != null)
                        {
                            repoModel.LastChange = commit.Author.When.ToLocalTime().DateTime;
                            repoModel.CommitMessage = $"{commit.Author.Name}: {commit.Message}";
                        }

                        var branchesList = new List<string>();

                        //Get local branches list
                        // ReSharper disable once LoopCanBeConvertedToQuery
                        foreach (var b in repo.Branches.Where(b => !b.IsRemote))
                        {
                            var tempBranchNameNoRefHead =
                                b.UpstreamBranchCanonicalName.Replace("refs/heads/", "");
                            branchesList.Add(tempBranchNameNoRefHead);
                        }


                        repoModel.SetBranchesList(branchesList);

                        stopWatch.Stop();
                        var ts = stopWatch.Elapsed;
                        Debug.WriteLine($"GetRepoGitInfoAsync: {repoModel.Name} - {ts.Hours:D2}h:{ts.Minutes:D2}m:{ts.Seconds:D2}s:{ts.Milliseconds:D3}ms");

                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GetRepoActiveBranchNameAsync: {ex.Message}");
                }
            }, ct);
        }
        public static async Task GetInterRepoReferences(RepoModel repoModel, CancellationToken ct)
        {
            await Task.Run(() =>
            {
                try
                {
                    repoModel.NumberOfFilesString = "0";

                    var stopWatch = new Stopwatch();
                    stopWatch.Start();



                    var ts = stopWatch.Elapsed;
                    Debug.WriteLine($"GetRepoNumberOfFiles: {repoModel.Name} - {ts.Hours:D2}h:{ts.Minutes:D2}m:{ts.Seconds:D2}s:{ts.Milliseconds:D3}ms");


                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"GetRepoModelSolutionsList: {ex.Message}");
                }
            }, ct);
        }

        private static void GetFileStatusInfo(RepositoryStatus repoStatus, out string Changes, out string changeString)
        {
            var addedCount = 0;
            var modifiedCount = 0;
            var deletedCount = 0;
            var renamedCount = 0;
            var typeChangeCount = 0;
            var otherCount = 0;

            foreach (var item in repoStatus)
            {
                switch (item.State)
                {
                    case FileStatus.NewInWorkdir:
                        addedCount++;
                        break;
                    case FileStatus.ModifiedInWorkdir:
                        modifiedCount++;
                        break;
                    case FileStatus.DeletedFromWorkdir:
                        deletedCount++;
                        break;
                    case FileStatus.RenamedInWorkdir:
                        renamedCount++;
                        break;
                    case FileStatus.TypeChangeInIndex:
                        typeChangeCount++;
                        break;
                    default:
                        otherCount++;
                        break;
                }
            }

            var sl = new List<string>();

            if (addedCount > 0)
            {
                sl.Add($"Added: {addedCount}");
            }

            if (modifiedCount > 0)
            {
                sl.Add($"Modified: {modifiedCount}");
            }

            if (deletedCount > 0)
            {
                sl.Add($"Deleted: {deletedCount}");
            }

            if (renamedCount > 0)
            {
                sl.Add($"Renamed: {renamedCount}");
            }

            if (typeChangeCount > 0)
            {
                sl.Add($"Type changed: {typeChangeCount}");
            }

            if (otherCount > 0)
            {
                sl.Add($"Other: {otherCount}");
            }

            changeString = sl.Count > 0 ? string.Join(" | ", sl) : "No local changes";
            Changes = repoStatus.Count().ToString();
        }

        public static async Task<List<RepoModel>> ScanForRepositoriesAsync(string repoSearchPath,
            bool useGitFolders = true)
        {
            var repoModelList = new List<RepoModel>();
            await Task.Run(() =>
            {
                var searchRootDirectories =
                    Directory.EnumerateDirectories(repoSearchPath, "*", SearchOption.TopDirectoryOnly).ToList();

                var iniFile = new IniFile(FormMain.OptionsIni);
                iniFile.ReadSectionValues(SkipRepoBrowseForm.SkipReposSection, out var repoSectionValuesList);

                foreach (var searchRootDirectory in searchRootDirectories)
                {

                    var gitFolder = Path.Combine(searchRootDirectory, ".git");


                    if (Directory.Exists(gitFolder) && useGitFolders)
                    {
                        //    var repoPath = Path.GetDirectoryName(gitFolder);
                        var repoModel = new RepoModel
                        {
                            Name = Path.GetFileName(Path.GetDirectoryName(gitFolder)),
                            Path = searchRootDirectory,

                            SkipScan = repoSectionValuesList.Contains(searchRootDirectory)
                        };

                        repoModelList.Add(repoModel);

                    }

                    if (Directory.Exists(gitFolder) || useGitFolders)
                        continue;


                    //    var repoPath = Path.GetDirectoryName(gitFolder);
                    var nonGitRepoModel = new RepoModel
                    {
                        Name = Path.GetFileName(Path.GetDirectoryName(gitFolder)),
                        Path = searchRootDirectory,

                        SkipScan = repoSectionValuesList.Contains(searchRootDirectory)
                    };

                    repoModelList.Add(nonGitRepoModel);


                    //var gitFolderList = Directory
                    //    .EnumerateDirectories(searchRootDirectory, ".git", SearchOption.TopDirectoryOnly).ToList();

                    //foreach (var gitFolder in gitFolderList)
                    //{
                    //    var repoPath = Path.GetDirectoryName(gitFolder);
                    //    var repoModel = new RepoModel
                    //    {
                    //        Name = Path.GetFileName(Path.GetDirectoryName(gitFolder)),
                    //        Path = repoPath,

                    //        SkipScan = repoSectionValuesList.Contains(repoPath)
                    //    };

                    //    repoModelList.Add(repoModel);
                    //}

                }
            });
            return repoModelList;
        }

        /// <summary>
        /// https://stackoverflow.com/a/44324346
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="maxRetries"></param>
        /// <param name="millisecondsDelay"></param>
        /// <returns></returns>
        public static bool TryDeleteDirectory(string directoryPath, int maxRetries = 10, int millisecondsDelay = 30)
        {
            if (directoryPath == null)
                throw new ArgumentNullException(directoryPath);
            if (maxRetries < 1)
                throw new ArgumentOutOfRangeException(nameof(maxRetries));
            if (millisecondsDelay < 1)
                throw new ArgumentOutOfRangeException(nameof(millisecondsDelay));

            for (var i = 0; i < maxRetries; ++i)
            {
                try
                {
                    if (!Directory.Exists(directoryPath))
                        return false;
                    var files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

                    foreach (var file in files)
                    {
                        try
                        {
                            File.SetAttributes(file, FileAttributes.Normal);
                            File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Failed to delete file in DeleteDirectory: {ex.Message}");
                        }
                    }

                    Directory.Delete(directoryPath, true);

                    return true;
                }
                catch (IOException)
                {
                    //ignored
                }
                catch (UnauthorizedAccessException)
                {
                    //ignored
                }
            }

            return false;
        }

        public static string GetDescription(Enum en)
        {

            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            if (memInfo.Length <= 0)
                return en.ToString();
            var attrs = memInfo[0].GetCustomAttributes(typeof(Description),
                false);

            return attrs.Length > 0 ? ((Description)attrs[0]).Text : en.ToString();
        }

        public static List<string> LoadStringList(string filePath)
        {
            var stringList = new List<string>();
            if (File.Exists(filePath))
            {
                TextReader reader = new StreamReader(filePath);
                try
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<string>));
                    stringList = (List<string>)xmlSerializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            else
            {
                Debug.WriteLine("Can't find this file: " + filePath);
            }

            return stringList;
        }
        public static void SaveStringList(string filePath, List<string> stringList)
        {
            var directoryName = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryName))
                if (directoryName != null)
                    Directory.CreateDirectory(directoryName);


            TextWriter writer = new StreamWriter(filePath);
            var xmlSerializer = new XmlSerializer(typeof(List<string>));

            try
            {
                xmlSerializer.Serialize(writer, stringList);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception occurred while writing to XML: {ex.Message}");
            }
            finally
            {
                writer.Close();
            }

        }


        public static string ConvertHexStringToString(string hex)
        {
            var raw = new byte[hex.Length / 2];
            for (var i = 0; i < raw.Length; i++)
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return Encoding.ASCII.GetString(raw);
        }

        public static string ConvertStringToHexString(string input)
        {
            return string.Concat(input.Select(x => ((int)x).ToString("x")));
        }

        public static async Task CloneGitRepoAsync(string url, string localPath, RepoSourceTypeEnum repoSourceType)
        {
            await Task.Run(() => { CloneGitRepo(url, localPath, repoSourceType); });
        }

        public static void CloneGitRepo(string url, string localPath, RepoSourceTypeEnum repoSourceType)
        {

            if (!IsSiteAccessible(url))
                return;

            var hasUserNameOrPassword = GetUserNameAndPassword(out var userName,
                out var password, repoSourceType);

            try
            {

                var co = new CloneOptions
                {
                    CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials
                    {
                        Username = userName,
                        Password = password
                    }
                };
                Repository.Clone(url, localPath, co);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CloneGitRepoAsync: {ex.Message}");
                if (!hasUserNameOrPassword)
                {
                    Debug.WriteLine("CloneGitRepoAsync username or password is blank");
                }
            }
        }

        public static void DoGitReset(RepoModel repoModel, ref SummaryRecord summaryRecord)
        {
            if (!IsRemoteServerConnectionOK(repoModel, summaryRecord))
                return;

            using (var repo = new Repository(repoModel.Path))
            {
                Commands.Stage(repo, "*");

                repo.Reset(ResetMode.Hard, repo.Head.Tip);
            }
        }

        public static void DoGitPull(RepoModel repoModel, ref SummaryRecord summaryRecord)
        {
            if (!IsRemoteServerConnectionOK(repoModel, summaryRecord))
                return;

            using (var repo = new Repository(repoModel.Path))
            {
                var hasUserNameOrPassword = GetUserNameAndPassword(out var userName,
                    out var password, repoModel.RepoSourceType);

                try
                {
                    var options = new PullOptions
                    {
                        FetchOptions = new FetchOptions
                        {
                            CredentialsProvider = (url, usernameFromUrl, types) =>
                                new UsernamePasswordCredentials
                                {
                                    Username = userName,
                                    Password = password
                                }
                        }
                    };

                    // User information to create a merge commit
                    //Todo: Change this to be actual email
                    var signature = new Signature(
                        new Identity(userName, $"{userName}@gmail.com"), DateTimeOffset.Now);

                    // Pull
                    var mergeResult = Commands.Pull(repo, signature, options);

                    switch (mergeResult.Status)
                    {
                        case MergeStatus.Conflicts:
                            summaryRecord.Message = "The merge had conflicts. Resolve them before continuing.";
                            break;
                        case MergeStatus.FastForward:
                            summaryRecord.Message =
                                $"Fast forward to commit: {mergeResult.Commit.Author} {mergeResult.Commit.Message}";
                            break;
                        case MergeStatus.NonFastForward:
                            summaryRecord.Message =
                                $"Non-fast forward to commit: {mergeResult.Commit.Author} {mergeResult.Commit.Message}";
                            break;
                        case MergeStatus.UpToDate:
                            summaryRecord.Message = "The branch was already up-to-date.";
                            break;
                        default:
                            Debug.WriteLine($"Unknown mergeResult: {mergeResult.Status}");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    if (!hasUserNameOrPassword)
                    {
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = "Need to configure repository connection credentials.";
                    }
                    else
                    {
                        summaryRecord.Result = "Error";
                        var message = ex.Message.Replace("too many redirects or authentication replays",
                            "Incorrect username or password");
                        summaryRecord.Message = message;
                    }
                }
            }
        }
        public static void DoGitFetch(RepoModel repoModel, ref SummaryRecord summaryRecord)
        {
            if (!IsRemoteServerConnectionOK(repoModel, summaryRecord))
                return;

            using (var repo = new Repository(repoModel.Path))
            {
                var hasUserNameOrPassword = GetUserNameAndPassword(out var userName,
                    out var password, repoModel.RepoSourceType);

                const string logMessage = "";

                var options = new FetchOptions();

                if (hasUserNameOrPassword)
                {
                    options.CredentialsProvider = (url, usernameFromUrl, types) =>
                        new UsernamePasswordCredentials { Username = userName, Password = password };


                }

                foreach (var remote in repo.Network.Remotes)
                {
                    var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                    try
                    {
                        Commands.Fetch(repo, remote.Name, refSpecs, options, logMessage);
                    }
                    catch (Exception ex)
                    {
                        if (!hasUserNameOrPassword)
                        {
                            summaryRecord.Result = "Error";
                            summaryRecord.Message = "Need to configure repository connection credentials.";
                        }
                        else
                        {
                            summaryRecord.Result = "Error";
                            var message = ex.Message.Replace("too many redirects or authentication replays",
                                "Incorrect username or password");
                            summaryRecord.Message = message;
                        }

                    }
                }
            }
        }

        public static List<SimpleCommit> DoGitCommitHistoryRetrieve(RepoModel repoModel, int numberOfCommits = 15)
        {
            var result = new List<SimpleCommit>();

            using (var repo = new Repository(repoModel.Path))
            {
                foreach (var c in repo.Commits.Take(numberOfCommits))
                {
                    var mergeString = c.Parents.Count() > 1
                        ? string.Join(" ", c.Parents.Select(p => p.Id.Sha.Substring(0, 7)).ToArray())
                        : "";

                    var changeCount = 0;
                    c.Parents.ForEach(x => changeCount +=
                        repo.Diff.Compare<TreeChanges>(x.Tree,
                            c.Tree).Count);
                    result.Add(new SimpleCommit
                    {
                        Id = c.Id.ToString(),
                        Merges = mergeString,
                        Author = $"{c.Author.Name} <{c.Author.Email}>",
                        Date = c.Author.When.LocalDateTime,
                        Message = c.Message,
                        ChangeCount = changeCount
                    });
                }
            }
            return result;
        }

        public static List<SimpleFileChange> DoGitChangedFilesRetrieve(RepoModel repoModel, int numberOfCommits = 15)
        {
            var result = new List<SimpleFileChange>();

            var iniFile = new IniFile(FormMain.OptionsIni);
            var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
            var slnSearchPath = iniFile.ReadString(OptionsForm.PreferencesSection, "RepoPath", defaultPath);

            using (var repo = new Repository(repoModel.Path))
            {
                foreach (var commit in repo.Commits.Take(numberOfCommits))
                {
                    foreach (var parent in commit.Parents)
                    {
                        foreach (var change in repo.Diff.Compare<TreeChanges>(parent.Tree,
                            commit.Tree))
                        {
                            result.Add(new SimpleFileChange
                            {
                                FileChangeKind = change.Status.ToString(),
                                Path = Path.Combine(slnSearchPath, repoModel.Name, change.Path.Replace('/', '\\')),
                                ChangeAuthor = commit.Author.Name,
                                DateChanged = commit.Author.When.LocalDateTime,
                                Message = commit.MessageShort,
                                Sha = commit.Sha
                            });

                        }
                    }
                }
            }
            return result;
        }

        public static void DoGitBranchCheckout(RepoModel repoModel, string branchName)
        {

            using (var repo = new Repository(repoModel.Path))
            {
                Debug.WriteLine($"{repoModel.Name} active branch: {repo.Head.UpstreamBranchCanonicalName}");

                //var branchNameNoRefHead =
                //    repo.Head.UpstreamBranchCanonicalName.Replace("refs/heads/", "");

                //repoModel.BranchName = branchNameNoRefHead;

                //var branchesList = new List<string>();

                ////Get local branches
                //foreach (var b in repo.Branches.Where(b => !b.IsRemote))
                //{
                //    var tempBranchNameNoRefHead =
                //        b.UpstreamBranchCanonicalName.Replace("refs/heads/", "");
                //    branchesList.Add(tempBranchNameNoRefHead);
                //}

                var branch = repo.Branches[branchName];

                if (branch == null)
                {
                    return ;
                }

                var currentBranch = Commands.Checkout(repo, branch);
            }
        }


        private static bool IsRemoteServerConnectionOK(RepoModel repoModel, SummaryRecord summaryRecord)
        {
            if (IsSiteAccessible(repoModel.RemoteURL))
                return true;

            summaryRecord.Result = "Error";
            summaryRecord.Message = $"Could not connect to remote server: {repoModel.RemoteURL}";
            return false;

        }

        public static bool IsSiteAccessible(string siteUrl)
        {
            siteUrl = siteUrl.Replace(".git", "");

            var ping = new Ping();
            var result = ping.Send(new Uri(siteUrl).Host);
            var success = false;

            if (result != null)
                success = result.Status == IPStatus.Success;

            return success;
        }

        /// <summary>
        /// Acquires username and password by RepoSourceTypeEnum
        /// Returns false if both parameters are blank
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="repoSourceTypeEnum"></param>
        /// <returns></returns>
        private static bool GetUserNameAndPassword(out string userName, out string password,
            RepoSourceTypeEnum repoSourceTypeEnum)
        {
            var iniFile = new IniFile(FormMain.OptionsIni);

            var repoTypePrefix = repoSourceTypeEnum == RepoSourceTypeEnum.AzureDevOps ? "AzureDevOps" : "GitHub";

            userName = iniFile.ReadString(OptionsForm.AuthenticationSection, $"{repoTypePrefix}UserName", "");
            password = ConvertHexStringToString(iniFile.ReadString(OptionsForm.AuthenticationSection,
                $"{repoTypePrefix}Password",
                ""));

            var useUserNamePassword =
                iniFile.ReadBool(OptionsForm.AuthenticationSection, "UseUsernameAndPassword", true);

            if (repoSourceTypeEnum == RepoSourceTypeEnum.AzureDevOps && !useUserNamePassword)
            {
                var adoHexPat = iniFile.ReadString(OptionsForm.AuthenticationSection, "AzureDevOpsPAT", "");
                userName = ConvertHexStringToString(adoHexPat);
                password = ConvertHexStringToString(adoHexPat);
                var emptyPassword = !string.IsNullOrEmpty(password);
                return emptyPassword;
            }
            else
            {

                var emptyUserName = !string.IsNullOrEmpty(userName);
                var emptyPassword = !string.IsNullOrEmpty(password);
                return emptyUserName || emptyPassword;
            }
        }

        public static bool FilePathHasInvalidChars(string path)
        {
            var containsABadCharacter =
                new Regex("[" + Regex.Escape(new string(Path.GetInvalidFileNameChars())) + "]");
            return !containsABadCharacter.IsMatch(path);
        }

        public static string GetRepoPreferredSolution(RepoModel repoModel)
        {
            var iniFile = new IniFile(FormMain.RepoPropertiesIni);
            var fileName = iniFile.ReadString(repoModel.Name, "PreferredSolution", "");

            if (!string.IsNullOrEmpty(fileName))
                return !File.Exists(fileName) ? string.Empty : fileName;

            var slnList = repoModel.GetSolutionList();
            return slnList.Count == 1 ? slnList.First() : string.Empty;

        }


        public static int GetBatchFileCount(RepoModel repoModel)
        {
            var batFiles = Directory.EnumerateFiles(repoModel.Path,
                "*.bat", SearchOption.AllDirectories).ToList();

            var batchToRunCount = 0;

            var iniFile = new IniFile(FormMain.RunBatchIni);
            foreach (var batFile in batFiles)
            {
                if (iniFile.ReadBool(repoModel.Path, batFile, false))
                    batchToRunCount++;
            }

            return batchToRunCount;

        }

        public static string GetFirstSelectedBatchFileName(RepoModel repoModel)
        {
            var iniFile = new IniFile(FormMain.RunBatchIni);
            foreach (var batFile in Directory.EnumerateFiles(repoModel.Path,
                "*.bat", SearchOption.AllDirectories).ToList())
            {
                if (iniFile.ReadBool(repoModel.Path, batFile, false))
                    return Path.GetFileName(batFile);
            }

            return string.Empty;

        }
    }

}
