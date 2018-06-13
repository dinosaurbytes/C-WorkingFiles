using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenOrEgg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //User selects chicken.
        private void radChicken_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.ImageLocation = "../../img/chicken.jpg"; //display Chicken
        }

        private void radEgg_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.ImageLocation = "../../img/egg.jpg";
        }
    }
}
