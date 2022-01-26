using Assignment.Bookmark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class BookmarkInfoCard : IInfoCard
    {

        //Initialises variables needed
        private FormDisplayBookmark currentDisplay;
        string _bookName;
        string _currentPage;
        string _numPages;
        string _startDate;
        string _endDate;

        //Creates new instance of card with empty data
        public BookmarkInfoCard()
        {
            _bookName = string.Empty;
            _currentPage = string.Empty;
            _numPages = string.Empty;
            _startDate = string.Empty;
            _endDate = string.Empty;
        }

        //Creates new instance of card with data given
        public BookmarkInfoCard(string initialDetails)
        {
            string[] infoCardArray = initialDetails.Split('|');

            _bookName = infoCardArray[0];
            _currentPage = infoCardArray[1];
            _numPages = infoCardArray[2];
            _startDate = infoCardArray[3];
            _endDate = infoCardArray[4];
        }

        //Sets the variables to be used in the instantiations
        public string Name
        {
            get => _bookName;
            set => _bookName = value;
        }

        public string CurrentPage
        {
            get => _currentPage;
            set => _currentPage = value;
        }

        public string NumPages
        {
            get => _numPages;
            set => _numPages = value;
        }

        public string StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public string EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }

        public string Category => "Bookmark";

        //Gets all the information of a card as one string
        public string GetDataAsString()
        {
            return "Bookmark|" + _bookName + "|" + _currentPage + "|" + _numPages + "|" + _startDate + "|" + _endDate;
        }

        //Displays the data of the info card chosen
        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();

            displayPanel.Controls.Clear();

            currentDisplay = new FormDisplayBookmark();
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

            FormEditBookmark bookmarkEdit = new FormEditBookmark();

            bookmarkEdit.Card = this;

            if (bookmarkEdit.ShowDialog() == DialogResult.OK)
            {
                editDone = true;
                _bookName = bookmarkEdit.Card.Name;
                _currentPage = bookmarkEdit.Card.CurrentPage;
                _numPages = bookmarkEdit.Card.NumPages;
                _startDate = bookmarkEdit.Card.StartDate;
                _endDate = bookmarkEdit.Card.EndDate;
            }
            return editDone;
        }
    }
}
