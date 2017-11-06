using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class CategoryForm : Form
    {
        ArrayList Topics = new ArrayList();
        int quesChoice;
        bool click = false;
        private bool randomQuestions;
        private RadioButton[] catChoice;
        string questionCat;
        

        public CategoryForm()
        {
            InitializeComponent();
            catChoice = new RadioButton[] {algorithmsRB, discreteRB, infoManRB, progRB, softEngRB, systemsRB,
                        otherRB, randQuesOneRB, randQuesTwoRB  };
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            for (int num = 0; num < catChoice.Length; num++)
            {
                catChoice[num].Tag = num;
            }
           
            RadioButton rb = sender as RadioButton;
            click = true;

            if (rb != null)
            {
                quesChoice = (int) rb.Tag;
                if (rb.Checked)
                {
                    PickOption(quesChoice);
                }
            }

            else if (rb == null)
            {
                PickOption(8);
            }
            click = true;
            this.Hide();
            QuestionForm test = new QuestionForm();
            test.Show();
            

        }

        public void PickOption(int quesChoice)
        {
            switch (quesChoice)
            {
                case 0:
                    questionCat = "Agorithms and Complexity";
                    break;
                case 1:
                    questionCat = "Discrete Structures";
                    break;
                case 2:
                    questionCat = "Information Management";
                    break;
                case 3:
                    questionCat = "Programming";
                    break;
                case 4:
                    questionCat = "Software Engineering";
                    break;
                case 5:
                    questionCat = "Systems";
                    break;
                case 6:
                    questionCat = "Other";
                    break;
                case 7:
                    questionCat = "25 questions";
                    break;
                case 8:
                    questionCat = "40 questions";
                    break;
            }
        }

        public ArrayList GetTopics()
        {
            return Topics;
        }
        public int QNum()
        {
            int questions =0;
            return questions;

        }
        public bool done()
        {
            return click;
        }

        
    }
}
