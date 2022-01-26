using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Bookmark
{
    public partial class FormEditBookmark : Form
    {

        //Instantiates the variables needed
        private string tempText;
        private BookmarkInfoCard currentCard;

        bool nameValid = false;
        bool currentPageValid = false;
        bool numPageValid = false;
        bool startValid = false;
        bool endValid = false;

        //Initializes form
        public FormEditBookmark()
        {
            InitializeComponent();
        }

        //Sets card data to currentCard variable
        public BookmarkInfoCard Card
        {
            get => currentCard;
            set => currentCard = value;
        }

        private void FormEditBookmark_Load(object sender, EventArgs e)
        {
            buttonSaveBookmark.DialogResult = DialogResult.OK;

            buttonSaveBookmark.Enabled = true;

            if (currentCard != null)
            {
                textBox1.Text = currentCard.Name;
                textBox2.Text = currentCard.CurrentPage;
                textBox3.Text = currentCard.NumPages;
                textBox4.Text = currentCard.StartDate;
                textBox5.Text = currentCard.EndDate;
            }
        }

        //Exits form if button presses
        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Passes back info card information
        private void ButtonSaveBookmark_Click(object sender, EventArgs e)
        {
            if (currentCard == null)
            {
                return;
            }
            currentCard.Name = textBox1.Text;
            currentCard.CurrentPage = textBox2.Text;
            currentCard.NumPages = textBox3.Text;
            currentCard.StartDate = textBox4.Text;

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                currentCard.EndDate = "Not Finished";
            }
            else
            {
                currentCard.EndDate = textBox5.Text;
            }

        }

        //Calls validation whenever text is changed
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        //Validates all of the inputs, covered in more detail in the write-up
        private void Validation()
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                nameValid = false;
                LabelNameMessage.Text = "Book Name Cannot Be Empty";
            }
            else if ((textBox1.Text).Contains("|"))
            {
                nameValid = false;
                LabelNameMessage.Text = "'|' Is An Invalid Character";
            }
            else
            {
                nameValid = true;
                LabelNameMessage.Text = "";
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                currentPageValid = false;
                LabelCurrentPagMessage.Text = "Number of Pages Cannot Be Empty";
            }
            else if ((textBox2.Text).Contains("|"))
            {
                currentPageValid = false;
                LabelCurrentPagMessage.Text = "'|' Is An Invalid Character";
            }
            else
            {
                if (Int32.TryParse(textBox2.Text, out int j))
                {
                    currentPageValid = true;
                    LabelCurrentPagMessage.Text = "";
                }
                else
                {
                    currentPageValid = false;
                    LabelCurrentPagMessage.Text = "Only Numbers Can Be Entered";
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                numPageValid = false;
                LabelNumPagMessage.Text = "Number of Pages Cannot Be Empty";
            }
            else if ((textBox3.Text).Contains("|"))
            {
                numPageValid = false;
                LabelNumPagMessage.Text = "'|' Is An Invalid Character";
            }
            else
            {
                if (Int32.TryParse(textBox3.Text, out int j))
                {
                    numPageValid = true;
                    LabelNumPagMessage.Text = "";
                }
                else
                {
                    numPageValid = false;
                    LabelNumPagMessage.Text = "Only Numbers Can Be Entered";
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                startValid = false;
                LabelStartMessage.Text = "Number of Pages Cannot Be Empty";
            }
            else if ((textBox4.Text).Contains("|"))
            {
                startValid = false;
                LabelStartMessage.Text = "'|' Is An Invalid Character";
            }
            else
            {
                tempText = textBox4.Text;
                string[] tempArray = tempText.Split('/');

                Regex monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
                Regex yearCheck = new Regex(@"^[0-9]{2}$");

                if (!tempText.Contains('/'))
                {
                    startValid = false;
                    LabelStartMessage.Text = "Use Format dd/mm/yy";
                }
                else if (tempText.Length != 8)
                {
                    startValid = false;
                    LabelStartMessage.Text = "Use Format dd/mm/yy";
                }
                else
                {

                    if (tempArray[1] == "01" || tempArray[1] == "03" || tempArray[1] == "05" || tempArray[1] == "07" || tempArray[1] == "08" || tempArray[1] == "10" || tempArray[1] == "12")
                    {
                        Regex dayCheck1 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])$");

                        if (!dayCheck1.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            startValid = false;
                            LabelStartMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            startValid = true;
                            LabelStartMessage.Text = "";
                        }
                    }
                    else if (tempArray[1] == "04" || tempArray[1] == "06" || tempArray[1] == "09" || tempArray[1] == "11")
                    {
                        Regex dayCheck2 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0])$");

                        if (!dayCheck2.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            startValid = false;
                            LabelStartMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            startValid = true;
                            LabelStartMessage.Text = "";
                        }
                    }
                    else
                    {
                        Regex dayCheck3 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9])$");

                        if (!dayCheck3.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            startValid = false;
                            LabelStartMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            startValid = true;
                            LabelStartMessage.Text = "";
                        }
                    }
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                endValid = true;
                LabelEndMessage.Text = "";
            }
            else if ((textBox5.Text).Contains("|"))
            {
                endValid = false;
                LabelEndMessage.Text = "'|' Is An Invalid Character";
            }
            else if (textBox5.Text == "Not Finished")
            {
                endValid = true;
                LabelEndMessage.Text = "";
            }
            else
            {
                tempText = textBox5.Text;
                string[] tempArray = tempText.Split('/');
                Regex monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
                Regex yearCheck = new Regex(@"^[0-9]{2}$");

                if (!tempText.Contains('/'))
                {
                    endValid = false;
                    LabelEndMessage.Text = "Use Format dd/mm/yy";
                }
                else if (tempText.Length != 8)
                {
                    endValid = false;
                    LabelEndMessage.Text = "Use Format dd/mm/yy";
                }
                else
                {
                    if (tempArray[1] == "01" || tempArray[1] == "03" || tempArray[1] == "05" || tempArray[1] == "07" || tempArray[1] == "08" || tempArray[1] == "10" || tempArray[1] == "12")
                    {
                        Regex dayCheck1 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])$");

                        if (!dayCheck1.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            endValid = false;
                            LabelEndMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            LabelEndMessage.Text = "";
                            CompareDate();
                        }
                    }
                    else if (tempArray[1] == "04" || tempArray[1] == "06" || tempArray[1] == "09" || tempArray[1] == "11")
                    {
                        Regex dayCheck2 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0])$");

                        if (!dayCheck2.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            endValid = false;
                            LabelEndMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            LabelEndMessage.Text = "";
                            CompareDate();
                        }
                    }
                    else
                    {
                        Regex dayCheck3 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9])$");

                        if (!dayCheck3.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            endValid = false;
                            LabelEndMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            LabelEndMessage.Text = "";
                            CompareDate();
                        }
                    }
                }
            }

            //====================================================================================================================

            //Activates button if inputs are valid, deactivates if not

            if (nameValid == true && currentPageValid == true && numPageValid == true && startValid == true && endValid == true)
            {
                buttonSaveBookmark.Enabled = true;
            }
            else
            {
                buttonSaveBookmark.Enabled = false;
            }

        }

        //Compares the start and end dates to make sure inputs are realistic.

        private void CompareDate()
        {
            if (startValid == true)
            {
                string tempText2 = textBox4.Text;
                string[] tempArray3 = tempText2.Split('/');

                string tempText3 = textBox5.Text;
                string[] tempArray4 = tempText3.Split('/');

                int startYearInt = Int32.Parse(tempArray3[2]);
                int endYearInt = Int32.Parse(tempArray4[2]);
                int startMonthInt = Int32.Parse(tempArray3[1]);
                int endMonthInt = Int32.Parse(tempArray4[1]);
                int startDateInt = Int32.Parse(tempArray3[0]);
                int endDateInt = Int32.Parse(tempArray4[0]);

                if (startYearInt > endYearInt)
                {
                    endValid = false;
                    LabelEndMessage.Text = "End Date Must Be After Start Date";
                }
                else if (startYearInt == endYearInt)
                {
                    if (startMonthInt > endMonthInt)
                    {
                        endValid = false;
                        LabelEndMessage.Text = "End Date Must Be After Start Date";
                    }
                    else if(startMonthInt == endMonthInt)
                    {
                        if(startDateInt > endDateInt)
                        {
                            endValid = false;
                            LabelEndMessage.Text = "End Date Must Be After Start Date";
                        }
                        else
                        {
                            endValid = true;
                            LabelEndMessage.Text = "";
                        }
                    }
                    else
                    {
                        endValid = true;
                        LabelEndMessage.Text = "";
                    }
                }
                else
                {
                    endValid = true;
                    LabelEndMessage.Text = "";
                }
            }
        }

    }
}
