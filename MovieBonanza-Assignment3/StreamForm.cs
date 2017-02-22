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

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
