﻿using Sparkle.Controls.Navigators;
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

namespace Klipper.Desktop.WPF.Views.Main
{
    /// <summary>
    /// Interaction logic for WorkTimeControl.xaml
    /// </summary>
    public partial class WorkTimeControl : UserControl
    {
        public WorkTimeControl()
        {
            InitializeComponent();
        }

        #region Properties

        public HamburgerNavigator Navigator { get { return this.TheNavigator; } }

        #endregion
    }
}
