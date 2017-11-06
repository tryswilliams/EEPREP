using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class QuestionForm : Form
    {
        private int count = 0;
        private IDbDataProvider providerTwo;
        private string choice;
        public QuestionForm()
        {
            InitializeComponent();
           
            
            CategoryForm categoryChoice = new CategoryForm();
            //choice = categoryChoice.PickOption();

        }
        /**
         * Purpose: Clears all the boxes on the question form
         */
        private void CLearBoxes()
        {
            numTextBox.Clear();
            QuestionTextBox.Clear();
            questionPictureBox.InitialImage = null;
            opALabel.Text = "";
            opBLabel.Text = "";
            opCLabel.Text = "";
            opDLabel.Text = "";
            opELabel.Text = "";
        }

        /**
         * Purpose: Shows the question and its related information on 
         * the question form.
         */
        private void ShowQuestion()
        {
            //while (categoryChoice == questionList.Topic );
            //QuestionTextBox.Text = 

            

        }
        // TO DO : on the last question the next button displays "Submit"

        private void nextButton_Click(object sender, EventArgs e)
        {
           CLearBoxes();
           ShowQuestion();
        }
    }
}
