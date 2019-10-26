namespace NugetManagement
{
    public class ModelPackageUpgrade
    {
        public bool Upgrade { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }

        public int OutOfDatePackages { get; set; } = 0;

        public override string ToString()
        {
            return $"{PackageName} {Version} {OutOfDatePackages}";
        }
    }
}
