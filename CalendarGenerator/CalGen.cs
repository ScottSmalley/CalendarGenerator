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
             * easier get/set later.
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
             * Add the textboxes 
             * into a collection for 
             * easier get/set.
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

        /// <summary>
        /// Enforces a 30 character limit
        /// on each line of the calendar
        /// date cells. Enforces an 8 line 
        /// limit as well. These are to 
        /// prevent any cut-off when the
        /// inputs are sent to build the 
        /// calendar.
        /// </summary>
        /// <param name="textbox"></param>
        private void CheckLineLengthAndCount(RichTextBox textbox)
        {
            //if (textbox.Lines.Count() > 0 && textbox.Lines.Last().Length > 30)
            //{
            //    string[] words = textbox.Lines.Last().Split(' ');
            //    Debug.Write($"{textbox.Lines[textbox.Lines.Count()-1]}");
            //    textbox.Lines[textbox.Lines.Length-1] = ("haha");
            //    textbox.AppendText(Environment.NewLine + words[words.Length-1]);
            //}
            if (textbox.Lines.Count() > 8)
            {
                MessageBox.Show("Calendar will display a maximum of 8 lines.");
            }
        }

        /// <summary>
        /// Resets the month / year, dates, 
        /// and calendar cells to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Aggregates the calendar data
        /// and creates the calendar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createBtn_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>();
            foreach (Label lbl in labels)
            {
                dates.Add(lbl.Text);
            }

            List<string> cellData = new List<string>();
            foreach(RichTextBox box in textboxes)
            {
                cellData.Add(box.Text);
            }
            GenerateCalendar.Run(monthYearLbl.Text, dates, cellData);
        }

        /// <summary>
        /// Used to select what month to use for 
        /// the calendar, and generate the dates
        /// above each calendar cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar mc = (MonthCalendar)sender;
            DateTime date = mc.SelectionRange.Start;
            GenerateCalendarDates(date);
        }

        /// <summary>
        /// Computes and prints the 
        /// correct month, year, and
        /// calendar cell dates.
        /// </summary>
        /// <param name="data"></param>
        private void GenerateCalendarDates(DateTime data)
        {
            monthYearLbl.Text = $"{getMonthName(data.Month)} {data.Year}";

            /*
             * If the user clicked on a date that isn't the first of the month,
             * find the first of the month. Then we want to see how many days into
             * the week the first of the month is. This way we can easily fill 
             * those dates in from the prior month (example: the first of the month
             * is on a Friday--we should fill up Mon-Thurs with the prior month's dates.
             */
            int deficit = data.Day > 1
                ? FindFirstWeekDateDeficit(data.AddDays(1 - data.Day))
                : FindFirstWeekDateDeficit(data);
            
            int dateCtr = 1;
            int lastMonthDays = 0;
            //If there are days we need generate from last month for the first week.
            if (deficit < 0)
            {
                lastMonthDays = DateTime.DaysInMonth(data.Year, data.AddMonths(-1).Month);
                
                //"deficit" increment is to account for the lastMonthDays 
                //number--it counts as a date to use too. So we need to offset the deficit.
                deficit++;
                dateCtr = lastMonthDays + deficit;
            }
            else
            {
                /*
                 * If a positive deficit (meaning we skip the 1st of the 
                 * month because it's a Sunday) we move the counter forward
                 */
                dateCtr += deficit;
            }
            
            //Write out the calendar dates on the date cells.
            for (int cellNumberIdx = 0; cellNumberIdx < labels.Count(); cellNumberIdx++)
            {
                //Skipping Sundays, move the date forward.
                if (cellNumberIdx > 0 && cellNumberIdx % 6 == 0)
                {
                    dateCtr++;
                }

                labels[cellNumberIdx].Text = $"{dateCtr++}";

                /* Counter Reset
                 * Conditions to reset the counter:
                 * 1) When we're done printing the 1st week 
                 * of the month where there are days from 
                 * the previous month.
                 * OR
                 * 2) When we're done printing this month's 
                 * days and still have days to print for 
                 * next month.
                 */
                if ((lastMonthDays > 0 && dateCtr > lastMonthDays) 
                    || (cellNumberIdx > 23 && dateCtr > DateTime.DaysInMonth(data.Year, data.Month)))
                {
                    /*
                     * Disabling this variable so it doesn't 
                     * trigger after we need it to (meaning 
                     * we're done printing the previous month
                     * dates).
                     */
                    lastMonthDays = 0; 

                    dateCtr = 1;
                }

            }
        }

        /// <summary>
        /// Calculates how many calendar cells we need
        /// to accomodate where the 1st of the current
        /// month resides in a week. If the 1st is on
        /// a Saturday, we need the first 5 cells to 
        /// contain dates from the prior month.
        /// 5 not 6 because the stakeholder does not
        /// use Sunday, because they are not operating 
        /// on Sundays. 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private int FindFirstWeekDateDeficit(DateTime data)
        {
            int deficit = 1;
            switch (data.DayOfWeek.ToString())
            {
                case "Monday":
                    deficit = 0;
                    break;
                case "Tuesday":
                    deficit = -1;
                    break;
                case "Wednesday":
                    deficit = -2;
                    break;
                case "Thursday":
                    deficit = -3;
                    break;
                case "Friday":
                    deficit = -4;
                    break;
                case "Saturday":
                    deficit = -5;
                    break;
            }
            return deficit;
        }

        /// <summary>
        /// Finds and returns the name of the
        /// month based on the month number.
        /// </summary>
        /// <param name="monthNum"></param>
        /// <returns></returns>
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
