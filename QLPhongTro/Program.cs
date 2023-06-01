﻿using QLPhongTro.View;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace QLPhongTro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("vi");

            // The following line provides localization for the application's user interface. 
            Thread.CurrentThread.CurrentUICulture = culture;

            // The following line provides localization for data formats. 
            Thread.CurrentThread.CurrentCulture = culture;

            // Set this culture as the default culture for all threads in this application. 
            // Note: The following properties are supported in the .NET Framework 4.5+
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
