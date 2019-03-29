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

namespace SQLDMTestAutomation.SSMSRecordingds
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ConnectToServer recording.
    /// </summary>
    [TestModule("b292c181-56e2-4512-851c-b8ba8fa5411c", ModuleType.Recording, 1)]
    public partial class ConnectToServer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SQLDMTestAutomation.SQLDMTestAutomationRepository repository.
        /// </summary>
        public static SQLDMTestAutomation.SQLDMTestAutomationRepository repo = SQLDMTestAutomation.SQLDMTestAutomationRepository.Instance;

        static ConnectToServer instance = new ConnectToServer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConnectToServer()
        {
            ServerName = "";
            Query = "select [QueryMonitorTopPlanCountFilter],[QueryMonitorTopPlanCategoryFilter],[QueryMonitorQueryStoreMonitoringEnabled] from MonitoredSQLServers  ";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConnectToServer Instance
        {
            get { return instance; }
        }

#region Variables

        string _Query;

        /// <summary>
        /// Gets or sets the value of variable Query.
        /// </summary>
        [TestVariable("cd48ea83-1538-4c3f-9466-8bb54fd893bc")]
        public string Query
        {
            get { return _Query; }
            set { _Query = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ServerName.
        /// </summary>
        [TestVariable("3557f9c7-7eec-4561-9bb8-d219dbb276d6")]
        public string ServerName
        {
            get { return repo.ServerName; }
            set { repo.ServerName = value; }
        }

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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$ServerName' on item 'SSMS.ConnectionDialog.ServerNameToConnect'.", repo.SSMS.ConnectionDialog.ServerNameToConnectInfo, new RecordItemIndex(0));
            repo.SSMS.ConnectionDialog.ServerNameToConnect.Element.SetAttributeValue("Text", ServerName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SSMS.ConnectionDialog.Connect' at Center.", repo.SSMS.ConnectionDialog.ConnectInfo, new RecordItemIndex(1));
            repo.SSMS.ConnectionDialog.Connect.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'SSMS.ConnectionDialog.Connect'.", repo.SSMS.ConnectionDialog.ConnectInfo, new RecordItemIndex(2));
            repo.SSMS.ConnectionDialog.Connect.Press();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
