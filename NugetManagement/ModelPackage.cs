using System;

namespace NugetManagement
{
    public class ModelPackage
    {

        public string Name { get; set; }
        public Version Version { get; set; }
        public string TargetFramework { get; set; }
    }
}
