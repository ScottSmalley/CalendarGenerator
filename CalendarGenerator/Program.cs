/*
 * Group Therapy Calendar PDF Generator
 * Stakeholder: Changes Counseling
 * Developer: Scott Smalley
 * scottsmalley90@gmail.com
 * scottsmalley.net
 */
using System;
using System.Windows.Forms;

namespace CalendarGenerator
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
            Application.Run(new CalGenUI());
        }
    }
}
