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
    ///The LaunchApplication recording.
    /// </summary>
    [TestModule("73fb0df9-782d-480a-b57f-0e0513e3249c", ModuleType.Recording, 1)]
    public partial class LaunchApplication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SQLDMTestAutomation.SQLDMTestAutomationRepository repository.
        /// </summary>
        public static SQLDMTestAutomation.SQLDMTestAutomationRepository repo = SQLDMTestAutomation.SQLDMTestAutomationRepository.Instance;

        static LaunchApplication instance = new LaunchApplication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchApplication()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchApplication Instance
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

            //LaunchApplication_Run_application(repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.SQLDMTodayInfo);
            //Delay.Milliseconds(0);
            
            //KillApplicationProcess();
            //Delay.Milliseconds(0);
            
            CommonMethods.KillApplicationProcess("SQLdmDesktopClient");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\Idera\\Idera SQL diagnostic manager\\SQLdmDesktopClient.exe' with arguments '' in normal mode.", new RecordItemIndex(3));
            Host.Local.RunApplication("C:\\Program Files\\Idera\\Idera SQL diagnostic manager\\SQLdmDesktopClient.exe", "", "C:\\Program Files\\Idera\\Idera SQL diagnostic manager", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.SQLDMToday'", repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.SQLDMTodayInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.SQLDMTodayInfo.WaitForExists(60000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
