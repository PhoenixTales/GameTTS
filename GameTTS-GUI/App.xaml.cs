﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GameTTS_GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            //remove unfinshed (or finished) downloads
            try
            {
                if (Directory.Exists(Config.TempPath))
                {
                    var files = Directory.GetFiles(Config.TempPath);
                    foreach (var file in files)
                        File.Delete(file);
                    Directory.Delete(Config.TempPath);
                }
            }
            catch { }

            base.OnExit(e);
        }
    }
}
