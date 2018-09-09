using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealGrid {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EnumsAndComboBox());
        }

        /// <summary>
        /// Takes a string ( class Name ? ) in format 'StringWithoutSpace' and returns 'String Without Space'
        /// </summary>
        /// <param name="toAddSpace">String where all uppercases ( except first and last char ) get's an space added</param>
        /// <returns>'StringWithoutSpace' returns 'String Without Space'</returns>
        public static string UpperAddSpace(
            string toAddSpace
            ) {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 1; i < toAddSpace.Length - 1; i++) {
                // if current char is upper and previous and next char is lower ...
                if ((alphabet.Contains(toAddSpace[i].ToString())
                 && (!alphabet.Contains(toAddSpace[i - 1].ToString()))
                 && (!alphabet.Contains(toAddSpace[i + 1].ToString())))
                 ) {
                    // insert a space
                    toAddSpace = toAddSpace.Insert(i, " ");
                    i++;
                } else if (alphabet.Contains(toAddSpace[i].ToString())
                   && (!alphabet.Contains(toAddSpace[i + 1].ToString()))) {
                    // or if current char is upper and next is not ...
                    toAddSpace = toAddSpace.Insert(i + 1, " ");
                    i++;
                } else if (alphabet.Contains(toAddSpace[i].ToString())
                   && (!alphabet.Contains(toAddSpace[i - 1].ToString()))) {
                    // or if current char is upper and previous is not ...
                    toAddSpace = toAddSpace.Insert(i, " ");
                    i++;
                } else {
                    ;
                }
            }

            return toAddSpace;
        }
    }

    public class TaskStatus {
        public int Number { get; set; }
        public TaskNorClientLightNew Task;
        public string TaskName { get; set; }
        public bool DoneFlag { get; set; }                          // task marked as completed
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }
        public int DurationInSeconds { get; set; }                  // duration of task in seconds
        public int TotalMinutes { get; set; }                       // duration of task in minutes
        public int LogCount { get; set; }                           // number of lines in log
        public long ErrorCount { get; set; }
        public int ErrorTolerance { get; set; }
        public string TaskLink { get; set; }

        public string[] Output;                                     // output from log windows
        public List<string> URLSAdded = new List<string>();         // task added these web pages 
        public Color GridBackgroundColor;                           // background color used in grid
        public Color GridForegroundColor;                           // foreground color used in grid
    }

    public enum TaskNorClientLightNew {
        // backup
        FirstInCreatePart,
        CloseSolution,
        RenamePreviousVersion,

        // prototype
        CreateLocalDatabase,
        CreateAzureDatabase,
        CopyTemplatesDuriansAndTailored,
        CreateDatabaseManager,
        ExecuteDatabaseManager,
        CreateSolutionInit,
        CreateSolutionDatabase,
        CreateSolutionContract,
        CreateSolutionData,
        CreateSolutionBusinessSoap,
        CreateSolutionBusinessProxy,
        CreateSolutionWinForm,
        CreateSolutionFixEndpoints,
        CreateSolutionClose,
        CreateSolutionDotNetFrameworkWeb,
        CreateSolutionDotNetCoreRest,
        CreateSolutionDatabaseManager,
        CreateSolutionDotNetFrameworkSetup,
        CreateSolutionCreate,
        CreateSolutionCleanup,
        CreateSolutionSetVersion,
        CreateAzureWebAppRestLayer,
        CreateAzureWebAppsSoapLayer,
        CreateAzureWebAppsWebLayer,

        // templates and durians
        IncludeTailoredDirectories,
        IncludeTailoredFiles,
        ProcessTemplates,
        ProcessTemplatesIndex,
        ProcessDurians,

        // visual studio tidy up
        ExcludeSqlFilesFromBuild,
        ExcludeDatabaseProjectFromBuild,

        // build
        CopyTemplatesDuriansAndTailoredFinal,
        SelectEnvironment,
        CleanSolution,
        ReloadSolution,
        BuildSolution,

        // azure apps
        AddVersionStamps,
        PublishWinFormLayer,
        PublishWinFormLayerIncludeTailoredDirectories,
        PublishWinFormLayerIncludeTailoredFiles,
        PublishWinFormLayerMakeInstallPublish,
        AzurePublishDotNetCoreWebAppExtractPassword,
        AzurePublishDotNetCoreWebAppCreatePublishBat,
        AzurePublishDotNetCoreWebAppBuild,
        AzurePublishDotNetCoreWebAppPublishToFile,
        AzurePublishDotNetCoreWebAppPublishToAzure,
        AzurePublishDotNetCoreWebAppPublishToAzureResult,
        AzurePublishDotNetFrameworkBusinessWebAppBuildPackageToDisk,
        AzurePublishDotNetFrameworkBusinessWebAppPublishToAzure,
        AzurePublishDotNetFrameworkWebAppPublishMakePackage,
        AzurePublishDotNetFrameworkWebAppPackageToAzure,
        SaveSolution,

        // backup
        MakeBackupOfBuilder,

        // publish
        IncreaseVersionAndRepublishCloseSolution,
        IncreaseVersionAndRepublishCleanCache,
        IncreaseVersionAndRepublishCleanWithMage,
        IncreaseVersionAndRepublishIncreaseOverallVersion,
        IncreaseVersionAndRepublishApplyVersionNumber,
        IncreaseVersionAndRepublishRestart,
        IncreaseVersionAndRepublishPublishWinForm,
        IncreaseVersionAndRepublishMakeInstallPublishHtm,
        IncreaseVersionAndRepublishIncludeDirectoriesImmediately,
        IncreaseVersionAndRepublishIncludeFilesImmediately,
        IncreaseVersionAndRepublishCleanBuild,
        IncreaseVersionAndRepublishBuild,
        IncreaseVersionAndRepublishDotNetFrameworkToAzure,

        // summarize
        OpenMajorWebSites,
        TimeUsedForCreatePart,
        SendMailReport,
        LastInCreatePart,

        // cleanup
        FirstInCleanupPart,
        DeleteLocalDatabase,
        RemoveAzureWebAppCore,
        RemoveAzureWebAppBusiness,
        RemoveAzureWebApp,
        DeleteAzureDatabase,

        TimeUsedForCleanupPart,
        LastInCleanupPart,

        Last
    }
}
