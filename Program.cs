// Copyright © 2019 Henning Hoppe
// This work is free.You can redistribute it and/or modify it under the
// terms of the Do What The Fuck You Want To Public License, Version 2,
// as published by Sam Hocevar.See the COPYING file or http://www.wtfpl.net/
// for more details.

namespace PdfMerger
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var mainform = new MainForm())
            {
                Application.Run(mainform);
            }
        }
    }
}
