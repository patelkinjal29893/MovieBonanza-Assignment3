using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_Assignment3
{
    public static class Program
    {
        //public static form objects
        public static SplashForm mySplashForm;  
        public static SelectForm mySelectForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize SplashForm and SelectForm
            Program.mySplashForm = new SplashForm();
            Program.mySelectForm = new SelectForm();

            Application.Run(Program.mySplashForm);
        }
    }
}
