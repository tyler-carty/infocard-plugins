
namespace Assignment.Credit_Card
{
    partial class FormEditCreditCards
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCreditCardTitle = new System.Windows.Forms.Label();
            this.labelCVC = new System.Windows.Forms.Label();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.buttonSaveCreditCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.LabelCVCMessage = new System.Windows.Forms.Label();
            this.LabelNOCMessage = new System.Windows.Forms.Label();
            this.LabelExpiryMessage = new System.Windows.Forms.Label();
            this.LabelStartMessage = new System.Windows.Forms.Label();
            this.LabelCardNumberMessage = new System.Windows.Forms.Label();
            this.LabelNicknameMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 333);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // labelCreditCardTitle
            // 
            this.labelCreditCardTitle.AutoSize = true;
            this.labelCreditCardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditCardTitle.Location = new System.Drawing.Point(29, 9);
            this.labelCreditCardTitle.Name = "labelCreditCardTitle";
            this.labelCreditCardTitle.Size = new System.Drawing.Size(196, 31);
            this.labelCreditCardTitle.TabIndex = 0;
            this.labelCreditCardTitle.Text = "My Credit Card";
            // 
            // labelCVC
            // 
            this.labelCVC.AutoSize = true;
            this.labelCVC.Location = new System.Drawing.Point(9, 336);
            this.labelCVC.Name = "labelCVC";
            this.labelCVC.Size = new System.Drawing.Size(34, 13);
            this.labelCVC.TabIndex = 6;
            this.labelCVC.Text = "CVC: ";
            // 
            // labelNameOnCard
            // 
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(9, 282);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(81, 13);
            this.labelNameOnCard.TabIndex = 5;
            this.labelNameOnCard.Text = "Name on Card: ";
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Location = new System.Drawing.Point(9, 225);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(81, 13);
            this.labelExpiryDate.TabIndex = 4;
            this.labelExpiryDate.Text = "Expiry (mm/yy): ";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(9, 168);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(101, 13);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start Date (mm/yy): ";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(9, 112);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(75, 13);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number: ";
            // 
            // buttonSaveCreditCard
            // 
            this.buttonSaveCreditCard.Location = new System.Drawing.Point(35, 389);
            this.buttonSaveCreditCard.Name = "buttonSaveCreditCard";
            this.buttonSaveCreditCard.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCreditCard.TabIndex = 13;
            this.buttonSaveCreditCard.Text = "Submit";
            this.buttonSaveCreditCard.UseVisualStyleBackColor = true;
            this.buttonSaveCreditCard.Click += new System.EventHandler(this.ButtonSaveCreditCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Nickname: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Location = new System.Drawing.Point(150, 389);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelEdit.TabIndex = 14;
            this.buttonCancelEdit.Text = "Cancel";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.ButtonCancelEdit_Click);
            // 
            // LabelCVCMessage
            // 
            this.LabelCVCMessage.AutoSize = true;
            this.LabelCVCMessage.Location = new System.Drawing.Point(16, 364);
            this.LabelCVCMessage.Name = "LabelCVCMessage";
            this.LabelCVCMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelCVCMessage.TabIndex = 15;
            // 
            // LabelNOCMessage
            // 
            this.LabelNOCMessage.AutoSize = true;
            this.LabelNOCMessage.Location = new System.Drawing.Point(16, 307);
            this.LabelNOCMessage.Name = "LabelNOCMessage";
            this.LabelNOCMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelNOCMessage.TabIndex = 16;
            // 
            // LabelExpiryMessage
            // 
            this.LabelExpiryMessage.AutoSize = true;
            this.LabelExpiryMessage.Location = new System.Drawing.Point(16, 251);
            this.LabelExpiryMessage.Name = "LabelExpiryMessage";
            this.LabelExpiryMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelExpiryMessage.TabIndex = 17;
            // 
            // LabelStartMessage
            // 
            this.LabelStartMessage.AutoSize = true;
            this.LabelStartMessage.Location = new System.Drawing.Point(16, 197);
            this.LabelStartMessage.Name = "LabelStartMessage";
            this.LabelStartMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelStartMessage.TabIndex = 18;
            // 
            // LabelCardNumberMessage
            // 
            this.LabelCardNumberMessage.AutoSize = true;
            this.LabelCardNumberMessage.Location = new System.Drawing.Point(16, 137);
            this.LabelCardNumberMessage.Name = "LabelCardNumberMessage";
            this.LabelCardNumberMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelCardNumberMessage.TabIndex = 19;
            // 
            // LabelNicknameMessage
            // 
            this.LabelNicknameMessage.AutoSize = true;
            this.LabelNicknameMessage.Location = new System.Drawing.Point(16, 81);
            this.LabelNicknameMessage.Name = "LabelNicknameMessage";
            this.LabelNicknameMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelNicknameMessage.TabIndex = 20;
            // 
            // FormEditCreditCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 426);
            this.Controls.Add(this.LabelNicknameMessage);
            this.Controls.Add(this.LabelCardNumberMessage);
            this.Controls.Add(this.LabelStartMessage);
            this.Controls.Add(this.LabelExpiryMessage);
            this.Controls.Add(this.LabelNOCMessage);
            this.Controls.Add(this.LabelCVCMessage);
            this.Controls.Add(this.buttonCancelEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveCreditCard);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelCreditCardTitle);
            this.Controls.Add(this.labelCVC);
            this.Controls.Add(this.labelNameOnCard);
            this.Controls.Add(this.labelExpiryDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelCardNumber);
            this.Name = "FormEditCreditCards";
            this.Text = "Edit Credit Card";
            this.Load += new System.EventHandler(this.FormEditCreditCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCreditCardTitle;
        private System.Windows.Forms.Label labelCVC;
        private System.Windows.Forms.Label labelNameOnCard;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Button buttonSaveCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.Label LabelCVCMessage;
        private System.Windows.Forms.Label LabelNOCMessage;
        private System.Windows.Forms.Label LabelExpiryMessage;
        private System.Windows.Forms.Label LabelStartMessage;
        private System.Windows.Forms.Label LabelCardNumberMessage;
        private System.Windows.Forms.Label LabelNicknameMessage;
    }
}