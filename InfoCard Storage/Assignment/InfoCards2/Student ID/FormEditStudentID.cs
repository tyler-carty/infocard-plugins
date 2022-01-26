using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Student_ID
{
    public partial class FormEditStudentID : Form
    {

        //Instantiates the variables needed
        private string tempText;
        public bool uploaded;
        private StudentIDInfoCard currentCard;

        bool studentNumValid = false;
        bool studentEmailValid = false;
        bool studentStartValid = false;
        bool studentEndValid = false;

        //Initializes form and sets picture box mode
        public FormEditStudentID()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //Sets card data to currentCard variable
        public StudentIDInfoCard Card
        {
            get => currentCard;
            set => currentCard = value;
        }

        //Loads in the information card
        private void FormEditStudentID_Load(object sender, EventArgs e)
        {
            buttonSaveStudentID.DialogResult = DialogResult.OK;

            buttonSaveStudentID.Enabled = true;

            uploaded = false;

            if (currentCard != null)
            {
                textBox1.Text = currentCard.Name;
                textBox2.Text = currentCard.StudentEmail;
                textBox3.Text = currentCard.CourseStart;
                textBox4.Text = currentCard.CourseEnd;
                pictureBox1.Image = ToImage(currentCard.ImageString);
            }
        }

        //Passes back info card information
        private void ButtonSaveStudentID_Click(object sender, EventArgs e)
        {
            if (currentCard == null)
            {
                return;
            }

            else
            {
                if(uploaded == true)
                {
                    currentCard.Name = textBox1.Text;
                    currentCard.StudentEmail = textBox2.Text;
                    currentCard.CourseStart = textBox3.Text;
                    currentCard.CourseEnd = textBox4.Text;
                    currentCard.ImageString = ToString(pictureBox1.Image);
                }
                else
                {
                    currentCard.Name = textBox1.Text;
                    currentCard.StudentEmail = textBox2.Text;
                    currentCard.CourseStart = textBox3.Text;
                    currentCard.CourseEnd = textBox4.Text;
                }
            }
            
        }

        //Exits form if button presses
        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Converts string to image
        private static Image ToImage(string tImageString)
        {
            byte[] imageArray = Convert.FromBase64String(tImageString);
            using (MemoryStream memoryStreamI = new MemoryStream(imageArray, 0, imageArray.Length))
            {
                memoryStreamI.Write(imageArray, 0, imageArray.Length);
                return Image.FromStream(memoryStreamI, true);
            }
        }

        //Converts image to string
        private static string ToString(Image tempImage)
        {
            using (MemoryStream memoryStreamS = new MemoryStream())
            {
                tempImage.Save(memoryStreamS, tempImage.RawFormat);
                byte[] imageArray = memoryStreamS.ToArray();
                return Convert.ToBase64String(imageArray);
            }
        }

        //Allows image file upload in dialog box
        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadFile = new OpenFileDialog();
            uploadFile.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;.*.png";
            if (uploadFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(uploadFile.FileName);
                uploaded = true;
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

        //Validates all of the inputs, covered in more detail in the write-up
        private void Validation()
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                studentNumValid = false;
                LabelStuNumMessage.Text = "Student Number Cannot Be Empty";
            }
            else if ((textBox1.Text).Contains("|"))
            {
                studentNumValid = false;
                LabelStuNumMessage.Text = "'|' Is An Invalid Character";

            }
            else
            {
                tempText = textBox1.Text;
                char[] tempArray = tempText.ToCharArray();

                if (tempText.Length != 9)
                {
                    studentNumValid = false;
                    LabelStuNumMessage.Text = "Student Number Should Be 9-Digits";

                }
                else
                {

                    int count = 0;

                    for (int i = 0; i < (tempText.Length); i++)
                    {

                        char tempChar = tempArray[i];
                        string tempText2 = tempChar.ToString();

                        if (Int32.TryParse(tempText2, out int j))
                        {
                            count += 1;
                        }
                    }

                    if (count == 9)
                    {
                        studentNumValid = true;
                        LabelStuNumMessage.Text = "";

                    }
                    else
                    {
                        studentNumValid = false;
                        LabelStuNumMessage.Text = "Only Numbers Are Valid Inputs";

                    }
                }

            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                studentEmailValid = false;
                LabelStuEmailMessage.Text = "Email Cannot Be Empty";
            }
            else if ((textBox2.Text).Contains("|"))
            {
                studentEmailValid = false;
                LabelStuEmailMessage.Text = "'|' Is an Invalid Character";

            }
            else
            {
                string email = textBox2.Text;
                Regex regex = new Regex(@"^[\w]+[\w.%+-]*@[\w.-]+\.ac\.uk$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    studentEmailValid = true;
                    LabelStuEmailMessage.Text = "";
                }
                else
                {
                    studentEmailValid = false;
                    LabelStuEmailMessage.Text = "Use Format: 'studentnumber@unimail.derby.ac.uk'";

                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                studentStartValid = false;
                LabelStuStartMessage.Text = "Start Date Cannot Be Empty";
            }
            else if ((textBox3.Text).Contains("|"))
            {
                studentStartValid = false;
                LabelStuStartMessage.Text = "'|' Is an Invalid Character";
            }
            else if ((textBox4.Text).Length != 8)
            {
                studentStartValid = false;
                LabelStuStartMessage.Text = "Use Format dd/mm/yy";
            }
            else
            {
                tempText = textBox3.Text;
                string[] tempArray = tempText.Split('/');

                Regex monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
                Regex yearCheck = new Regex(@"^[0-9]{2}$");

                if (!tempText.Contains('/'))
                {
                    studentStartValid = false;
                    LabelStuStartMessage.Text = "Use Format dd/mm/yy";
                }
                else if (tempText.Length != 8)
                {
                    studentStartValid = false;
                    LabelStuStartMessage.Text = "Use Format dd/mm/yy";
                }
                else
                {
                    if (tempArray[1] == "01" || tempArray[1] == "03" || tempArray[1] == "05" || tempArray[1] == "07" || tempArray[1] == "08" || tempArray[1] == "10" || tempArray[1] == "12")
                    {
                        Regex dayCheck1 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])$");

                        if (!dayCheck1.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            studentStartValid = false;
                            LabelStuStartMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            studentStartValid = true;
                            LabelStuStartMessage.Text = "";
                        }
                    }
                    else if (tempArray[1] == "04" || tempArray[1] == "06" || tempArray[1] == "09" || tempArray[1] == "11")
                    {
                        Regex dayCheck2 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0])$");

                        if (!dayCheck2.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            studentStartValid = false;
                            LabelStuStartMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            studentStartValid = true;
                            LabelStuStartMessage.Text = "";
                        }
                    }
                    else
                    {
                        Regex dayCheck3 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9])$");

                        if (!dayCheck3.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            studentStartValid = false;
                            LabelStuStartMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            studentStartValid = true;
                            LabelStuStartMessage.Text = "";
                        }
                    }
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                studentEndValid = false;
            }
            else if ((textBox4.Text).Contains("|"))
            {
                studentEndValid = false;
            }
            else if ((textBox4.Text).Length != 8)
            {
                studentEndValid = false;
                LabelStuEndMessage.Text = "Use Format dd/mm/yy";
            }
            else
            {
                tempText = textBox4.Text;
                string[] tempArray = tempText.Split('/');

                Regex monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
                Regex yearCheck = new Regex(@"^[0-9]{2}$");

                if (!tempText.Contains('/'))
                {
                    studentEndValid = false;
                    LabelStuEndMessage.Text = "Use Format dd/mm/yy";
                }
                else if (tempText.Length != 8)
                {
                    studentEndValid = false;
                    LabelStuEndMessage.Text = "Use Format dd/mm/yy";
                }
                else
                {

                    if (tempArray[1] == "01" || tempArray[1] == "03" || tempArray[1] == "05" || tempArray[1] == "07" || tempArray[1] == "08" || tempArray[1] == "10" || tempArray[1] == "12")
                    {
                        Regex dayCheck1 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])$");

                        if (!dayCheck1.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            studentEndValid = false;
                            LabelStuEndMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            CompareDate();
                        }
                    }
                    else if (tempArray[1] == "04" || tempArray[1] == "06" || tempArray[1] == "09" || tempArray[1] == "11")
                    {
                        Regex dayCheck2 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0])$");

                        if (!dayCheck2.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            studentEndValid = false;
                            LabelStuEndMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            CompareDate();
                        }
                    }
                    else
                    {
                        Regex dayCheck3 = new Regex(@"^(0[1-9]|1[0-9]|2[0-9])$");

                        if (!dayCheck3.IsMatch(tempArray[0]) || !monthCheck.IsMatch(tempArray[1]) || !yearCheck.IsMatch(tempArray[2]))
                        {
                            studentEndValid = false;
                            LabelStuEndMessage.Text = "Invalid Date Entered";
                        }
                        else
                        {
                            CompareDate();
                        }
                    }
                }
            }

            //====================================================================================================================

            //Activates button if inputs are valid, deactivates if not

            if (studentNumValid == true && studentEmailValid == true  && studentStartValid == true  && studentEndValid == true)
            {
                buttonSaveStudentID.Enabled = true;
            }
            else
            {
                buttonSaveStudentID.Enabled = false;
            }

        }

        //Compares the start and end dates to make sure inputs are realistic.
        private void CompareDate()
        {
            if (studentStartValid == true)
            {
                string tempText2 = textBox3.Text;
                string[] tempArray3 = tempText2.Split('/');

                string tempText3 = textBox4.Text;
                string[] tempArray4 = tempText3.Split('/');

                int startYearInt = Int32.Parse(tempArray3[2]);
                int endYearInt = Int32.Parse(tempArray4[2]);
                int startMonthInt = Int32.Parse(tempArray3[1]);
                int endMonthInt = Int32.Parse(tempArray4[1]);
                int startDateInt = Int32.Parse(tempArray3[0]);
                int endDateInt = Int32.Parse(tempArray4[0]);

                if (startYearInt > endYearInt)
                {
                    studentEndValid = false;
                    LabelStuEndMessage.Text = "End Date Must Be After Start Date";
                }
                else if (startYearInt == endYearInt)
                {
                    if (startMonthInt > endMonthInt)
                    {
                        studentEndValid = false;
                        LabelStuEndMessage.Text = "End Date Must Be After Start Date";
                    }
                    else if (startMonthInt == endMonthInt)
                    {
                        if (startDateInt > endDateInt)
                        {
                            studentEndValid = false;
                            LabelStuEndMessage.Text = "End Date Must Be After Start Date";
                        }
                        else
                        {
                            studentEndValid = true;
                            LabelStuEndMessage.Text = "";
                        }
                    }
                    else
                    {
                        studentEndValid = true;
                        LabelStuEndMessage.Text = "";
                    }
                }
                else
                {
                    studentEndValid = true;
                    LabelStuEndMessage.Text = "";
                }
            }
        }

    }
}
