﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SQLDMTestAutomation.SQLDMRecordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RunQueryForSQLStmtNULL recording.
    /// </summary>
    [TestModule("ebd0056b-0673-464c-b95c-cd778ee6fab0", ModuleType.Recording, 1)]
    public partial class RunQueryForSQLStmtNULL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SQLDMTestAutomation.SQLDMTestAutomationRepository repository.
        /// </summary>
        public static SQLDMTestAutomation.SQLDMTestAutomationRepository repo = SQLDMTestAutomation.SQLDMTestAutomationRepository.Instance;

        static RunQueryForSQLStmtNULL instance = new RunQueryForSQLStmtNULL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RunQueryForSQLStmtNULL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RunQueryForSQLStmtNULL Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SSMS.MicrosoftSQLServerManagementStudio.QueryEditor' at Center.", repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditorInfo, new RecordItemIndex(0));
            repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditor.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence select SQLStatementID from SQLStatements where SQLStatement = 'dbcc ProcCache' with focus on 'SSMS.MicrosoftSQLServerManagementStudio.QueryEditor'.", repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditorInfo, new RecordItemIndex(1));
            repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditor.PressKeys("select SQLStatementID from SQLStatements where SQLStatement = 'dbcc ProcCache'");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SSMS.MicrosoftSQLServerManagementStudio.Execute' at Center.", repo.SSMS.MicrosoftSQLServerManagementStudio.ExecuteInfo, new RecordItemIndex(2));
            repo.SSMS.MicrosoftSQLServerManagementStudio.Execute.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SSMS.MicrosoftSQLServerManagementStudio.Execute' at Center.", repo.SSMS.MicrosoftSQLServerManagementStudio.ExecuteInfo, new RecordItemIndex(3));
            repo.SSMS.MicrosoftSQLServerManagementStudio.Execute.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SSMS.MicrosoftSQLServerManagementStudio.QueryEditor'.", repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditorInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditor);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'select PlanID from QueryMonitorStatistics where SQLStatementID ='4378' ' with focus on 'SSMS.MicrosoftSQLServerManagementStudio.QueryEditor'.", repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditorInfo, new RecordItemIndex(5));
            repo.SSMS.MicrosoftSQLServerManagementStudio.QueryEditor.PressKeys("select PlanID from QueryMonitorStatistics where SQLStatementID ='4378' ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SSMS.MicrosoftSQLServerManagementStudio.Execute' at Center.", repo.SSMS.MicrosoftSQLServerManagementStudio.ExecuteInfo, new RecordItemIndex(6));
            repo.SSMS.MicrosoftSQLServerManagementStudio.Execute.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SSMS.MicrosoftSQLServerManagementStudio.Execute' at Center.", repo.SSMS.MicrosoftSQLServerManagementStudio.ExecuteInfo, new RecordItemIndex(7));
            repo.SSMS.MicrosoftSQLServerManagementStudio.Execute.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
