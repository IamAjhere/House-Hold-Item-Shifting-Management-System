﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Shift.admin;
using e_Shift.customer;

namespace e_Shift
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new adminDashboard());
           //Application.Run(new userDashboard());
            Application.Run(new loginMenu());
        }
    }
}
