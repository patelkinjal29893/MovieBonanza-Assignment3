// App Name : Stream Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : February 21, 2017
// App Description : This is final form to display Thank you Message with Order Price and Movie selected.


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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is Ok Button Click Event for Exit From Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        /// <summary>
        /// Handler for Load Stream Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamForm_Load(object sender, EventArgs e)
        {
            //It takes Total and MovieName from classes
            double _grandTotal = Program.order.grandTotal;
            string movieSelected = Program.movie.movieTitle;

            //Shows Movie Cost and Name in appropriate Formats
            ChargeLabel.Text = String.Format("Your Credit Card will be Charged ${0:0.00} ", _grandTotal);
            MovieSelectedLabel.Text = movieSelected + " will begin Streaming Shortly";
        }
    }
}
