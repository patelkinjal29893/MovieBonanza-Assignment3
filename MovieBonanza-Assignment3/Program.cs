﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_Assignment3
{
    static class Program
    {
        //Created an Object of Movie Class
        public static Movie movie = new Movie();
        public static Order order = new Order();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new SplashForm());
        }
    }
}
