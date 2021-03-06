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
    ///The Analyze_on_off recording.
    /// </summary>
    [TestModule("a779e089-8140-4ee3-86a2-7cbcc1d82110", ModuleType.Recording, 1)]
    public partial class Analyze_on_off : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Analyze_on_off instance = new Analyze_on_off();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Analyze_on_off()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Analyze_on_off Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 968;446.", repo.VnaNG.SelfInfo, new RecordItemIndex(0));
            repo.VnaNG.Self.Click("968;446");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 834;388.", repo.VnaNG.SelfInfo, new RecordItemIndex(1));
            repo.VnaNG.Self.Click("834;388");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerIndicatorSwitchControl2' at 21;13.", repo.VnaNG.ContainerIndicatorSwitchControl2Info, new RecordItemIndex(2));
            repo.VnaNG.ContainerIndicatorSwitchControl2.Click("21;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=679,Height=482}) on item 'VnaNG.DiagramView'.", repo.VnaNG.DiagramViewInfo, new RecordItemIndex(3));
            Validate.CompareImage(repo.VnaNG.DiagramViewInfo, DiagramView_Screenshot1, DiagramView_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 971;201.", repo.VnaNG.SelfInfo, new RecordItemIndex(4));
            repo.VnaNG.Self.Click("971;201");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 776;158.", repo.VnaNG.SelfInfo, new RecordItemIndex(5));
            repo.VnaNG.Self.Click("776;158");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 803;339.", repo.VnaNG.SelfInfo, new RecordItemIndex(6));
            repo.VnaNG.Self.Click("803;339");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 961;203.", repo.VnaNG.SelfInfo, new RecordItemIndex(7));
            repo.VnaNG.Self.Click("961;203");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot5' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(8));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot5, BackgroundItem_Screenshot5_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 977;200.", repo.VnaNG.SelfInfo, new RecordItemIndex(9));
            repo.VnaNG.Self.Click("977;200");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 793;153.", repo.VnaNG.SelfInfo, new RecordItemIndex(10));
            repo.VnaNG.Self.Click("793;153");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 849;294.", repo.VnaNG.SelfInfo, new RecordItemIndex(11));
            repo.VnaNG.Self.Click("849;294");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 957;204.", repo.VnaNG.SelfInfo, new RecordItemIndex(12));
            repo.VnaNG.Self.Click("957;204");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot6' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(13));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot6, BackgroundItem_Screenshot6_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 957;204.", repo.VnaNG.SelfInfo, new RecordItemIndex(14));
            repo.VnaNG.Self.Click("957;204");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 771;165.", repo.VnaNG.SelfInfo, new RecordItemIndex(15));
            repo.VnaNG.Self.Click("771;165");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 822;247.", repo.VnaNG.SelfInfo, new RecordItemIndex(16));
            repo.VnaNG.Self.Click("822;247");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 962;202.", repo.VnaNG.SelfInfo, new RecordItemIndex(17));
            repo.VnaNG.Self.Click("962;202");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating CompareImage (Screenshot: 'Screenshot7' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(18));
                Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot7, BackgroundItem_Screenshot7_Options, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 958;239.", repo.VnaNG.SelfInfo, new RecordItemIndex(19));
            repo.VnaNG.Self.Click("958;239");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating CompareImage (Screenshot: 'Screenshot8' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(20));
                Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot8, BackgroundItem_Screenshot8_Options, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl3' at 29;10.", repo.VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl3Info, new RecordItemIndex(21));
            repo.VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl3.Click("29;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl' at 14;2.", repo.VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControlInfo, new RecordItemIndex(22));
            repo.VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl.Click("14;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 794;151.", repo.VnaNG.SelfInfo, new RecordItemIndex(23));
            repo.VnaNG.Self.Click("794;151");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 797;211.", repo.VnaNG.SelfInfo, new RecordItemIndex(24));
            repo.VnaNG.Self.Click("797;211");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 960;196.", repo.VnaNG.SelfInfo, new RecordItemIndex(25));
            repo.VnaNG.Self.Click("960;196");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=236,Height=15}) on item 'VnaNG.AiItemPropertyRow'.", repo.VnaNG.AiItemPropertyRowInfo, new RecordItemIndex(26));
            Validate.CompareImage(repo.VnaNG.AiItemPropertyRowInfo, AiItemPropertyRow_Screenshot2, AiItemPropertyRow_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl1' at 27;10.", repo.VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl1Info, new RecordItemIndex(27));
            repo.VnaNG.TabSelectorToolBar2.ContainerIndicatorSwitchControl1.Click("27;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar2.ContainerHeaderTabItemLayout1' at 40;18.", repo.VnaNG.TabSelectorToolBar2.ContainerHeaderTabItemLayout1Info, new RecordItemIndex(28));
            repo.VnaNG.TabSelectorToolBar2.ContainerHeaderTabItemLayout1.Click("40;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot9' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(29));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot9, BackgroundItem_Screenshot9_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage DiagramView_Screenshot1
        { get { return repo.VnaNG.DiagramViewInfo.GetScreenshot1(new Rectangle(0, 0, 679, 482)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions DiagramView_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,482;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot5
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot5(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot5_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot6
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot6(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot6_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot7
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot7(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot7_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot8
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot8(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot8_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage AiItemPropertyRow_Screenshot2
        { get { return repo.VnaNG.AiItemPropertyRowInfo.GetScreenshot2(new Rectangle(0, 0, 236, 15)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions AiItemPropertyRow_Screenshot2_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,236,15;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot9
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot9(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot9_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
