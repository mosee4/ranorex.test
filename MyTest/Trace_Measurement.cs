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
    ///The Trace_Measurement recording.
    /// </summary>
    [TestModule("6b676d11-0c48-4d65-8193-eb779ea16f29", ModuleType.Recording, 1)]
    public partial class Trace_Measurement : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Trace_Measurement instance = new Trace_Measurement();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Trace_Measurement()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Trace_Measurement Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerRightSideToolBar.ContainerRoot2' at 51;61.", repo.VnaNG.ContainerRightSideToolBar.ContainerRoot2Info, new RecordItemIndex(0));
            repo.VnaNG.ContainerRightSideToolBar.ContainerRoot2.Click("51;61");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar.ContainerHeaderTabItemLayout' at 211;32.", repo.VnaNG.TabSelectorToolBar.ContainerHeaderTabItemLayoutInfo, new RecordItemIndex(1));
            repo.VnaNG.TabSelectorToolBar.ContainerHeaderTabItemLayout.Click("211;32");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar.TextSelectedChannel' at 56;13.", repo.VnaNG.TabSelectorToolBar.TextSelectedChannelInfo, new RecordItemIndex(2));
            repo.VnaNG.TabSelectorToolBar.TextSelectedChannel.Click("56;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType2' at 7;17.", repo.VnaNG.ContainerContentColumn.TextMeasureType2Info, new RecordItemIndex(3));
            repo.VnaNG.ContainerContentColumn.TextMeasureType2.Click("7;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot17' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(5));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot17, BackgroundItem_Screenshot17_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType' at 26;11.", repo.VnaNG.ContainerContentColumn.TextMeasureTypeInfo, new RecordItemIndex(6));
            repo.VnaNG.ContainerContentColumn.TextMeasureType.Click("26;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot18' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(7));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot18, BackgroundItem_Screenshot18_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType3' at 23;13.", repo.VnaNG.ContainerContentColumn.TextMeasureType3Info, new RecordItemIndex(8));
            repo.VnaNG.ContainerContentColumn.TextMeasureType3.Click("23;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot19' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(9));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot19, BackgroundItem_Screenshot19_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter4' at 25;15.", repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter4Info, new RecordItemIndex(10));
            repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter4.Click("25;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter3' at 24;20.", repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter3Info, new RecordItemIndex(11));
            repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter3.Click("24;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot16' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(12));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot16, BackgroundItem_Screenshot16_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar.TextSelectedChannel' at 37;11.", repo.VnaNG.TabSelectorToolBar.TextSelectedChannelInfo, new RecordItemIndex(13));
            repo.VnaNG.TabSelectorToolBar.TextSelectedChannel.Click("37;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType' at 21;9.", repo.VnaNG.ContainerContentColumn.TextMeasureTypeInfo, new RecordItemIndex(14));
            repo.VnaNG.ContainerContentColumn.TextMeasureType.Click("21;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot15' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(15));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot15, BackgroundItem_Screenshot15_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType1' at 23;7.", repo.VnaNG.ContainerContentColumn.TextMeasureType1Info, new RecordItemIndex(16));
            repo.VnaNG.ContainerContentColumn.TextMeasureType1.Click("23;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot14' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(17));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot14, BackgroundItem_Screenshot14_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType2' at 21;7.", repo.VnaNG.ContainerContentColumn.TextMeasureType2Info, new RecordItemIndex(18));
            repo.VnaNG.ContainerContentColumn.TextMeasureType2.Click("21;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(19));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot13' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(20));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot13, BackgroundItem_Screenshot13_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter6' at 9;19.", repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter6Info, new RecordItemIndex(21));
            repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter6.Click("9;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter2' at 10;17.", repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter2Info, new RecordItemIndex(22));
            repo.VnaNG.ContainerContentColumn.ContainerDelegateChannelSetter2.Click("10;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(23));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot12' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(24));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot12, BackgroundItem_Screenshot12_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar.TextSelectedChannel' at 32;6.", repo.VnaNG.TabSelectorToolBar.TextSelectedChannelInfo, new RecordItemIndex(25));
            repo.VnaNG.TabSelectorToolBar.TextSelectedChannel.Click("32;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType1' at 25;19.", repo.VnaNG.ContainerContentColumn.TextMeasureType1Info, new RecordItemIndex(26));
            repo.VnaNG.ContainerContentColumn.TextMeasureType1.Click("25;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot11' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(27));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot11, BackgroundItem_Screenshot11_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType' at 8;21.", repo.VnaNG.ContainerContentColumn.TextMeasureTypeInfo, new RecordItemIndex(28));
            repo.VnaNG.ContainerContentColumn.TextMeasureType.Click("8;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot10' with region {X=0,Y=0,Width=679,Height=497}) on item 'VnaNG.BackgroundItem'.", repo.VnaNG.BackgroundItemInfo, new RecordItemIndex(29));
            Validate.CompareImage(repo.VnaNG.BackgroundItemInfo, BackgroundItem_Screenshot10, BackgroundItem_Screenshot10_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerContentColumn.TextMeasureType3' at 6;20.", repo.VnaNG.ContainerContentColumn.TextMeasureType3Info, new RecordItemIndex(30));
            repo.VnaNG.ContainerContentColumn.TextMeasureType3.Click("6;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG.QQuickOverlay'.", repo.VnaNG.QQuickOverlayInfo, new RecordItemIndex(31));
            Validate.CompareImage(repo.VnaNG.QQuickOverlayInfo, QQuickOverlay_Screenshot1, QQuickOverlay_Screenshot1_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot17
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot17(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot17_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot18
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot18(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot18_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot19
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot19(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot19_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot16
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot16(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot16_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot15
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot15(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot15_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot14
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot14(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot14_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot13
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot13(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot13_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot12
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot12(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot12_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot11
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot11(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot11_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage BackgroundItem_Screenshot10
        { get { return repo.VnaNG.BackgroundItemInfo.GetScreenshot10(new Rectangle(0, 0, 679, 497)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions BackgroundItem_Screenshot10_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,679,497;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage QQuickOverlay_Screenshot1
        { get { return repo.VnaNG.QQuickOverlayInfo.GetScreenshot1(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions QQuickOverlay_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,582,80,118"); } }

#endregion
    }
#pragma warning restore 0436
}