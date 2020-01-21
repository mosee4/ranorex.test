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
    ///The Setting_VNA_Hide_VNA_collection recording.
    /// </summary>
    [TestModule("b498dc2e-97e4-4a8b-a93d-75e5291d1500", ModuleType.Recording, 1)]
    public partial class Setting_VNA_Hide_VNA_collection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestRepository repository.
        /// </summary>
        public static MyTestRepository repo = MyTestRepository.Instance;

        static Setting_VNA_Hide_VNA_collection instance = new Setting_VNA_Hide_VNA_collection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Setting_VNA_Hide_VNA_collection()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Setting_VNA_Hide_VNA_collection Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerRightSideToolBar.ContainerRoot3' at 49;9.", repo.VnaNG.ContainerRightSideToolBar.ContainerRoot3Info, new RecordItemIndex(0));
            repo.VnaNG.ContainerRightSideToolBar.ContainerRoot3.Click("49;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerRightSideToolBar.ContainerHeaderTabItemLayout1' at 212;26.", repo.VnaNG.ContainerRightSideToolBar.ContainerHeaderTabItemLayout1Info, new RecordItemIndex(1));
            repo.VnaNG.ContainerRightSideToolBar.ContainerHeaderTabItemLayout1.Click("212;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'VnaNG.ContainerRightSideToolBar.ElementScrollBar' at 3;87.", repo.VnaNG.ContainerRightSideToolBar.ElementScrollBarInfo, new RecordItemIndex(2));
            repo.VnaNG.ContainerRightSideToolBar.ElementScrollBar.MoveTo("3;87");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'VnaNG.ContainerRightSideToolBar.ElementScrollBar' at -1;407.", repo.VnaNG.ContainerRightSideToolBar.ElementScrollBarInfo, new RecordItemIndex(3));
            repo.VnaNG.ContainerRightSideToolBar.ElementScrollBar.MoveTo("-1;407");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerRightSideToolBar.ContainerActionButton4' at 18;26.", repo.VnaNG.ContainerRightSideToolBar.ContainerActionButton4Info, new RecordItemIndex(4));
            repo.VnaNG.ContainerRightSideToolBar.ContainerActionButton4.Click("18;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'VnaNG.TableTable.Vscrollbar' at 1;43.", repo.VnaNG.TableTable.VscrollbarInfo, new RecordItemIndex(5));
            repo.VnaNG.TableTable.Vscrollbar.MoveTo("1;43");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'VnaNG.TableTable.Vscrollbar' at 0;104.", repo.VnaNG.TableTable.VscrollbarInfo, new RecordItemIndex(6));
            repo.VnaNG.TableTable.Vscrollbar.MoveTo("0;104");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TableTable.Row3' at 12;35.", repo.VnaNG.TableTable.Row3Info, new RecordItemIndex(7));
            repo.VnaNG.TableTable.Row3.Click("12;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerActionButton2' at 93;26.", repo.VnaNG.ContainerActionButton2Info, new RecordItemIndex(8));
            repo.VnaNG.ContainerActionButton2.Click("93;26");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'VnaNG.TableTable.Vscrollbar' at 2;68.", repo.VnaNG.TableTable.VscrollbarInfo, new RecordItemIndex(10));
            repo.VnaNG.TableTable.Vscrollbar.MoveTo("2;68");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'VnaNG.TableTable.Vscrollbar' at -2;-9.", repo.VnaNG.TableTable.VscrollbarInfo, new RecordItemIndex(11));
            repo.VnaNG.TableTable.Vscrollbar.MoveTo("-2;-9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.TableTable.Row0' at 13;35.", repo.VnaNG.TableTable.Row0Info, new RecordItemIndex(12));
            repo.VnaNG.TableTable.Row0.Click("13;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerActionButton2' at 86;25.", repo.VnaNG.ContainerActionButton2Info, new RecordItemIndex(13));
            repo.VnaNG.ContainerActionButton2.Click("86;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'VnaNG.ContainerRightSideToolBar.ElementScrollBar' at 3;71.", repo.VnaNG.ContainerRightSideToolBar.ElementScrollBarInfo, new RecordItemIndex(14));
            repo.VnaNG.ContainerRightSideToolBar.ElementScrollBar.MoveTo("3;71");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'VnaNG.ContainerRightSideToolBar.ElementScrollBar' at 4;395.", repo.VnaNG.ContainerRightSideToolBar.ElementScrollBarInfo, new RecordItemIndex(15));
            repo.VnaNG.ContainerRightSideToolBar.ElementScrollBar.MoveTo("4;395");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VnaNG.ContainerRightSideToolBar.ContainerActionButton4' at 207;24.", repo.VnaNG.ContainerRightSideToolBar.ContainerActionButton4Info, new RecordItemIndex(16));
            repo.VnaNG.ContainerRightSideToolBar.ContainerActionButton4.Click("207;24");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}