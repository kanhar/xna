﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Main_XNA_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmMain myMainForm = new FrmMain();
            Application.Run(myMainForm);
        }
    }
}