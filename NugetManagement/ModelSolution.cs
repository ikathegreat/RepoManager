using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace NugetManagement
{
    public class ModelSolution
    {
        public ModelSolution(string fullPath)
        {
            FullPath = fullPath;
            FileName = Path.GetFileName(FullPath);


            var solutionDirectory = Path.GetDirectoryName(FullPath);

            if (solutionDirectory == null)
                return;

            var fileLines = File.ReadAllLines(FullPath);
            foreach (var s in fileLines)
            {
                if (!s.Contains("Project("))
                    continue;


                var project = string.Empty;

                try
                {
                    project = (s.Split(',')[1]).Trim(' ').Trim('\"');
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                var csprojFilePath = Path.Combine(solutionDirectory, project);

                if (File.Exists(csprojFilePath))
                {
                    var mProject = new ModelProject(csprojFilePath);
                    ProjectList.Add(mProject);
                } //else it's a solution folder


            }
        }

        public string FileName { get; set; }
        public string FullPath { get; set; }
        public List<ModelProject> ProjectList { get; set; } = new List<ModelProject>();
    }
}
