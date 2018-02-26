﻿using AutumnBox.GUI.UI.Fp;
using AutumnBox.OpenFramework.Extension;
using AutumnBox.OpenFramework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutumnBox.GUI.UI.CstPanels
{
    /// <summary>
    /// ExtensionRuningPanel.xaml 的交互逻辑
    /// </summary>
    public partial class ExtensionRuningPanel : FastPanelChild
    {
        public override bool NeedShowBtnClose => false;
        public ExtensionRuningPanel(ExtensionRuntime extensionRuntime)
        {
            InitializeComponent();
            TBMsg.Text = $"{extensionRuntime.InnerExtension.Name} 正在运行....";
            BtnStop.Click += (s, e) =>
            {
                var stopResult = extensionRuntime.Stop();
                if (stopResult == true)
                {
                    Finish();
                }
                else
                {
                    TBMsg.Text = $"{extensionRuntime.InnerExtension.Name} 无法被停止";
                }
            };
        }
    }
}
