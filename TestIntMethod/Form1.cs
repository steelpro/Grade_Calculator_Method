using System;
using System.Windows.Forms;

/*
 * Zachary Betters
 * CIS 209
 * Sept 26, 2016
 * Average Grade Calculator
 * This program will make sure the input is correct 
 * and calculate the average grade
 */

namespace TestIntMethod { 
    public partial class Grade : Form {

        public Grade() { InitializeComponent(); }
        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void btnCalc_Click(object sender, EventArgs e) {

            //if the method isInputValid returns true
            if (isInputValid()) {

                double exam1 = double.Parse(tbxExam1.Text);
                double exam2 = double.Parse(tbxExam2.Text);

                //calculate average and display
                double average = (exam1 + exam2) / 2;
                tbxAver.Text = average.ToString();                
            }
        }

        private bool isInputValid() {

            double exam1, exam2;

            //if exam 1 input is not a number, display an error message 
            if (double.TryParse(tbxExam1.Text, out exam1)) {

                //if exam 1 input is not between 0 and 100, display an error message
                if (exam1 >= 0 && exam1 <= 100) {

                    if (double.TryParse(tbxExam2.Text, out exam2)) {

                        if (exam2 >= 0 && exam2 <= 100) {
                            return true;
                        }
                        else {
                            MessageBox.Show("Exam 2 input must " +
                                "be between 0 and 100", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }    
                                            
                    }

                    else {
                        MessageBox.Show("Exam 2 input must " +
                            "be a number.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                else {
                    MessageBox.Show("Exam 1 input must " +
                        "be between 0 and 100.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else {
                MessageBox.Show("Exam 1 input must " + 
                    "be a number.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}