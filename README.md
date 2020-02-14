# RepoManager

Desktop Git repository manager (designed for for .NET projects/Visual Studio) with quick actions and shortcuts for repo (repository) folder, its contents, and web links.

![RepoManagerImage](https://imgur.com/VgnRSqP.png "Repo Manager")

## Getting Started
Open options and enter your Azure DevOps Server host URL or GitHub credentials (not needed for public repositories). Set Repository Search Path if needed. Default location is `C:\Users\{WindowsUsername}\source\repos`.

## Git Actions

### Fetch
Performs a git fetch for all selected (checked) repos with a prompt. 

### Pull 
Performs a git pull for all selected (checked) repos with a prompt. May fail if there are conflicts with incoming changes.

### Reset
Performs a git (hard) reset for all selected (checked) repos with a prompt. 

### Clone
Opens a dialog to provide a remote repository URL and the desired local folder name. Will indicate if directory already exists. Root path is set in the Options.

### Clone Multiple...
Opens a dialog to provide multiple remote repository URLs and the desired local folder name. Will indicate if directory already exists. Root path is set in the Options.

## Local Actions

### Run Batch
Runs any number of Windows .bat files that reside in the selected repo. Useful for common scripts related to cleaning, nuget packages, copying files, etc. 

Right click on a repo to open the Run Batch Files dialog to configure which .bat files to run in selected repo when this action is executed. 

### Delete bin/obj
Deletes any folder named "bin" or "obj" in the selected repo. Useful to remove those folders without having to open Visual Studio. May fail if Visual Studio is open to that solution or the built executable is running. 

### Delete .vs
Deletes any .vs folders in the selected repo. Useful to reset odd warnings, compiler, or Visual Studio related settings. May fail if Visual Studio is open to that solution or the built executable is running. 

### Nuget Packages
![RepoManagerImage](https://i.imgur.com/3TBZtfY.png "Repo Manager - Manage Nuget Packages")

Opens a dialog to scan nuget packages across all selected repos. Able to find mismatched nuget package versions and update the .csproj and packages.config files to match. 

### Open
Opens the selected repos' folders.

### Open .sln
Opens the preferred solution (.sln) for the focused repo. If the repo has 1 solution that is opened. If there are multiple, a prompt will appear to select the preferred solution to use. 

### Delete
Deletes the selected repos' folder. Cannot undo this action. May fail if Visual Studio is open to that solution or the built executable is running. 

### Properties
![RepoManagerImage](https://i.imgur.com/dOBYUp9.png "Repo Manager - Properties")

Opens the focused repo's Properties dialog. View recently changed files and commits. Select preferred solution and option to open it as Administrator. 

## Context Menu

![RepoManagerImage](https://i.imgur.com/togYxcb.png "Repo Manager - Context Menu")

### Repository Name
No action. 

### Web Links
Direct shortcuts to web interface for git host. Actions vary based on type of git host.

### Git Actions
Same actions available in the toolbar. Will only be performed on the focused grid row repository (what was right-clicked on).

### Tools
- Open in Gitkraken - Opens the focused repo's path in [Gitkraken](https://www.gitkraken.com/)
- Open in VS Code - Opens the focused repo's path in [VS Code](https://code.visualstudio.com/)
- Open in Git Bash - Opens the focused repo's path in [Git Bash](https://gitforwindows.org/). The installation directory must beC:\Program Files\Git.

### Local Actions
#### Batch Files
Opens a dialog listing all Windows Batch .bat files in the focused repository. Run Batch wil execute the selected batch files from this window.

All others as the same actions available in the toolbar. 

### Copy Path
Copies the focused repo folder path to the clipboard as text.

### Ignore Repo
Adds the focused repo to the ignored list. Folder status refresj and Git actions performed on ignored are skipped.

### Include Repo in Scan
Removes the focsed repo from the ignored list.

### Solutions
Expands a submenu listing all .sln files in the focused repo directory. 

### Branches
Expands a submenu listing local branches for the focused repo.

### Properties
Opens the Repo Properties dialog to set the Preferred Solution, viewing recently changed files, the commit history, and configuring SmartGit.

## Other

### Options

![RepoManagerImage](https://i.imgur.com/a2FeWNW.png "Repo Manager - Options dialog")

Opens Options dialog. 

### About
Opens About dialog. 

### Feedback
Opens GitHub Issues webpage.

### Refresh
Performs a scan of local git repos based on the Repository Search Path. Folders without a .git folder are ignored. Refresh does not modify any folder contents or perform any git related functions. 

