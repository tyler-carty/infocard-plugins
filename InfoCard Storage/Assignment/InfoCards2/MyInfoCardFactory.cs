using Assignment.Student_ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MyInfoCardFactory : IInfoCardFactory
    {

        //Creates a list of all the categories I am adding
        private string[] categoryList = new string[3]
        {
            "Credit Card",
            "Bookmark",
            "Student ID"
        };

        //Creates a list of all the descriptions to go with the categories
        private string[] categoryDescription = new string[3]
        {
            "Stores Credit Card Details",
            "Stores Bookmarks & Information",
            "Stores Student ID Details"
        };

        //Sets the categories supported equal to my categories
        public string[] CategoriesSupported => categoryList;


        //Creates new info card of type chosen
        public IInfoCard CreateNewInfoCard(string category)
        {
            if (category == categoryList[0])
            {
                return new CreditCardInfoCard();
            }
            else if (category == categoryList[1])
            {
                return new BookmarkInfoCard();
            }
            else if (category == categoryList[2])
            {
                return new StudentIDInfoCard();
            }
            else
            {
                throw new Exception("Infocard Category Unknown");
            }
        }

        //Creates info card of type stored in memory
        public IInfoCard CreateInfoCard(string initialDetails)
        {
            if (initialDetails.StartsWith(categoryList[0]))
            {
                return new CreditCardInfoCard(initialDetails.Substring(12));
            }
            else if (initialDetails.StartsWith(categoryList[1]))
            {
                return new BookmarkInfoCard(initialDetails.Substring(9));
            }
            else if (initialDetails.StartsWith(categoryList[2]))
            {
                return new StudentIDInfoCard(initialDetails.Substring(11));
            }
            else
            {
                throw new Exception("Infocard Category Unknown");
            }
        }

        //Gets description to go with category
        public string GetDescription(string category)
        {
            if (category == categoryList[0])
            {
                return categoryDescription[0];
            }
            else if (category == categoryList[1])
            {
                return categoryDescription[1];
            }
            else if (category == categoryList[2])
            {
                return categoryDescription[2];
            }
            else
            {
                return null;
            }
        }
    }
}
