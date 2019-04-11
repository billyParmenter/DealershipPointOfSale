/*
 * FILE          : Program.cs
 * PROJECT       : Assignment 4 RD - PROG2110
 * PROGRAMMER    : Billy Parmenter
 * FIRST VERSION : November 30, 2018
 * DESCRIPTION   : Main entry point for the application
 * 
 */

using System;
using System.Windows.Forms;

namespace RD_A4
{
    static class Program
    {

        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
