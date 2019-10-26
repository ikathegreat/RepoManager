using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NugetManagement
{
    public class ModelProject
    {
        public ModelProject(string projectPath)
        {

            FullPath = projectPath;
            FileName = Path.GetFileName(FullPath);
            FileLines = File.ReadAllLines(FullPath).ToList();

            BuildPackageList();

            BuildConfigurationList();

            BuildReferencesList();

            BuildCompileList();

            var assemblyName = GetTagValue("AssemblyName");
            AssemblyName = string.IsNullOrEmpty(assemblyName) ? Path.GetFileNameWithoutExtension(FullPath) : assemblyName;
            ProjectTargetFramework = GetTagValue("TargetFrameworkVersion").Replace("v", "");

            ProjectLastModifiedString = GetLastModifiedStringFromFile(FullPath);

        }

        private void BuildReferencesList()
        {
            ReferenceList = new List<Reference>();
            foreach (var s in FileLines)
            {
                if (!s.Contains("<Reference Include="))
                    continue;

                if (s.Contains("Version="))
                {
                    //Project reference

                    var referenceVersion = s.Split(new[] { "Version=" }, StringSplitOptions.None)
                        .Last().Split(',').First().Trim();

                    var referenceName = s.Split(',').First().Replace("<Reference Include=\"", "").Trim();
                    ReferenceList.Add(new Reference() { Name = referenceName, Version = referenceVersion });
                }
                else
                {
                    //GAC assembly reference
                    var referenceName = s.Split('\"')[1].Replace("<Reference Include=\"", "").Trim();
                    ReferenceList.Add(new Reference() { Name = referenceName, Version = "" });
                }
            }
        }
        private void BuildCompileList()
        {
            CompileList = new List<string>();
            foreach (var s in FileLines)
            {
                if (!s.Contains("<Compile Include="))
                    continue;


                var referenceName = s.Split('\"')[1].Replace("<Compile Include=\"", "").Trim();
                CompileList.Add(referenceName);

            }
        }

        private static string GetLastModifiedStringFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return "Unknown";

            var fileInfo = new FileInfo(filePath);

            return fileInfo.LastWriteTime.ToShortDateString() + " " + fileInfo.LastWriteTime.ToShortTimeString();
        }

        private string GetTagValue(string tagName)
        {
            if (!File.Exists(FullPath))
                return string.Empty;
            foreach (var s in FileLines)
            {
                //if (!s.Contains($"<{tagName}>"))
                //    continue;
                //return s.Replace($"<{tagName}>", "")
                //    .Replace($"</{tagName}>", "").Trim();

                var value = getSingleTagValue(s, tagName);
                if (!string.IsNullOrEmpty(value))
                {
                    return value;
                }
            }
            return string.Empty;
        }
        private void BuildConfigurationList()
        {
            ProjectConfigurationList = new List<ProjectConfiguration>();
            if (!File.Exists(FullPath))
                return;

            const string triggerContainStart = "<PropertyGroup Condition";
            const string triggerContainEnd = "</PropertyGroup>";
            var inConditionPropertyGroup = false;

            var tempProjectConfiguration = new ProjectConfiguration();

            foreach (var s in FileLines)
            {
                if (s.Contains(triggerContainStart) && !inConditionPropertyGroup)
                {
                    tempProjectConfiguration = new ProjectConfiguration();

                    if (s.Contains("$(Configuration)|$(Platform)"))
                    {
                        tempProjectConfiguration.Configuration = s.Split('|')[1].Split('\'').Last().Trim();
                        tempProjectConfiguration.Platform = s.Split('|').Last().Split('\'').First().Trim();
                    }
                    else if (s.Contains("$(Configuration)"))
                    {
                        tempProjectConfiguration.Configuration = s.Split('\'')[3].Trim();
                    }
                    else if (s.Contains("$(Platform)"))
                    {

                        tempProjectConfiguration.Platform = s.Split('\'')[3].Trim();
                    }

                    inConditionPropertyGroup = true;
                    continue;
                }

                if (inConditionPropertyGroup)
                {
                    if (s.Contains("PlatformTarget"))
                        tempProjectConfiguration.PlatformTarget = getSingleTagValue(s, "PlatformTarget");
                    if (s.Contains("DebugSymbols"))
                        tempProjectConfiguration.DebugSymbols = getSingleTagValue(s, "DebugSymbols").ToLower() == "true" ? true : false;
                    if (s.Contains("OutputPath"))
                        tempProjectConfiguration.OutputPath = getSingleTagValue(s, "OutputPath");
                    if (s.Contains("DefineConstants"))
                        tempProjectConfiguration.DefineConstants = getSingleTagValue(s, "DefineConstants");
                    if (s.Contains("Prefer32Bit"))
                        tempProjectConfiguration.Prefer32Bit = getSingleTagValue(s, "Prefer32Bit").ToLower() == "true" ? true : false;
                }

                if (s.Contains(triggerContainEnd) && inConditionPropertyGroup)
                {
                    ProjectConfigurationList.Add(tempProjectConfiguration);
                    inConditionPropertyGroup = false;
                }

            }
        }

        private static string getSingleTagValue(string tagLine, string tagName)
        {

            if (!tagLine.Contains($"<{tagName}>"))
                return string.Empty;
            return tagLine.Replace($"<{tagName}>", "")
                .Replace($"</{tagName}>", "").Trim();
        }

        private void BuildPackageList()
        {
            var packagesPath = Path.Combine(Path.GetDirectoryName(FullPath), "packages.config");

            if (!File.Exists(packagesPath))
                return;

            var packageFileList = File.ReadAllLines(packagesPath);
            foreach (var s in packageFileList)
            {
                if (!s.Contains(@"package id="))
                    continue;

                var col = Regex.Matches(s, "\"([^\"]*)\"");

                var version = new Version(0, 0, 0, 0);
                try
                {
                    var parsedVersion = col[1].Value.Trim('"').Split('-')[0];
                    version = new Version(parsedVersion);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                var mPackage = new ModelPackage
                {
                    Name = col[0].Value.Trim('"'),
                    Version = version,
                    TargetFramework = col[2].Value.Trim('"')
                };

                PackageList.Add(mPackage);
            }
        }

        public string FileName { get; set; }
        public string FullPath { get; set; }
        public string ProjectTargetFramework { get; set; }
        public string AssemblyName { get; set; }
        public string ProjectLastModifiedString { get; set; }
        public List<string> FileLines { get; set; }
        public List<ProjectConfiguration> ProjectConfigurationList { get; set; }
        public List<Reference> ReferenceList { get; set; }
        public List<string> CompileList { get; set; }

        public List<ModelPackage> PackageList { get; set; } = new List<ModelPackage>();

        public void UpgradeNugetVersion(string packageName, string targetVersion)
        {
            UpgradePackagesCsprojFile(packageName, targetVersion);

            UpgradePackagesConfigFile(packageName, targetVersion);
        }

        private void UpgradePackagesCsprojFile(string packageName, string targetVersion)
        {
            if (!File.Exists(FullPath))
                return;

            var newFileLines = new List<string>();


            var combinedPackageVersionString = $"{packageName}.{targetVersion}";

            foreach (var s in FileLines)
            {
                //1 - ItemGroup > Reference
                //<Reference Include="CommandLineArgumentsParser, Version=3.0.19.0, Culture=neutral, processorArchitecture=MSIL">
                //Version is 0.0.0.0 places
                //Not present on all .csproj files

                if (s.Contains($"<Reference Include=\"{packageName}"))
                {
                    var stringToAdd = string.Empty;
                    var fullVersion = new Version(targetVersion);
                    var fullVersionString =
                        $"{fullVersion.Major}.{fullVersion.Minor}.{fullVersion.Build}.{(fullVersion.Revision == -1 ? 0 : fullVersion.Revision)}";

                    var versionEqualSplit = s.Split(new[] { "Version=" }, StringSplitOptions.None);


                    //Exclude public key and version (compile issue)  - not sure of the overall effect of this.
                    //https://stackoverflow.com/questions/16578819/understanding-a-csproj-assembly-reference

                    //stringToAdd += versionEqualSplit[0] + "Version=" + fullVersionString + "," +
                    //               versionEqualSplit[1].Substring(versionEqualSplit[1].IndexOf(',') + 1);


                    //This at least builds now in the sln/project.
                    stringToAdd += versionEqualSplit[0].TrimEnd(' ').TrimEnd(',') + "\">";

                    if (s == stringToAdd)
                    {
                        Debug.WriteLine("Interesting, csproj reference the same, but packages.config was out of date");
                    }

                    newFileLines.Add(stringToAdd);
                }
                else

                //2 - ItemGroup > Reference > HintPath
                //<HintPath>packages\CommandLineArgumentsParser.3.0.19\lib\net452\CommandLineArgumentsParser.dll</HintPath>

                //In some cases, the packages folder might be different than the .sln root directory
                //<HintPath>..\..\..\common\packages\Newtonsoft.Json.11.0.2\lib\net45\Newtonsoft.Json.dll</HintPath>

                if (s.Contains("<HintPath>") && s.Contains($"packages\\{packageName}"))
                {
                    Debug.WriteLine("found 2");

                    var stringToAdd = string.Empty;
                    var versionEqualSplit = s.Split(new[] { packageName }, StringSplitOptions.None).First();
                    var versionEqualSplitHalf = ReplaceFirst(s.Replace(versionEqualSplit, ""), packageName, "");

                    var secondHalf = versionEqualSplitHalf.Substring(versionEqualSplitHalf.IndexOf('\\') + 1);

                    stringToAdd += $"<HintPath>packages\\{packageName}.";
                    stringToAdd += $"{targetVersion}\\{secondHalf}";

                    newFileLines.Add(stringToAdd);

                }
                else

                //I don't believe the below items are needed or affect compiling.

                //----------------------------------------------------------------------

                //3 - Import
                //<Import Project="packages\Fody.3.3.2\build\Fody.targets" Condition="Exists('packages\Fody.3.3.2\build\Fody.targets')" />

                //In some cases, the packages folder might be different than the .sln root directory
                if (s.Contains("<Import Project=\"") && s.Contains($"packages\\{ packageName}"))
                {
                    Debug.WriteLine("found 3");
                }
                else


                //4 - Target > Error
                //<Error Condition="!Exists('packages\Costura.Fody.3.2.0\build\Costura.Fody.props')" Text="$([System.String]::Format('$(ErrorText)', 'packages\Costura.Fody.3.2.0\build\Costura.Fody.props'))" />

                //In some cases, the packages folder might be different than the .sln root directory
                if (s.Contains("<Error Condition=\"") && s.Contains("!Exists('") && s.Contains($"packages\\{ packageName}"))
                {
                    Debug.WriteLine("found 4");
                }
                else
                {
                    newFileLines.Add(s);
                }
            }

            //write to file
            File.WriteAllLines($@"C:\Users\paul.ikeda\Desktop\{Path.GetFileNameWithoutExtension(FullPath)}.csproj", newFileLines);
            //File.WriteAllLines(FullPath, newFileLines, Encoding.UTF8);

            FileLines = File.ReadAllLines(FullPath).ToList();
        }

        public string ReplaceFirst(string text, string search, string replace)
        {
            var pos = text.IndexOf(search, StringComparison.Ordinal);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        public static string truncateStringAfterChar(string input, char pivot)
        {
            var index = input.IndexOf(pivot);
            return index >= 0 ? input.Substring(index + 1) : input;
        }

        private void UpgradePackagesConfigFile(string packageName, string targetVersion)
        {
            var packagesPath = Path.Combine(Path.GetDirectoryName(FullPath), "packages.config");

            if (!File.Exists(packagesPath))
                return;

            var newFileLines = new List<string>();

            var packageFileLines = File.ReadAllLines(packagesPath);
            foreach (var s in packageFileLines)
            {
                if (s.Contains(packageName))
                {
                    var col = Regex.Matches(s, "\"([^\"]*)\"");

                    var version = new Version(0, 0, 0, 0);
                    try
                    {
                        var parsedVersion = col[1].Value.Trim('"').Split('-')[0];
                        version = new Version(parsedVersion);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }

                    newFileLines.Add(s.Replace(version.ToString(), targetVersion));
                }
                else
                {
                    newFileLines.Add(s);
                }
            }

            //write to file
            //File.WriteAllLines(@"C:\Users\paul.ikeda\Desktop\New folder (2)\temp_packages.config", newFileLines);
            File.WriteAllLines(packagesPath, newFileLines, Encoding.UTF8);
        }

        public override bool Equals(object obj)
        {
            var item = obj as ModelProject;

            if (item == null)
            {
                return false;
            }

            return this.FullPath.Equals(item.FullPath);
        }

        public override int GetHashCode()
        {
            return this.FullPath.GetHashCode();
        }
    }

    public class ProjectConfiguration
    {
        public string Configuration { get; set; }
        public string Platform { get; set; }
        public bool DebugSymbols { get; set; }
        public string OutputPath { get; set; }
        public string PlatformTarget { get; set; }
        public bool Prefer32Bit { get; set; }
        public string DefineConstants { get; set; }
    }

    public class Reference
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }
}
