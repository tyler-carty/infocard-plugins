using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Credit_Card
{
    public partial class FormDisplayCreditCards : Form
    {

        private CreditCardInfoCard currentCard;

        //Initializes form
        public FormDisplayCreditCards()
        {
            InitializeComponent();
        }

        //Sets card data into currentCard variable
        public CreditCardInfoCard Card
        {
            set => currentCard = value;
        }

        //Loads and displays infocard data
        private void FormDisplayCreditCards_Load(object sender, EventArgs e)
        {
            if (currentCard == null)
            {
                return;
            }
            labelCardNickname.Text = currentCard.Name;
            labelCardNumberDisplay.Text = currentCard.CardNumber;
            labelStartDateDisplay.Text = currentCard.StartDate;
            labelExpiryDateDisplay.Text = currentCard.ExpiryDate;
            labelNameOnCardDisplay.Text = currentCard.NameOnCard;
            labelCVCDisplay.Text = currentCard.CardCVC;
        }

        //Closes form when pressed
        private void ButtonCancelView_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
