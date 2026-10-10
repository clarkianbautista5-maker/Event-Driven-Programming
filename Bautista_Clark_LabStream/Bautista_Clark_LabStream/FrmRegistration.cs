using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bautista_Clark_LabStream
{
    public partial class FrmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        public long StudentNumber(string studNum)
        {
            if (Regex.IsMatch(studNum, @"^[0-9]{8,11}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new IndexOutOfRangeException("Student number must Only be numbers and 8 to 11 digits long.");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new OverflowException("Contact number must be 10 to 11 digits long.");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new ArgumentNullException("Last name, first name, and middle initial must contain letters only.");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new FormatException("Age must be a number with 1 to 3 digits.");
            }

            return _Age;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Validate values
                StudentNumber(txtStudentNo.Text);
                FullName(txtLastName.Text, txtFirstName.Text, txtMI.Text);
                ContactNo(txtContactNo.Text);
                Age(txtAge.Text);

                string docPath = Application.StartupPath;
                string fileName = txtStudentNo.Text + ".txt";

                string[] lines =
                {

                "Student No.: " + txtStudentNo.Text,
                "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + " " + txtMI.Text + ".",
                "Program: " + cmbProgram.Text,
                "Gender: " + cmbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.: " + txtContactNo.Text
                };

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
                {
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                }

                MessageBox.Show("Saved to " + Path.Combine(docPath, fileName));

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Format error: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Missing or invalid name field: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Contact number error: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Student number error: ",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        

    }
}
