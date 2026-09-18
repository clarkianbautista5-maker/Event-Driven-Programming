namespace OrganizationProfile
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtStudentNo = new TextBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            cbPrograms = new ComboBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtContactNo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(392, 183);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 57);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 183);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 140);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 98);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(306, 98);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 7;
            label8.Text = "First Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(329, 140);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 8;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(561, 98);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 9;
            label10.Text = "M. I.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(114, 54);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(179, 27);
            txtStudentNo.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(392, 132);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 28);
            cbGender.TabIndex = 11;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePickerBirthday.Location = new Point(114, 183);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(257, 27);
            datePickerBirthday.TabIndex = 12;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(286, 235);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 31);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(114, 137);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 27);
            txtAge.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(114, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 27);
            txtLastName.TabIndex = 15;
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(392, 54);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(277, 28);
            cbPrograms.TabIndex = 16;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(392, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(163, 27);
            txtFirstName.TabIndex = 17;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleInitial.Location = new Point(603, 91);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(69, 27);
            txtMiddleInitial.TabIndex = 18;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(485, 180);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(187, 27);
            txtContactNo.TabIndex = 19;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 301);
            Controls.Add(txtContactNo);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(cbPrograms);
            Controls.Add(txtLastName);
            Controls.Add(txtAge);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(txtStudentNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtStudentNo;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
        private TextBox txtAge;
        private TextBox txtLastName;
        private ComboBox cbPrograms;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtContactNo;
    }
}
