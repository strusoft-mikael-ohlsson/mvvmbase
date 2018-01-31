﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmBase
{
    using MvvmBase.Helpers;
    using MvvmBase.ViewModels;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Application_Startup(object sender, StartupEventArgs args)
        {
            var mv=new TestVm();
            mv.Show("Hello");
        }
    }
}
