using System;
using System.Diagnostics;
using System.Windows.Forms;
using CommandLineParser.Arguments;
using CommandLineParser.Exceptions;

namespace RepoManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ParseCommandLineArgs(args);

            Application.Run(new FormMain());
        }

        private static void ParseCommandLineArgs(string[] args)
        {
            var parser = new CommandLineParser.CommandLineParser
            {
                ShowUsageOnEmptyCommandline = true,
                AcceptSlash = true
            };

            //var silentModeArgument = new SwitchArgument(
            //        's',
            //        "silent",
            //        "Executes AutoDEMO in silent mode",
            //        false)
            //    { Optional = true };
            //parser.Arguments.Add(silentModeArgument);

            try
            {
                parser.ParseCommandLine(args);

                //Options.SilentMode = silentModeArgument.Value;


            }
            catch (CommandLineException cle)
            {
                Debug.WriteLine($"CommandLineException: {cle.Message}");
            }
        }
    }


}
