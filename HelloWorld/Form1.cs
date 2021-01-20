using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            lbDisplayInfo.Text = "Hello World!";
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for clicking my button");
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lbDisplayInfo.Text = "Goodbye World!";
        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            picMack.Visible = true;
        }
        /*
         * This method hides our picture when comebody clicks the button
         */
        private void btnHidePic_Click(object sender, EventArgs e)
        {
            //Hides the pic
            picMack.Visible = false;
        }

        private void picMack_Click(object sender, EventArgs e)
        {
            picMack.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
