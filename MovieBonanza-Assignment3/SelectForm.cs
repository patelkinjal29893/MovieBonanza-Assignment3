// App Name : Select Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : February 18, 2017
// App Description : This is first Selection form to display all movie list with Cost and Categories like Drama, New Release, Comedy and etc.

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
    public partial class SelectForm : Form
    {
        public string[] movieDetail;

        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the handler for NextButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Insert Movie Title, Category and Cost into Movie Class
            Program.movie.movieTitle = movieDetail.GetValue(0).ToString();
            Program.movie.movieCategory = movieDetail.GetValue(1).ToString();
            Program.movie.movieCost = movieDetail.GetValue(2).ToString();

            //Create an object of OrderForm
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;

            //Hides this SelectForm
            this.Hide();

            //Shows OrderForm
            orderForm.Show();
        }

        /// <summary>
        /// This is handler for Set Different Movie Category 
        /// </summary>
        /// <returns>_categoryType</returns>
        public string getCategoryType()
        {
            string _categoryType = "";

            if (MovieNamesListBox.SelectedItem.ToString().Equals("Season of the Witch")
                || MovieNamesListBox.SelectedItem.ToString().Equals("I am Number Four"))
            {
                _categoryType = "Sci-Fi";
            }

            if (MovieNamesListBox.SelectedItem.ToString().Equals("The Green Hornet")
                || MovieNamesListBox.SelectedItem.ToString().Equals("Death Race 2")
                || MovieNamesListBox.SelectedItem.ToString().Equals("The Mechanic")
                || MovieNamesListBox.SelectedItem.ToString().Equals("Sanctum")
                || MovieNamesListBox.SelectedItem.ToString().Equals("The Other Woman")
                || MovieNamesListBox.SelectedItem.ToString().Equals("The Eagle"))
            {
                _categoryType = "Action";
            }

            if (MovieNamesListBox.SelectedItem.ToString().Equals("The Dilemma")
                || MovieNamesListBox.SelectedItem.ToString().Equals("No Strings Attached")
                || MovieNamesListBox.SelectedItem.ToString().Equals("Cedar Rapids")
                || MovieNamesListBox.SelectedItem.ToString().Equals("Just Go With It"))
            {
                _categoryType = "Comedy";
            }

            if (MovieNamesListBox.SelectedItem.ToString().Equals("Company Men")
                || MovieNamesListBox.SelectedItem.ToString().Equals("The Way Back")
                || MovieNamesListBox.SelectedItem.ToString().Equals("Waiting for Forever"))
            {
                _categoryType = "Drama";
            }

            if(MovieNamesListBox.SelectedItem.ToString().Equals("The Rite"))
            {
                _categoryType = "Horror";
            }

            if (MovieNamesListBox.SelectedItem.ToString().Equals("The Roommate"))
            {
                _categoryType = "Thriller";
            }

            if (MovieNamesListBox.SelectedItem.ToString().Equals("Gnomeo and Juliet"))
            {
                _categoryType = "Family";
            }

            if (MovieNamesListBox.SelectedItem.ToString().Equals("Footloose")
                || MovieNamesListBox.SelectedItem.ToString().Equals("Real Steal"))
            {
                _categoryType = "New Release";
            }

            return _categoryType;
        }

        public string getMovieCost()
        {
            double _movieCost = 0.00;

            if(getCategoryType().Equals("Comedy")
                || getCategoryType().Equals("Drama")
                || getCategoryType().Equals("Thriller"))
            {
                _movieCost = 1.99;
            }
            if (getCategoryType().Equals("Action")
                || getCategoryType().Equals("Sci-Fi")
                || getCategoryType().Equals("Horror"))
            {
                _movieCost = 2.99;
            }
            if (getCategoryType().Equals("Family"))
            {
                _movieCost = 0.99;
            }
            if (getCategoryType().Equals("New Releases"))
            {
                _movieCost = 4.99;
            }
            
            return _movieCost.ToString();
        }

        private void MovieNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable the NextButton
            NextButton.Enabled = true;
            
            //Instantiate the an Object
            Movie myMovie = new Movie();

            //Create a Variable to store movie selected
            string movieSelected = "";

            //Get all Selected Items and Store into an Object
            movieSelected = MovieNamesListBox.SelectedItem.ToString();

            //Create a String Variable to 
            string[] movie = { movieSelected, getCategoryType(), getMovieCost() };
            movieDetail = movie;

            TitleTextbox.Text = movieDetail.GetValue(0).ToString();
            CategoryTextBox.Text = movieDetail.GetValue(1).ToString();
            CostTextBox.Text = movieDetail.GetValue(2).ToString();

        }
    }
}
