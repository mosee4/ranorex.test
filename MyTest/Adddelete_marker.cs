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

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Adddelete_marker recording.
    /// </summary>
    [TestModule("6c8dd527-511d-429a-a216-fbf6caeb86fb", ModuleType.Recording, 1)]
    public partial class Adddelete_marker : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Adddelete_marker instance = new Adddelete_marker();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adddelete_marker()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adddelete_marker Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 965;272.", repo.VnaNG.SelfInfo, new RecordItemIndex(0));
            repo.VnaNG.Self.Click("965;272");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 871;160.", repo.VnaNG.SelfInfo, new RecordItemIndex(1));
            repo.VnaNG.Self.Click("871;160");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 875;202.", repo.VnaNG.SelfInfo, new RecordItemIndex(2));
            repo.VnaNG.Self.Click("875;202");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot11' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(4));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot11, VnaNG_Screenshot11_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 854;441.", repo.VnaNG.SelfInfo, new RecordItemIndex(5));
            repo.VnaNG.Self.Click("854;441");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 885;441.", repo.VnaNG.SelfInfo, new RecordItemIndex(6));
            repo.VnaNG.Self.Click("885;441");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot12' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(7));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot12, VnaNG_Screenshot12_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot11
        { get { return repo.VnaNG.SelfInfo.GetScreenshot11(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot11_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,595,71,76"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot12
        { get { return repo.VnaNG.SelfInfo.GetScreenshot12(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot12_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,588,73,79"); } }

#endregion
    }
#pragma warning restore 0436
}
