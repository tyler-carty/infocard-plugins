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

namespace Assignment.Credit_Card
{
    public partial class FormEditCreditCards : Form
    {

        //Instantiates the variables needed
        private string tempText;
        private CreditCardInfoCard currentCard;

        bool nameValid = false;
        bool numValid = false;
        bool startValid = false;
        bool endValid = false;
        bool ownerValid = false;
        bool securityValid = false;

        //Initializes form
        public FormEditCreditCards()
        {
            InitializeComponent();
        }

        //Sets card data to currentCard variable
        public CreditCardInfoCard Card
        {
            get => currentCard;
            set => currentCard = value;
        }

        private void FormEditCreditCards_Load(object sender, EventArgs e)
        {
            buttonSaveCreditCard.DialogResult = DialogResult.OK;

            buttonSaveCreditCard.Enabled = true;

            if (currentCard != null)
            {
                textBox1.Text = currentCard.Name;
                textBox2.Text = currentCard.CardNumber;
                textBox3.Text = currentCard.StartDate;
                textBox4.Text = currentCard.ExpiryDate;
                textBox5.Text = currentCard.NameOnCard;
                textBox6.Text = currentCard.CardCVC;
            }
        }

        //Exits form if button presses
        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Passes back info card information
        private void ButtonSaveCreditCard_Click(object sender, EventArgs e)
        {
            if (currentCard == null)
            {
                return;
            }
            currentCard.Name = textBox1.Text;
            currentCard.CardNumber = textBox2.Text;
            currentCard.StartDate = textBox3.Text;
            currentCard.ExpiryDate = textBox4.Text;
            currentCard.NameOnCard = textBox5.Text;
            currentCard.CardCVC = textBox6.Text;
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

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        //Validates all of the inputs, covered in more detail in the write-up
        private void Validation()
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                nameValid = false;
                LabelNicknameMessage.Text = "Nickname Must Not Be Empty";
            }
            else if ((textBox1.Text).Contains("|"))
            {
                nameValid = false;
                LabelNicknameMessage.Text = "'|' is not a valid entry";
            }
            else
            {
                nameValid = true;
                LabelNicknameMessage.Text = "";
            }

            //====================================================================================================================

            tempText = textBox2.Text;
            char[] tempArray = tempText.ToCharArray();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                numValid = false;
                LabelCardNumberMessage.Text = "Card Number Must Not Be Empty";
            }
            else if ((textBox2.Text).Contains("|"))
            {
                numValid = false;
                LabelCardNumberMessage.Text = "'|' is not a valid entry";
            }
            else
            {
                if (tempText.Length != 16)
                {
                    numValid = false;
                    LabelCardNumberMessage.Text = "Card Numbers Must Be 16 Digits Long";
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

                    if (count == 16)
                    {
                        numValid = true;
                        LabelCardNumberMessage.Text = "";
                    }
                    else
                    {
                        numValid = false;
                        LabelCardNumberMessage.Text = "Only Numbers Are Allowed";
                    }
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                startValid = false;
                LabelStartMessage.Text = "Date Must Not Be Empty";
            }
            else if ((textBox3.Text).Contains("|"))
            {
                startValid = false;
                LabelStartMessage.Text = "'|' is not a valid entry";
            }
            else
            {

                tempText = textBox3.Text;
                string[] tempArray1 = tempText.Split('/');
                Regex monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
                Regex yearCheck = new Regex(@"^[0-9]{2}$");

                if (tempText.Length != 5)
                {
                    startValid = false;
                    LabelStartMessage.Text = "Date Length Must Be 5 Digits (mm/yy)";
                }
                else
                {
                    if (!monthCheck.IsMatch(tempArray1[0]) || !yearCheck.IsMatch(tempArray1[1]))
                    {
                        startValid = false;
                        LabelStartMessage.Text = "Month/Year Holds Invalid Value";
                    }
                    else
                    {
                        startValid = true;
                        LabelStartMessage.Text = "";
                    }
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                endValid = false;
                LabelExpiryMessage.Text = "Date Must Not Be Empty";
            }
            else if ((textBox4.Text).Contains("|"))
            {
                endValid = false;
                LabelExpiryMessage.Text = "'|' is not a valid entry";
            }
            else
            {

                tempText = textBox4.Text;
                string[] tempArray2 = tempText.Split('/');
                Regex monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
                Regex yearCheck = new Regex(@"^[0-9]{2}$");

                if (tempText.Length != 5)
                {
                    endValid = false;
                    LabelExpiryMessage.Text = "Date Length Must Be 5 Digits (mm/yy)";
                }
                else
                {
                    if (!monthCheck.IsMatch(tempArray2[0]) || !yearCheck.IsMatch(tempArray2[1]))
                    {
                        endValid = false;
                        LabelExpiryMessage.Text = "Month/Year Holds Invalid Value";
                    }
                    else
                    {
                        if(startValid == true)
                        {
                            string tempText2 = textBox3.Text;
                            string[] tempArray3 = tempText2.Split('/');

                            int startYearInt = Int32.Parse(tempArray3[1]);
                            int endYearInt = Int32.Parse(tempArray2[1]);
                            int startMonthInt = Int32.Parse(tempArray3[0]);
                            int endMonthInt = Int32.Parse(tempArray2[0]);

                            if (startYearInt > endYearInt)
                            {
                                endValid = false;
                                LabelExpiryMessage.Text = "End Date Must Be After Start Date";
                            }
                            else if (startYearInt == endYearInt)
                            {
                                if (startMonthInt > endMonthInt)
                                {
                                    endValid = false;
                                    LabelExpiryMessage.Text = "End Date Must Be After Start Date";
                                }
                                else
                                {
                                    endValid = true;
                                    LabelExpiryMessage.Text = "";
                                }
                            }
                            else
                            {
                                endValid = true;
                                LabelExpiryMessage.Text = "";
                            }
                        }
                    }
                }
            }

            //====================================================================================================================

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                ownerValid = false;
                LabelNOCMessage.Text = "Name Must Not Be Empty";
            }
            else if ((textBox5.Text).Contains("|"))
            {
                ownerValid = false;
                LabelNOCMessage.Text = "'|' is not a valid entry";
            }
            else
            {
                ownerValid = true;
                LabelNOCMessage.Text = "";
            }

            //====================================================================================================================

            tempText = textBox6.Text;

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                securityValid = false;
                LabelCVCMessage.Text = "CVC Must Not Be Empty";
            }
            else if ((textBox6.Text).Contains("|"))
            {
                securityValid = false;
                LabelCVCMessage.Text = "'|' is not a valid entry";
            }
            else
            {
                if (tempText.Length != 3)
                {
                    securityValid = false;
                    LabelCVCMessage.Text = "CVC Length Must Be 3 Digits";
                }
                else
                {
                    if (Int32.TryParse(tempText, out int j))
                    {
                        securityValid = true;
                        LabelCVCMessage.Text = "";
                    }
                    else
                    {
                        securityValid = false;
                        LabelCVCMessage.Text = "CVC Holds Invalid Value";
                    }
                }
            }

            //====================================================================================================================

            //Activates button if inputs are valid, deactivates if not

            if (nameValid == true && numValid == true && startValid == true && endValid == true && ownerValid == true && securityValid == true)
            {
                buttonSaveCreditCard.Enabled = true;
            }
            else
            {
                buttonSaveCreditCard.Enabled = false;
            }

        }

    }
}
