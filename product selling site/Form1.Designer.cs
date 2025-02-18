namespace product_selling_site
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            PhoneNumberLabel = new Label();
            AddressLabel = new Label();
            CityLabel = new Label();
            FirstNameTextBox = new TextBox();
            CityTextBox = new TextBox();
            AddressTextBox = new TextBox();
            PhoneNumberTexxtBox = new TextBox();
            LastNameTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(27, 37);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(87, 20);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name :";
            FirstNameLabel.Click += label1_Click;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(27, 68);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(86, 20);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name :";
            LastNameLabel.Click += label2_Click;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(27, 103);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(115, 20);
            PhoneNumberLabel.TabIndex = 2;
            PhoneNumberLabel.Text = "Phone Number :";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(27, 136);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(69, 20);
            AddressLabel.TabIndex = 3;
            AddressLabel.Text = "Address :";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(27, 168);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(41, 20);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City :";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(190, 34);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(535, 27);
            FirstNameTextBox.TabIndex = 5;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(190, 166);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(535, 27);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += textBox2_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(190, 133);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(535, 27);
            AddressTextBox.TabIndex = 7;
            // 
            // PhoneNumberTexxtBox
            // 
            PhoneNumberTexxtBox.Location = new Point(190, 100);
            PhoneNumberTexxtBox.Name = "PhoneNumberTexxtBox";
            PhoneNumberTexxtBox.Size = new Size(535, 27);
            PhoneNumberTexxtBox.TabIndex = 8;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(190, 67);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(535, 27);
            LastNameTextBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(27, 213);
            button1.Name = "button1";
            button1.Size = new Size(698, 29);
            button1.TabIndex = 10;
            button1.Text = "Add customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add_Customer_Button;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LastNameTextBox);
            Controls.Add(PhoneNumberTexxtBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(CityLabel);
            Controls.Add(AddressLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label PhoneNumberLabel;
        private Label AddressLabel;
        private Label CityLabel;
        private TextBox FirstNameTextBox;
        private TextBox CityTextBox;
        private TextBox AddressTextBox;
        private TextBox PhoneNumberTexxtBox;
        private TextBox LastNameTextBox;
        private Button button1;
    }
}
