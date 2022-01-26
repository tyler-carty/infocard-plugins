using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Student_ID
{
    public class StudentIDInfoCard : IInfoCard
    {

        //Initialises variables needed
        private FormDisplayStudentID currentDisplay;
        string _studentNumber;
        string _studentEmail;
        string _courseStart;
        string _courseEnd;
        string _imageString;

        //Creates new instance of card with empty data
        public StudentIDInfoCard()
        {
            _studentNumber = string.Empty;
            _studentEmail = string.Empty;
            _courseStart = string.Empty;
            _courseEnd = string.Empty;
            //imageString = "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";
            _imageString = "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";
        }

        //Creates new instance of card with data given
        public StudentIDInfoCard(string initialDetails)
        {
            string[] infoCardArray = initialDetails.Split('|');

            _studentNumber = infoCardArray[0];
            _studentEmail = infoCardArray[1];
            _courseStart = infoCardArray[2];
            _courseEnd = infoCardArray[3];
            _imageString = infoCardArray[4];

        }

        //Sets the variables to be used in the instantiations
        public string Name
        {
            get => _studentNumber;
            set => _studentNumber = value;
        }

        public string StudentEmail
        {
            get => _studentEmail;
            set => _studentEmail = value;
        }

        public string CourseStart
        {
            get => _courseStart;
            set => _courseStart = value;
        }

        public string CourseEnd
        {
            get => _courseEnd;
            set => _courseEnd = value;
        }

        public string ImageString
        {
            get => _imageString;
            set => _imageString = value;
        }

        public string Category => "Student ID";

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

        //Displays the data of the info card chosen
        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            currentDisplay = new FormDisplayStudentID();
            currentDisplay.Card = this;
            currentDisplay.Show();
        }

        //Displays and allows edits to info card chosen
        public bool EditData()
        {
            bool editDone = false;

            FormEditStudentID studentIDEdit = new FormEditStudentID();

            studentIDEdit.Card = this;

            if (studentIDEdit.ShowDialog() == DialogResult.OK)
            {
                editDone = true;
                _studentNumber = studentIDEdit.Card.Name;
                _studentEmail = studentIDEdit.Card.StudentEmail;
                _courseStart = studentIDEdit.Card.CourseStart;
                _courseEnd = studentIDEdit.Card.CourseEnd;
                _imageString = studentIDEdit.Card.ImageString;
            }
            return editDone;
        }

        //Gets all the information of a card as one string
        public string GetDataAsString()
        {
            return "Student ID|" + _studentNumber + "|" + _studentEmail + "|" + _courseStart + "|" + _courseEnd + "|" + _imageString;
        }
    }
}
