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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_Assignment3
{
    public partial class OrderForm : Form
    {
        public Form previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
