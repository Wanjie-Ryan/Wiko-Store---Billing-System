using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiko_Store.UI
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // get the transactionType value from the formuserdashboard
        }
    }
}
