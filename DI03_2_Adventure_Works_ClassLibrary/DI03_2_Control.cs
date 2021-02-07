using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI03_2_Adventure_Works_ClassLibrary
{
    public partial class DI03_2_Control : UserControl
    {
        public DI03_2_Control()
        {
            InitializeComponent();
            // tooltip shown on mantain mouse hover productImagePictureBox
            instructionsToolTip.SetToolTip(productImagePictureBox, "Click to display another product");
        }
        // cursor change to hand on enter productImagePictureBox
        private void productImagePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        // cursor change to default on leave productImagePictureBox
        private void productImagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void productImagePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
