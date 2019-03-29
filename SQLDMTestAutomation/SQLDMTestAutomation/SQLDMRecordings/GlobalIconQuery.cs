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
    ///The GlobalIconQuery recording.
    /// </summary>
    [TestModule("cb150a51-6b7f-4fb8-bf18-e38f18a438b4", ModuleType.Recording, 1)]
    public partial class GlobalIconQuery : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SQLDMTestAutomation.SQLDMTestAutomationRepository repository.
        /// </summary>
        public static SQLDMTestAutomation.SQLDMTestAutomationRepository repo = SQLDMTestAutomation.SQLDMTestAutomationRepository.Instance;

        static GlobalIconQuery instance = new GlobalIconQuery();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GlobalIconQuery()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GlobalIconQuery Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.Details' at Center.", repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.DetailsInfo, new RecordItemIndex(0));
            repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.Details.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.Details' at 25;9.", repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.DetailsInfo, new RecordItemIndex(1));
            repo.SQLDM.IderaSQLDiagnosticManagerSQLdmRepo.Details.Click("25;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Blank.LineCanvas' at 0;0.", repo.Blank.LineCanvasInfo, new RecordItemIndex(2));
            repo.Blank.LineCanvas.MoveTo("0;0");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'QueryDiagram.QueryDetailsClose' at Center.", repo.QueryDiagram.QueryDetailsCloseInfo, new RecordItemIndex(4));
            repo.QueryDiagram.QueryDetailsClose.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'QueryDiagram.QueryDetailsClose' at Center.", repo.QueryDiagram.QueryDetailsCloseInfo, new RecordItemIndex(5));
            repo.QueryDiagram.QueryDetailsClose.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
