using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Bookmark
{
    public partial class FormDisplayBookmark : Form
    {

        private BookmarkInfoCard currentCard;

        //Initializes form
        public FormDisplayBookmark()
        {
            InitializeComponent();
        }

        //Sets card data into currentCard variable
        public BookmarkInfoCard Card
        {
            set => currentCard = value;
        }

        //Loads and displays infocard data
        private void FormDisplayBookmark_Load(object sender, EventArgs e)
        {
            if (currentCard == null)
            {
                return;
            }
            label6.Text = currentCard.Name;
            label7.Text = currentCard.CurrentPage;
            label8.Text = currentCard.NumPages;
            label9.Text = currentCard.StartDate;
            label10.Text = currentCard.EndDate;
        }

        //Closes form when pressed
        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
