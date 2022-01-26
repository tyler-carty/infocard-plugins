
namespace Assignment.Student_ID
{
    partial class FormEditStudentID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.buttonSaveStudentID = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelCreditCardTitle = new System.Windows.Forms.Label();
            this.LabelStuNumMessage = new System.Windows.Forms.Label();
            this.LabelStuEmailMessage = new System.Windows.Forms.Label();
            this.LabelStuStartMessage = new System.Windows.Forms.Label();
            this.LabelStuEndMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(212, 85);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(95, 23);
            this.buttonUploadImage.TabIndex = 47;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(212, 395);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelEdit.TabIndex = 46;
            this.buttonCancelEdit.Text = "Cancel";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.ButtonCancelEdit_Click);
            // 
            // buttonSaveStudentID
            // 
            this.buttonSaveStudentID.Location = new System.Drawing.Point(97, 395);
            this.buttonSaveStudentID.Name = "buttonSaveStudentID";
            this.buttonSaveStudentID.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveStudentID.TabIndex = 45;
            this.buttonSaveStudentID.Text = "Submit";
            this.buttonSaveStudentID.UseVisualStyleBackColor = true;
            this.buttonSaveStudentID.Click += new System.EventHandler(this.ButtonSaveStudentID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 108);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 338);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 20);
            this.textBox4.TabIndex = 43;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Course End Date (dd/mm/yy)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Student Number (9-Digit)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 284);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 41;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(19, 287);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(148, 13);
            this.labelStartDate.TabIndex = 38;
            this.labelStartDate.Text = "Course Start Date (dd/mm/yy)";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(19, 231);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(108, 13);
            this.labelCardNumber.TabIndex = 37;
            this.labelCardNumber.Text = "Student Email (ac.uk)";
            // 
            // labelCreditCardTitle
            // 
            this.labelCreditCardTitle.AutoSize = true;
            this.labelCreditCardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditCardTitle.Location = new System.Drawing.Point(91, 9);
            this.labelCreditCardTitle.Name = "labelCreditCardTitle";
            this.labelCreditCardTitle.Size = new System.Drawing.Size(186, 31);
            this.labelCreditCardTitle.TabIndex = 35;
            this.labelCreditCardTitle.Text = "My Student ID";
            // 
            // LabelStuNumMessage
            // 
            this.LabelStuNumMessage.AutoSize = true;
            this.LabelStuNumMessage.Location = new System.Drawing.Point(41, 201);
            this.LabelStuNumMessage.Name = "LabelStuNumMessage";
            this.LabelStuNumMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelStuNumMessage.TabIndex = 48;
            // 
            // LabelStuEmailMessage
            // 
            this.LabelStuEmailMessage.AutoSize = true;
            this.LabelStuEmailMessage.Location = new System.Drawing.Point(41, 255);
            this.LabelStuEmailMessage.Name = "LabelStuEmailMessage";
            this.LabelStuEmailMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelStuEmailMessage.TabIndex = 49;
            // 
            // LabelStuStartMessage
            // 
            this.LabelStuStartMessage.AutoSize = true;
            this.LabelStuStartMessage.Location = new System.Drawing.Point(41, 311);
            this.LabelStuStartMessage.Name = "LabelStuStartMessage";
            this.LabelStuStartMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelStuStartMessage.TabIndex = 50;
            // 
            // LabelStuEndMessage
            // 
            this.LabelStuEndMessage.AutoSize = true;
            this.LabelStuEndMessage.Location = new System.Drawing.Point(41, 365);
            this.LabelStuEndMessage.Name = "LabelStuEndMessage";
            this.LabelStuEndMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelStuEndMessage.TabIndex = 51;
            // 
            // FormEditStudentID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 430);
            this.Controls.Add(this.LabelStuEndMessage);
            this.Controls.Add(this.LabelStuStartMessage);
            this.Controls.Add(this.LabelStuEmailMessage);
            this.Controls.Add(this.LabelStuNumMessage);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.buttonCancelEdit);
            this.Controls.Add(this.buttonSaveStudentID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelCreditCardTitle);
            this.Name = "FormEditStudentID";
            this.Text = "Edit Student ID";
            this.Load += new System.EventHandler(this.FormEditStudentID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.Button buttonSaveStudentID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelCreditCardTitle;
        private System.Windows.Forms.Label LabelStuNumMessage;
        private System.Windows.Forms.Label LabelStuEmailMessage;
        private System.Windows.Forms.Label LabelStuStartMessage;
        private System.Windows.Forms.Label LabelStuEndMessage;
    }
}