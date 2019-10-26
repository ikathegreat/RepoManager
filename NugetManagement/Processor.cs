using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace NugetManagement
{
    public class Processor
    {
        public string SolutionSearchPath { get; set; }
        public List<ModelSolution> ModelSolutionList { get; set; }
        public List<ModelFlatPackage> ModelFlatPackageList { get; set; }

        public List<ModelPackageUpgrade> DistinctPackagesToUpgradeList { get; set; }
        public List<ModelPackageUpgrade> ModelPackageUpgradeList { get; set; }
        public List<ModelPackageUpgrade> SelectedModelPackageUpgradeList { get; set; }

        public bool IsValidSearchPath()
        {
            if (string.IsNullOrEmpty(SolutionSearchPath))
                return false;

            if (SolutionSearchPath.Contains("|"))
            {
                var pathsList = SolutionSearchPath.Split('|');
                return pathsList.All(Directory.Exists);
            }
            else
            {
                if (!Directory.Exists(SolutionSearchPath))
                {
                    return false;
                }

            }
            return true;
        }

        public void BuildSolutionList()
        {

            ModelSolutionList = new List<ModelSolution>();

            if (!IsValidSearchPath())
                return;

            var slnFileList = new List<string>();

            if (SolutionSearchPath.Contains("|"))
            {
                //Multiple paths
                var pathsList = SolutionSearchPath.Split('|');
                foreach (var path in pathsList)
                {
                    slnFileList.AddRange(Directory.EnumerateFiles(path, "*.sln", SearchOption.AllDirectories).ToList());
                }
            }
            else
            {
                try
                {
                    slnFileList = Directory.EnumerateFiles(SolutionSearchPath, "*.sln", SearchOption.AllDirectories).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}");
                }
            }

            ModelSolutionList = (from solutionPath in slnFileList
                                 let solutionDirectory = Path.GetDirectoryName(solutionPath)
                                 where solutionDirectory != null
                                 select new ModelSolution(solutionPath)).ToList();


        }

        public void BuildPackagesLists(GetUpgradePackagesMode getUpgradePackagesMode)
        {

            ModelFlatPackageList = new List<ModelFlatPackage>();

            foreach (var modelSolution in ModelSolutionList)
            {
                foreach (var modelProject in modelSolution.ProjectList)
                {
                    foreach (var modelPackage in modelProject.PackageList)
                    {
                        var mFlatPackage = new ModelFlatPackage
                        {
                            SolutionName = modelSolution.FileName,
                            ProjectName = modelProject.FileName,
                            PackageName = modelPackage.Name,
                            TargetFramework = modelPackage.TargetFramework,
                            Version = modelPackage.Version,
                            SolutionFullPath = modelSolution.FullPath,
                            ProjectFullPath = modelProject.FullPath,
                            ProjectTargetFramework = modelProject.ProjectTargetFramework
                        };

                        ModelFlatPackageList.Add(mFlatPackage);
                    }
                }
            }

            DistinctPackagesToUpgradeList = new List<ModelPackageUpgrade>();

            switch (getUpgradePackagesMode)
            {
                case GetUpgradePackagesMode.None:
                    GetPackagesForLatestUsed();
                    break;
                case GetUpgradePackagesMode.Latest:
                    GetPackagesForLatestUsed();
                    break;
                case GetUpgradePackagesMode.Manual:
                    GetPackagesForManual();
                    break;
                default:
                    Debug.WriteLine($"Unknown mode: {getUpgradePackagesMode}");
                    break;
            }
        }


        private void GetPackagesForLatestUsed()
        {
            ModelPackageUpgradeList = ModelFlatPackageList.Select(package => new ModelPackageUpgrade { Upgrade = false, PackageName = package.PackageName, Version = package.Version.ToString() }).ToList();

            var packagesWithMultipleVersions = ModelPackageUpgradeList.Distinct(new DistinctPackageUpgradeComparer()).GroupBy(x => x.PackageName).Where(y => y.Count() > 1).ToList();


            foreach (var package in packagesWithMultipleVersions)
            {
                var multipleVersionPackageList = ModelPackageUpgradeList.FindAll(x => x.PackageName == package.Key);

                var latestVersion = new Version(0, 0, 0);
                foreach (var foundPackage in multipleVersionPackageList)
                {
                    if (new Version(foundPackage.Version) > latestVersion)
                        latestVersion = new Version(foundPackage.Version);

                }

                var outOfDatePackagesCount = 0;
                foreach (var foundPackage in multipleVersionPackageList)
                {
                    //if (!HideDetailedInfo)
                    //    Console.WriteLine($" {foundPackage.ParentProject} uses {foundPackage.Version} {foundPackage.TargetFramework}");

                    if (new Version(foundPackage.Version) != latestVersion)
                    {
                        outOfDatePackagesCount++;
                    }
                }


                var mPackageUpgrade = new ModelPackageUpgrade
                {
                    Upgrade = false,
                    PackageName = package.Key,
                    Version = latestVersion.ToString(),
                    OutOfDatePackages = outOfDatePackagesCount
                };
                DistinctPackagesToUpgradeList.Add(mPackageUpgrade);

            }


        }

        private void GetPackagesForManual()
        {
            ModelPackageUpgradeList = ModelFlatPackageList.Select(package => new ModelPackageUpgrade { Upgrade = false, PackageName = package.PackageName, Version = package.Version.ToString() }).ToList();

            var packagesWithMultipleVersions = ModelPackageUpgradeList.Distinct(new DistinctPackageUpgradeComparer()).GroupBy(x => x.PackageName).Where(y => y.Count() > 1).ToList();

            foreach (var package in packagesWithMultipleVersions)
            {
                var multipleVersionPackageList = ModelPackageUpgradeList.FindAll(x => x.PackageName == package.Key);

                var latestVersion = new Version(0, 0, 0);
                foreach (var foundPackage in multipleVersionPackageList)
                {
                    if (new Version(foundPackage.Version) > latestVersion)
                        latestVersion = new Version(foundPackage.Version);
                }

                var outOfDatePackagesCount = 0;
                foreach (var foundPackage in multipleVersionPackageList)
                {
                    if (new Version(foundPackage.Version) != latestVersion)
                    {
                        outOfDatePackagesCount++;
                    }
                }

                ModelPackageUpgradeList.Where(x => x.PackageName == package.Key).ToList().ForEach(y => y.Version = latestVersion.ToString());
                ModelPackageUpgradeList.Where(x => x.PackageName == package.Key).ToList().ForEach(y => y.OutOfDatePackages = outOfDatePackagesCount);
            }

            DistinctPackagesToUpgradeList = ModelPackageUpgradeList.Distinct(new DistinctPackageUpgradeNameComparer()).ToList();
        }

        public int UpgradeSelectedPackages()
        {
            var packageUpgradeCount = 0;
            foreach (var modelPackageUpgrade in SelectedModelPackageUpgradeList)
            {
                //Go through each package to upgrade
                if (!modelPackageUpgrade.Upgrade)
                    continue;


                //Go through each solution
                foreach (var modelSolution in ModelSolutionList)
                {

                    if (!modelSolution.ProjectList.Any(x => x.PackageList.Any(y => y.Name == modelPackageUpgrade.PackageName)))
                        continue;


                    //Go through each project in solution
                    foreach (var modelProject in modelSolution.ProjectList)
                    {

                        if (modelProject.PackageList.All(x => x.Name != modelPackageUpgrade.PackageName))
                            continue;


                        foreach (var modelPackage in modelProject.PackageList)
                        {

                            if (modelPackage.Name == modelPackageUpgrade.PackageName)
                            {
                                //Found the right package
                                if (modelPackage.Version.ToString() != modelPackageUpgrade.Version)
                                {
                                    //Found a package to upgrade
                                    modelProject.UpgradeNugetVersion(modelPackage.Name, modelPackageUpgrade.Version);
                                    packageUpgradeCount++;
                                }
                            }

                            FireIncrementUpgradeProgressEvent();

                        }
                    }
                }

            }
            return packageUpgradeCount;
        }


        public event IncrementUpgradeProgressEventHandler IncrementUpgradeProgressEvent;
        public delegate void IncrementUpgradeProgressEventHandler();
        private void FireIncrementUpgradeProgressEvent()
        {
            IncrementUpgradeProgressEvent?.Invoke();
        }



        internal class DistinctPackageUpgradeNameComparer : IEqualityComparer<ModelPackageUpgrade>
        {

            public bool Equals(ModelPackageUpgrade x, ModelPackageUpgrade y)
            {
                return x?.PackageName == y?.PackageName;
            }

            public int GetHashCode(ModelPackageUpgrade obj)
            {
                return obj.PackageName.GetHashCode();
            }
        }
        internal class DistinctPackageUpgradeComparer : IEqualityComparer<ModelPackageUpgrade>
        {

            public bool Equals(ModelPackageUpgrade x, ModelPackageUpgrade y)
            {
                return x.PackageName == y.PackageName &&
                       x.Version == y.Version;
            }

            public int GetHashCode(ModelPackageUpgrade obj)
            {
                return obj.PackageName.GetHashCode() ^
                       obj.Version.GetHashCode();
            }
        }
    }
}
