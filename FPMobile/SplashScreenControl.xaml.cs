﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FPMobile
{
    public partial class SplashScreenControl : UserControl
    {
        public SplashScreenControl()
        {
            InitializeComponent();
            this.progressBar.IsIndeterminate = true;
        }
    }
}
