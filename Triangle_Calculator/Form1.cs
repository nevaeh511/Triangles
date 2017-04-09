using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Calculator
{
    public partial class Form1 : Form
    {
        decimal sideA = default(decimal);
        decimal sideB = default(decimal);
        decimal sideC = default(decimal);
        bool isValidSideA = false;
        bool isValidSideB = false;
        bool isValidSideC = false;
        const string MESSAGE = "Invalid Input!";
        Triangle triangle = default(Triangle);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Lbl_ErrorMessage_SideA.Hide();
            Lbl_ErrorMessage_SideB.Hide();
            Lbl_ErrorMessage_SideC.Hide();
            Lbl_OutputText.Hide();
        }        
        private void TxtBox_SideA_TextChanged(object sender, EventArgs e)
        {
            validateInput(TxtBox_SideA, ref isValidSideA, ref sideA);
            /* check if error message needs to be outputed
             */
            if (!isValidSideA && TxtBox_SideA.Text != "")
            {
                //output error message
                Lbl_ErrorMessage_SideA.Text = MESSAGE;
                Lbl_ErrorMessage_SideA.ForeColor = Color.Red;
                Lbl_ErrorMessage_SideA.Show();
                Lbl_OutputText.Hide();
            }
            else if (isValidSideA && isValidSideB && isValidSideC)
            {
                //get message from triangle
                Lbl_OutputText.Text = DetermineTriangle();
                //display the message
                Lbl_OutputText.Show();
                Lbl_ErrorMessage_SideA.Hide();
            }
            else
            {
                Lbl_ErrorMessage_SideA.Hide();
            }
        }
        private void TxtBox_SideB_TextChanged(object sender, EventArgs e)
        {
            validateInput(TxtBox_SideB, ref isValidSideB, ref sideB);
            /* check if error message needs to be outputed
              */
            if (!isValidSideB && TxtBox_SideB.Text != "")
            {
                //output error message
                Lbl_ErrorMessage_SideB.Text = MESSAGE;
                Lbl_ErrorMessage_SideB.ForeColor = Color.Red;
                Lbl_ErrorMessage_SideB.Show();
                Lbl_OutputText.Hide();
            }
            else if (isValidSideA && isValidSideB && isValidSideC)
            {
                //get message from triangle
                Lbl_OutputText.Text = DetermineTriangle();
                //display the message
                Lbl_OutputText.Show();
                Lbl_ErrorMessage_SideB.Hide();
            }
            else
            {
                Lbl_ErrorMessage_SideB.Hide();
            }
        }
        private void TxtBox_SideC_TextChanged(object sender, EventArgs e)
        {
            validateInput(TxtBox_SideC, ref isValidSideC, ref sideC);
            /* check if error message needs to be outputed
              */
            if (!isValidSideC && TxtBox_SideC.Text != "")
            {
                //output error message
                Lbl_ErrorMessage_SideC.Text = MESSAGE;
                Lbl_ErrorMessage_SideC.ForeColor = Color.Red;
                Lbl_ErrorMessage_SideC.Show();
                Lbl_OutputText.Hide();
            }
            else if (isValidSideA && isValidSideB && isValidSideC)
            {
                //get message from triangle
                Lbl_OutputText.Text = DetermineTriangle();
                //display the message
                Lbl_OutputText.Show();
                Lbl_ErrorMessage_SideC.Hide();
            }
            else
            {
                Lbl_ErrorMessage_SideC.Hide();
            }
        }

        private string DetermineTriangle()
        {
            string message = default(string);
            triangle = new Triangle(sideA, sideB, sideC);
            if (triangle.IsTriangle())
            {
                triangle = triangle.DetermineTriangle();
                message = triangle.DisplayMessage();
            }
            else
            {
                message = "These side lengths produce an invalid triangle!";
            }
            return message;
        }
        private void validateInput(Control txtBoxControl, ref bool isValidSide, ref decimal side)
        {
            //validate the value inputed if it's a number
            //on text changed, get the user input from the textbox
            string input = txtBoxControl.Text;
            //convert the input to a double
            if (decimal.TryParse(input, out side))
            {
                isValidSide = true;
            }
            else
            {
                isValidSide = false;
            }
        }

        
    }
}
