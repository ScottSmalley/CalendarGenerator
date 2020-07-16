using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarGenerator
{
    public partial class CalGenUI : Form
    {
        private List<Label> labels;
        private List<RichTextBox> textboxes;
        public CalGenUI()
        {
            InitializeComponent();
            DoStuff();
        }

        private void DoStuff()
        {
            labels = new List<Label>();
            textboxes = new List<RichTextBox>();
            /*
             * Throw all the Labels 
             * into a collection for 
             * easier resetting/value 
             * setting later.
             */
            labels.Add(cellOneOneLbl);
            labels.Add(cellOneTwoLbl);
            labels.Add(cellOneThreeLbl);
            labels.Add(cellOneFourLbl);
            labels.Add(cellOneFiveLbl);
            labels.Add(cellOneSixLbl);
            labels.Add(cellTwoOneLbl);
            labels.Add(cellTwoTwoLbl);
            labels.Add(cellTwoThreeLbl);
            labels.Add(cellTwoFourLbl);
            labels.Add(cellTwoFiveLbl);
            labels.Add(cellTwoSixLbl);
            labels.Add(cellThreeOneLbl);
            labels.Add(cellThreeTwoLbl);
            labels.Add(cellThreeThreeLbl);
            labels.Add(cellThreeFourLbl);
            labels.Add(cellThreeFiveLbl);
            labels.Add(cellThreeSixLbl);
            labels.Add(cellFourOneLbl);
            labels.Add(cellFourTwoLbl);
            labels.Add(cellFourThreeLbl);
            labels.Add(cellFourFourLbl);
            labels.Add(cellFourFiveLbl);
            labels.Add(cellFourSixLbl);
            labels.Add(cellFiveOneLbl);
            labels.Add(cellFiveTwoLbl);
            labels.Add(cellFiveThreeLbl);
            labels.Add(cellFiveFourLbl);
            labels.Add(cellFiveFiveLbl);
            labels.Add(cellFiveSixLbl);

            /*
             * Throw all the textboxes 
             * into a collection for 
             * easier resetting/value 
             * setting later.
             */
            textboxes.Add(cellOneOne);
            textboxes.Add(cellOneTwo);
            textboxes.Add(cellOneThree);
            textboxes.Add(cellOneFour);
            textboxes.Add(cellOneFive);
            textboxes.Add(cellOneSix);
            textboxes.Add(cellTwoOne);
            textboxes.Add(cellTwoTwo);
            textboxes.Add(cellTwoThree);
            textboxes.Add(cellTwoFour);
            textboxes.Add(cellTwoFive);
            textboxes.Add(cellTwoSix);
            textboxes.Add(cellThreeOne);
            textboxes.Add(cellThreeTwo);
            textboxes.Add(cellThreeThree);
            textboxes.Add(cellThreeFour);
            textboxes.Add(cellThreeFive);
            textboxes.Add(cellThreeSix);
            textboxes.Add(cellFourOne);
            textboxes.Add(cellFourTwo);
            textboxes.Add(cellFourThree);
            textboxes.Add(cellFourFour);
            textboxes.Add(cellFourFive);
            textboxes.Add(cellFourSix);
            textboxes.Add(cellFiveOne);
            textboxes.Add(cellFiveTwo);
            textboxes.Add(cellFiveThree);
            textboxes.Add(cellFiveFour);
            textboxes.Add(cellFiveFive);
            textboxes.Add(cellFiveSix);
        }

        /*
         * If user makes any changes, we want to make sure 
         * we're still within 31 characters per line and 8 rows.
         * 31 x 8 is the maximum amount of characters to fit each
         * calendar data cell.
         */
        //Row 1
        private void cellOneOne_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellOneTwo_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellOneThree_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellOneFour_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellOneFive_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellOneSix_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        //Row 2
        private void cellTwoOne_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellTwoTwo_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellTwoThree_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellTwoFour_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellTwoFive_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellTwoSix_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        //Row 3
        private void cellThreeOne_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellThreeTwo_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellThreeThree_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellThreeFour_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellThreeFive_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellThreeSix_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        //Row 4
        private void cellFourOne_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFourTwo_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFourThree_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFourFour_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFourFive_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFourSix_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        //Row 5
        private void cellFiveOne_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFiveTwo_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFiveThree_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFiveFour_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFiveSix_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void cellFiveFive_TextChanged(object sender, EventArgs e) => CheckLineLengthAndCount((RichTextBox)sender);

        private void CheckLineLengthAndCount(RichTextBox textbox)
        {
            if (textbox.Lines.Count() > 0 && textbox.Lines.Last().Length > 30)
            {
                textbox.AppendText(Environment.NewLine);
            }
            if (textbox.Lines.Count() > 8)
            {
                MessageBox.Show("Calendar will display a maximum of 8 lines.");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            monthYearLbl.Text = "Sample Calendar";
            for (int i = 0; i < labels.Count(); i++)
            {
                labels[i].Text = $"{i + 1}";
            }

            foreach(RichTextBox box in textboxes)
            {
                box.Text = "";
            }
        }

        private void datePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar mc = (MonthCalendar)sender;
            DateTime date = mc.SelectionRange.Start;
            monthYearLbl.Text = $"{getMonthName(date.Month)} {date.Year}";
        }

        private string getMonthName(int monthNum)
        {
            string month = "Invalid Month";
            switch (monthNum)
            {
                case 1:
                    month = "January";
                    break;

                case 2:
                    month = "February";
                    break;

                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;

                case 5:
                    month = "May";
                    break;

                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;

                case 8:
                    month = "August";
                    break;

                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;

                case 11:
                    month = "November";
                    break;

                case 12:
                    month = "December";
                    break;
            }
            return month;
        }
    }
}
