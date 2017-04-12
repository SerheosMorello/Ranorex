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

namespace web_testing_examples
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The F_Check_value recording.
    /// </summary>
    [TestModule("0f357fa2-f0a0-4342-8e07-1bba698ab656", ModuleType.Recording, 1)]
    public partial class F_Check_value : ITestModule
    {
        /// <summary>
        /// Holds an instance of the web_testing_examplesRepository repository.
        /// </summary>
        public static web_testing_examplesRepository repo = web_testing_examplesRepository.Instance;

        static F_Check_value instance = new F_Check_value();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public F_Check_value()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static F_Check_value Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'RanorexTestPage.AjaxOut'.", repo.RanorexTestPage.AjaxOutInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.RanorexTestPage.AjaxOutInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Array\n(\n    [value1] => 1\n    [value2] => 2\n    [color2] => green\n)\n') on item 'RanorexTestPage.ArrayValue1Eq1Value2E'.", repo.RanorexTestPage.ArrayValue1Eq1Value2EInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.RanorexTestPage.ArrayValue1Eq1Value2EInfo, "InnerText", "Array\n(\n    [value1] => 1\n    [value2] => 2\n    [color2] => green\n)\n");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}