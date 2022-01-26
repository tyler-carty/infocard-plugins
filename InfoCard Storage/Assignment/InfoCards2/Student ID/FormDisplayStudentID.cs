using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Student_ID
{
    public partial class FormDisplayStudentID : Form
    {

        private StudentIDInfoCard currentCard;

        //Initializes form
        public FormDisplayStudentID()
        {
            InitializeComponent();
        }

        //Sets card data into currentCard variable
        public StudentIDInfoCard Card
        {
            set => currentCard = value;
        }

        //Loads and displays infocard data, sets picture box size mode
        private void FormDisplayStudentID_Load(object sender, EventArgs e)
        {
            if (currentCard == null)
            {
                return;
            }
            label5.Text = currentCard.Name;
            label6.Text = currentCard.StudentEmail;
            label7.Text = currentCard.CourseStart;
            label8.Text = currentCard.CourseEnd;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = ToImage(currentCard.ImageString);
        }

        //Closes form when pressed
        private void ButtonCancelDisplay_Click(object sender, EventArgs e)
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

    }
}
