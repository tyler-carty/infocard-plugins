using Assignment.Credit_Card;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class CreditCardInfoCard : IInfoCard
    {

        //Initialises variables needed
        private FormDisplayCreditCards currentDisplay;
        string _infoCardName;
        string _cardNumber;
        string _startDate;
        string _expiryDate;
        string _nameOnCard;
        string _cardCVC;

        //Creates new instance of card with empty data
        public CreditCardInfoCard()
        {
            _cardNumber = string.Empty;
            _startDate = string.Empty;
            _expiryDate = string.Empty;
            _nameOnCard = string.Empty;
            _cardCVC = string.Empty;
        }

        //Creates new instance of card with data given
        public CreditCardInfoCard(string initialDetails)
        {
            string[] infoCardArray = initialDetails.Split('|');

            Name = infoCardArray[0];
            _cardNumber = infoCardArray[1];
            _startDate = infoCardArray[2];
            _expiryDate = infoCardArray[3];
            _nameOnCard = infoCardArray[4];
            _cardCVC = infoCardArray[5];

        }

        //Sets the variables to be used in the instantiations
        public string Name
        {
            get => _infoCardName;
            set => _infoCardName = value;
        }

        public string CardNumber
        {
            get => _cardNumber;
            set => _cardNumber = value;
        }

        public string StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public string ExpiryDate
        {
            get => _expiryDate;
            set => _expiryDate = value;
        }

        public string NameOnCard
        {
            get => _nameOnCard;
            set => _nameOnCard = value;
        }

        public string CardCVC
        {
            get => _cardCVC;
            set => _cardCVC = value;
        }

        public string Category => "Credit Card";

        //Gets all the information of a card as one string
        public string GetDataAsString()
        {
            return "Credit Card|" + Name + "|" + _cardNumber + "|" + _startDate + "|" + _expiryDate + "|" + _nameOnCard + "|" + _cardCVC;
        }

        //Displays the data of the info card chosen
        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();

            displayPanel.Controls.Clear();

            currentDisplay = new FormDisplayCreditCards();
            currentDisplay.Card = this;
            currentDisplay.TopLevel = false;
            currentDisplay.AutoScroll = true;
            currentDisplay.FormBorderStyle = FormBorderStyle.None;
            displayPanel.Controls.Add(currentDisplay);
            currentDisplay.Show();
        }

        //Closes current display when called
        public void CloseDisplay()
        {
            if (currentDisplay == null)
            {
                return;
            }
            currentDisplay.Close();
            currentDisplay = null;
        }

        //Displays and allows edits to info card chosen
        public bool EditData()
        {
            bool editDone = false;

            FormEditCreditCards creditCardEdit = new FormEditCreditCards();

            creditCardEdit.Card = this;

            if (creditCardEdit.ShowDialog() == DialogResult.OK)
            {
                editDone = true;
                _cardNumber = creditCardEdit.Card.CardNumber;
                _startDate = creditCardEdit.Card.StartDate;
                _expiryDate = creditCardEdit.Card.ExpiryDate;
                _nameOnCard = creditCardEdit.Card.NameOnCard;
                _cardCVC = creditCardEdit.Card.CardCVC;
            }
            return editDone;
        }
    }
}
