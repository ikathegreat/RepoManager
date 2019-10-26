using System;

namespace NugetManagement
{
    public class ModelFlatPackage
    {

        public string SolutionName { get; set; }
        public string ProjectName { get; set; }

        public string PackageName { get; set; }
        public Version Version { get; set; }
        public string TargetFramework { get; set; }
        public string SolutionFullPath{ get; set; }
        public string ProjectFullPath { get; set; }
        public string ProjectTargetFramework { get; set; }

        public override string ToString()
        {
            return $"{SolutionName} {ProjectName} {ProjectTargetFramework} {PackageName} {Version} {TargetFramework}";

        }
    }
}
