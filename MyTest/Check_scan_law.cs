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
    ///The Check_scan_law recording.
    /// </summary>
    [TestModule("adaa7355-202d-432b-9d6f-582cbbf3f907", ModuleType.Recording, 1)]
    public partial class Check_scan_law : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Check_scan_law instance = new Check_scan_law();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_scan_law()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Check_scan_law Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TextTextSelectorComboBoxControl' at 87;18.", repo.VnaNG.TextTextSelectorComboBoxControlInfo, new RecordItemIndex(0));
            repo.VnaNG.TextTextSelectorComboBoxControl.Click("87;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ListContentListView.POWer' at 64;14.", repo.VnaNG.ListContentListView.POWerInfo, new RecordItemIndex(1));
            repo.VnaNG.ListContentListView.POWer.Click("64;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot7' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(3));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot7, VnaNG_Screenshot7_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ShaderItem1' at 6;6.", repo.VnaNG.ShaderItem1Info, new RecordItemIndex(4));
            repo.VnaNG.ShaderItem1.Click("6;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ListContentListView.LOGarithmic' at 60;15.", repo.VnaNG.ListContentListView.LOGarithmicInfo, new RecordItemIndex(5));
            repo.VnaNG.ListContentListView.LOGarithmic.Click("60;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot8' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(7));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot8, VnaNG_Screenshot8_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ShaderItem1' at 4;3.", repo.VnaNG.ShaderItem1Info, new RecordItemIndex(8));
            repo.VnaNG.ShaderItem1.Click("4;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ListContentListView.SEGMent' at 64;18.", repo.VnaNG.ListContentListView.SEGMentInfo, new RecordItemIndex(9));
            repo.VnaNG.ListContentListView.SEGMent.Click("64;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot9' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(11));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot9, VnaNG_Screenshot9_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ShaderItem1' at 2;7.", repo.VnaNG.ShaderItem1Info, new RecordItemIndex(12));
            repo.VnaNG.ShaderItem1.Click("2;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ListContentListView.LINear' at 48;13.", repo.VnaNG.ListContentListView.LINearInfo, new RecordItemIndex(13));
            repo.VnaNG.ListContentListView.LINear.Click("48;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot10' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(15));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot10, VnaNG_Screenshot10_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot7
        { get { return repo.VnaNG.SelfInfo.GetScreenshot7(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot7_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;8,590,67,71"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot8
        { get { return repo.VnaNG.SelfInfo.GetScreenshot8(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot8_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,582,73,85"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot9
        { get { return repo.VnaNG.SelfInfo.GetScreenshot9(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot9_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,588,73,79"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot10
        { get { return repo.VnaNG.SelfInfo.GetScreenshot10(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot10_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,579,72,91"); } }

#endregion
    }
#pragma warning restore 0436
}
