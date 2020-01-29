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
    ///The AddClose_Cannel recording.
    /// </summary>
    [TestModule("cf952693-b2f7-4fc4-a2f4-69960435fdad", ModuleType.Recording, 1)]
    public partial class AddClose_Cannel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static AddClose_Cannel instance = new AddClose_Cannel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddClose_Cannel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddClose_Cannel Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.PictureIconToolBarButton' at 32;39.", repo.VnaNG.PictureIconToolBarButtonInfo, new RecordItemIndex(0));
            repo.VnaNG.PictureIconToolBarButton.Click("32;39");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar1.TextTextTabItemToolBar' at 150;15.", repo.VnaNG.TabSelectorToolBar1.TextTextTabItemToolBarInfo, new RecordItemIndex(1));
            repo.VnaNG.TabSelectorToolBar1.TextTextTabItemToolBar.Click("150;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar1.TextTextCenter' at 48;12.", repo.VnaNG.TabSelectorToolBar1.TextTextCenterInfo, new RecordItemIndex(2));
            repo.VnaNG.TabSelectorToolBar1.TextTextCenter.Click("48;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(3));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(4));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot3, VnaNG_Screenshot3_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TabSelectorToolBar1.TextTextCenter5' at 42;5.", repo.VnaNG.TabSelectorToolBar1.TextTextCenter5Info, new RecordItemIndex(5));
            repo.VnaNG.TabSelectorToolBar1.TextTextCenter5.Click("42;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(6));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot4' with region {X=0,Y=0,Width=1000,Height=700}) on item 'VnaNG'.", repo.VnaNG.SelfInfo, new RecordItemIndex(7));
            Validate.CompareImage(repo.VnaNG.SelfInfo, VnaNG_Screenshot4, VnaNG_Screenshot4_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot3
        { get { return repo.VnaNG.SelfInfo.GetScreenshot3(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot3_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;0,306,64,350"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage VnaNG_Screenshot4
        { get { return repo.VnaNG.SelfInfo.GetScreenshot4(new Rectangle(0, 0, 1000, 700)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions VnaNG_Screenshot4_Options
        { get { return Imaging.FindOptions.Parse("0.999;None;0,0,1000,700;True;10000000;0ms;1,600,67,62"); } }

#endregion
    }
#pragma warning restore 0436
}
