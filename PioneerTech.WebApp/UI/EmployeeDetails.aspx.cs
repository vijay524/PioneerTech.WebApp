using EmployeeDataAcces;
using PioneerTestConsultancySys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PioneerTech.WebApp.UI
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        

        protected void HomeCountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    First_Name = First_NameTextBox.Text,
                    Last_Name = Last_NameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Mobile_Number = Convert.ToInt64(Mobile_NumberTextBox.Text),
                    AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                    Address1 = Address1TextBox.Text,
                    Address2 = Address2TextBox.Text,
                    Current_Country = Current_CountryTextBox.Text,
                    Home_Country = Home_CountryTextBox.Text,
                    ZipCode = Convert.ToInt32(ZipCodeTextBox.Text),
                };
                EmployeeAccess employeedata = new EmployeeAccess();
                employeedata.SaveEmployee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values: " + ex.Message);
            }
        }

        protected void First_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}