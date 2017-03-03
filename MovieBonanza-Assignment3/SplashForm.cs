// App Name : Splash Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : March 3, 2017
// App Description : This is Splash form for open selection form


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_Assignment3
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is handler for Form load event of Timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //It will enabled the Timer
            this.Enabled = false;

            //It will hide the SplashForm 
            this.Hide();

            //Display the Next SelectionForm
            Program.mySelectForm.Show();
        }
    }
}
