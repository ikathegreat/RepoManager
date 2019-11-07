using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoManager.Models
{
    public static class DummyRepoData
    {
        public static string[] RepoNames = {
            "electron","Python","gatsby","magento2","zipline","WPF-Samples","Prism","kubernetes",
            "vscode", "spark", "rust","ansible","origin","corefx","roslyn", "tensorflow","tgstation",
            "swift", "elasticsearch", "servo", "flutter", "TypeScript", "go", "cli"
        };

        public static string[] DevNames = {
            "Clark Hume","Maddie Hughes","Maisha Benson","Arda Parkinson","Murray Monroe","Renae Huerta",
            "Baran Dickens","Jakub Sears","Theon Miranda","Nathanael Ratcliffe","Klaudia Gilmour","Cinar Phelps",
            "Reagan Humphries","Raya Grant","Akshay Dalton","Reuben Hendrix","Julian Molina","Jamie Mccabe","Simrah Morris"
            ,"Ayisha Hansen"
        };

        public static string[] CommitMessages = {
            "Fixed typo", "Remote desktop exception", "Additional theme colors", "Copying file to desktop causes crash", 
            "Regex search refactoring", ".txt files parse error", "Panel container control alignment issue", 
            "Terminal text is hidden", "Setting update requires application restart", "High CPU and RAM consumption",
            "Search doesn't' find content in files with too long file paths", "When selection clipboard is disabled, the middle button pastes if released outside editor",
            "Can't drag to select linked text in the debug console", "Save workspace as doesn't automatically add extension",
            "Add ability to show both relative and absolute line numbers at the same time", "Display full text in Problems pane", 
            "Scroll issue in grid", "UTF-8 text problem using Korean language", "Odd flicker problem on 4K display",
            "Window resize behavior changes with DPI scaling", "Add new keyboard shortcut for refresh", "Post-build event for updating target"
        };
    }
}
