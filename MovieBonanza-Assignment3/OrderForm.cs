// App Name : Order Form
// Author's Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : February 19, 2017
// App Description : This is Order form to display all Order details like Movie title, cost with 
//                   Total amount, Sales Taxes, Additional Charges for DVD's and etc.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_Assignment3
{
    public partial class OrderForm : Form
    {
        public Form previousForm;

        private double _grandTotal = 0.00;

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the handler for Cancel Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the handler for Cancel MenuItem Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the handler for Print MenuItem Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Movie page is about to Printing...");
        }

        /// <summary>
        /// This is the handler for Back Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            //It will hide the OrderForm
            this.Hide();

            //Load the previous SelectForm
            previousForm.Show();
        }

        /// <summary>
        /// This is the handler for Stream Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            //This will Add grand Total to the Order Class
            Program.order.grandTotal = _grandTotal;

            //This will Hide the OrderForm
            this.Hide();

            //Create an Object of StreamForm
            StreamForm streamForm = new StreamForm();

            //It will shows StreamForm
            streamForm.Show();
        }

        /// <summary>
        /// This is Handler for Stream MenuItem Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamButton_Click(sender, e);
        }

        /// <summary>
        /// This is handler for About MenuItem Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Created Instance of AboutBox
            AboutBox aboutBox = new AboutBox();
            //Display the AboutBox in new Window
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// This is handler for Calculate Movie Cost
        /// </summary>
        private void CalculateCost()
        {
            //Private Variables(Double to Store Value into two Decimal Values)
            double _movieCost = Convert.ToDouble(CostTextBox.Text);
            double _additionalCharge = 0.00;
            double _subTotal;
            double _salesTax;

            if(OrderDVDCheckBox.Checked == true)
            {
                _additionalCharge = _additionalCharge + 10.00;
                AdditionalChargesTextBox.Text = String.Format("{0:0.00}", _additionalCharge);
            }
            else if(OrderDVDCheckBox.Checked == true)
            {
                if(OrderDVDCheckBox.Checked == false)
                {
                    _additionalCharge -= 10.00;
                }
            }

            //Shows Sub Total Amount
            _subTotal = _movieCost + _additionalCharge;
            SubTotalTextBox.Text = _subTotal.ToString();

            //Shows Sales Tax
            _salesTax = Math.Round(_subTotal * 0.13, 2);
            SalesTaxTextBox.Text = _salesTax.ToString();

            //Shows Grand Total
            _grandTotal = _subTotal + _salesTax;
            GrandTotalTextBox.Text = _grandTotal.ToString();
        }

        /// <summary>
        /// This is OrderForm Page Load handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            //Loads all Data into OrderForm from previousForm
            TitleTextBox.Text = Program.movie.movieTitle;
            CategoryTextBox.Text = Program.movie.movieCategory;
            CostTextBox.Text = Program.movie.movieCost;

            //Display the Large Graphics Image in Picture Box
            Environment.CurrentDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAsse‌​mbly().Location), "../../Properties/");
            LargeGraphicsPictureBox.ImageLocation = Environment.CurrentDirectory + "/" + Program.movie.movieTitle + ".jpg";
            LargeGraphicsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //Call the Calculate Function into Load Event
            CalculateCost();
        }
        /// <summary>
        /// This is Checkbox Change event for making TextBox and Label Visible and Hide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(OrderDVDCheckBox.Checked == true)
            {
                //It will shows Additional Charges info into Label and TextBox when Checked
                AdditionalChargesLabel.Visible = true;
                AdditionalChargesTextBox.Visible = true;

                //Call Calculate Function for Add $10 into Total
                CalculateCost();
            }
            else
            {
                //It will hides Additional Charges info from Label and TextBox when Checked
                AdditionalChargesLabel.Visible = false;
                AdditionalChargesTextBox.Visible = false;

                //Call Calculate Function for subtract $10 from Total
                CalculateCost();
            }
        }
    }
}
