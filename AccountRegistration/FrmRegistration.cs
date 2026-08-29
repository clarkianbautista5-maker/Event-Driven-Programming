using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text);
            StudentInfoClass.Program = cmbProgram.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text);
            StudentInfoClass.Address = txtAddress.Text;

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = new FrmConfirm().ShowDialog();

            if(result == DialogResult.OK)
            {
                txtStudentNo.Clear();
                cmbProgram.SelectedIndex = -1;
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                txtAddress.Clear();

            }

        }
    }
}
