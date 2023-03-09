using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class fruitForm : Form
    {
        public fruitForm()
        {
            InitializeComponent();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            string infoDisplay = ""; // Store the information to show

            // Get the selection and determine what info to show
            switch (fruitsListBox.SelectedItem)
            {
                case "Apple":
                    if (pictureYesRadioButton.Checked)
                    {
                        fruitPictureBox.Image = fruitPictureList.Images[0];
                    }

                    if (colorCheckBox.Checked)
                    {
                        infoDisplay += "Color: Red" + "\r\n"; 
                    }

                    if (typeCheckBox.Checked)
                    {
                        infoDisplay += "Type: Apples" + "\r\n";
                    }
                    break;
                case "Banana":
                    if (pictureYesRadioButton.Checked)
                    {
                        fruitPictureBox.Image = fruitPictureList.Images[1];
                    }

                    if (colorCheckBox.Checked)
                    {
                        infoDisplay += "Color: Yellow" + "\r\n";
                    }

                    if (typeCheckBox.Checked)
                    {
                        infoDisplay += "Type: Tropical" + "\r\n";
                    }
                    break;
                case "Grapes":
                    if (pictureYesRadioButton.Checked)
                    {
                        fruitPictureBox.Image = fruitPictureList.Images[2];
                    }

                    if (colorCheckBox.Checked)
                    {
                        infoDisplay += "Color: Purple" + "\r\n";
                    }

                    if (typeCheckBox.Checked)
                    {
                        infoDisplay += "Type: Berry" + "\r\n";
                    }
                    break;
                case "Orange":
                    if (pictureYesRadioButton.Checked)
                    {
                        fruitPictureBox.Image = fruitPictureList.Images[3];
                    }

                    if (colorCheckBox.Checked)
                    {
                        infoDisplay += "Color: Orange" + "\r\n";
                    }

                    if (typeCheckBox.Checked)
                    {
                        infoDisplay += "Type: Citrus" + "\r\n";
                    }
                    break;
                case "Strawberry":
                    if (pictureYesRadioButton.Checked)
                    {
                        fruitPictureBox.Image = fruitPictureList.Images[4];
                    }

                    if (colorCheckBox.Checked)
                    {
                        infoDisplay += "Color: Red" + "\r\n";
                    }

                    if (typeCheckBox.Checked)
                    {
                        infoDisplay += "Type: Berry" + "\r\n";
                    }
                    break;
            }

            // Show information
            infoOutputLabel.Text = infoDisplay;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the selection selection
            fruitPictureBox.Image = null;
            infoOutputLabel.Text = "";
            fruitsListBox.SelectedItem = null;
            pictureYesRadioButton.Checked = false;
            pictureNoRadioButton.Checked = true;
            colorCheckBox.Checked = false;
            typeCheckBox.Checked = false;
        }
    }
}
