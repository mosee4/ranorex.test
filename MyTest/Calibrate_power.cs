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
    ///The Calibrate_power recording.
    /// </summary>
    [TestModule("ec5125c0-8143-4085-8522-6edd8889740f", ModuleType.Recording, 1)]
    public partial class Calibrate_power : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Calibrate_power instance = new Calibrate_power();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Calibrate_power()
        {
            NewVariable = "-61;-255";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Calibrate_power Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewVariable;

        /// <summary>
        /// Gets or sets the value of variable NewVariable.
        /// </summary>
        [TestVariable("87170283-dcb1-45a2-94fe-181e979fbc4f")]
        public string NewVariable
        {
            get { return _NewVariable; }
            set { _NewVariable = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 958;355.", repo.VnaNG.SelfInfo, new RecordItemIndex(0));
            repo.VnaNG.Self.Click("958;355");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 805;205.", repo.VnaNG.SelfInfo, new RecordItemIndex(1));
            repo.VnaNG.Self.Click("805;205");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 879;201.", repo.VnaNG.SelfInfo, new RecordItemIndex(2));
            repo.VnaNG.Self.Click("879;201");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(3));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot15' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(4));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot15, VnaNG_Screenshot15_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 886;251.", repo.VnaNG.SelfInfo, new RecordItemIndex(5));
            repo.VnaNG.Self.Click("886;251");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot16' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(6));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot16, VnaNG_Screenshot16_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 958;408.", repo.VnaNG.SelfInfo, new RecordItemIndex(7));
            repo.VnaNG.Self.Click("958;408");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 972;371.", repo.VnaNG.SelfInfo, new RecordItemIndex(8));
            repo.VnaNG.Self.Click("972;371");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 894;206.", repo.VnaNG.SelfInfo, new RecordItemIndex(9));
            repo.VnaNG.Self.Click("894;206");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot17' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(11));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot17, VnaNG_Screenshot17_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 884;253.", repo.VnaNG.SelfInfo, new RecordItemIndex(12));
            repo.VnaNG.Self.Click("884;253");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'MyTest_2_f09d85a1_rxlog1' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(13));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_MyTest_2_f09d85a1_rxlog1, VnaNG_MyTest_2_f09d85a1_rxlog1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 961;405.", repo.VnaNG.SelfInfo, new RecordItemIndex(14));
            repo.VnaNG.Self.Click("961;405");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 955;446.", repo.VnaNG.SelfInfo, new RecordItemIndex(15));
            repo.VnaNG.Self.Click("955;446");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 892;210.", repo.VnaNG.SelfInfo, new RecordItemIndex(16));
            repo.VnaNG.Self.Click("892;210");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(17));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot18' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(18));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot18, VnaNG_Screenshot18_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 902;248.", repo.VnaNG.SelfInfo, new RecordItemIndex(19));
            repo.VnaNG.Self.Click("902;248");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'MyTest_2_92cc85a1_rxlog1' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(20));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_MyTest_2_92cc85a1_rxlog1, VnaNG_MyTest_2_92cc85a1_rxlog1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 970;447.", repo.VnaNG.SelfInfo, new RecordItemIndex(21));
            repo.VnaNG.Self.Click("970;447");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 959;480.", repo.VnaNG.SelfInfo, new RecordItemIndex(22));
            repo.VnaNG.Self.Click("959;480");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 833;212.", repo.VnaNG.SelfInfo, new RecordItemIndex(23));
            repo.VnaNG.Self.Click("833;212");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(24));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot19' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(25));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot19, VnaNG_Screenshot19_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG' at 892;250.", repo.VnaNG.SelfInfo, new RecordItemIndex(26));
            repo.VnaNG.Self.Click("892;250");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot20' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(27));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot20, VnaNG_Screenshot20_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot15
        { get { return repo.VnaNG.SelfInfo.GetScreenshot15(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot15_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;4,600,65,63"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot16
        { get { return repo.VnaNG.SelfInfo.GetScreenshot16(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot16_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;3,586,75,99"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot17
        { get { return repo.VnaNG.SelfInfo.GetScreenshot17(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot17_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,586,80,76"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_MyTest_2_f09d85a1_rxlog1
        { get { return repo.VnaNG.SelfInfo.GetMyTest_2_f09d85a1_rxlog1(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_MyTest_2_f09d85a1_rxlog1_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;3,586,75,99"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot18
        { get { return repo.VnaNG.SelfInfo.GetScreenshot18(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot18_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,586,63,80"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_MyTest_2_92cc85a1_rxlog1
        { get { return repo.VnaNG.SelfInfo.GetMyTest_2_92cc85a1_rxlog1(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_MyTest_2_92cc85a1_rxlog1_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;3,586,75,99"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot19
        { get { return repo.VnaNG.SelfInfo.GetScreenshot19(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot19_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;12,582,55,76"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot20
        { get { return repo.VnaNG.SelfInfo.GetScreenshot20(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot20_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;4,591,80,79"); } }

#endregion
    }
#pragma warning restore 0436
}
