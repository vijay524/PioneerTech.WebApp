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
            
            if (!IsPostBack)
            {
                EmployeeAccess obj = new EmployeeAccess();
                List<int> EmpIDList = obj.GetEmployeeID();
                int i = 0;
                foreach (int EmpID in EmpIDList)
                {
                    EmployeeIDDropDownList.Items.Insert(i, new ListItem(EmpID.ToString()));
                    i++;
                }

            }
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        

        protected void HomeCountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            First_NameTextBox.Text = string.Empty;
            Last_NameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            Mobile_NumberTextBox.Text = string.Empty;
            AlternateMobileNumberTextBox.Text = string.Empty;
            Address1TextBox.Text = string.Empty;
            Address2TextBox.Text = string.Empty;
            Current_CountryTextBox.Text = string.Empty;
            Home_CountryTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {


            try
            {
                EmployeeModel model = new EmployeeModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    First_Name = First_NameTextBox.Text,
                    Last_Name = Last_NameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Mobile_Number = Convert.ToInt64(Mobile_NumberTextBox.Text),
                    AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumberTextBox.Text),
                    Address1 = Address1TextBox.Text,
                    Address2 = Address2TextBox.Text,
                    Current_Country = Current_CountryTextBox.Text,
                    Home_Country = Home_CountryTextBox.Text,
                    ZipCode = Convert.ToInt64(ZipCodeTextBox.Text)
                };
                EmployeeAccess access = new EmployeeAccess();
                string EditEmp=access.EditEmployee(model);
                if(EditEmp.Equals("Success"))
                
                    {
                        Response.Write("<script>alert('Details have been Updated successfully');</script>");
                    }
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values: '" + ex.Message+"</script>");
            }
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
                    ZipCode = Convert.ToInt64(ZipCodeTextBox.Text),
                };
                EmployeeAccess employeedata = new EmployeeAccess();
                string SaveEmp=employeedata.SaveEmployee(employee);
                if(SaveEmp.Equals("Success"))
                
                    {
                        Response.Write("<script>alert('Details have been saved successfully');</script>");
                    }
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(('Please enter the values: '" + ex.Message+");</script>");
            }
        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeModel EmpModel = new EmployeeModel();
            EmployeeAccess EMpAccess = new EmployeeAccess();
            EmpModel = EMpAccess.GetEmployee(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            First_NameTextBox.Text = EmpModel.First_Name;
            Last_NameTextBox.Text = EmpModel.Last_Name;
            EmailTextBox.Text = EmpModel.Email;
            Mobile_NumberTextBox.Text = EmpModel.Mobile_Number.ToString();
            AlternateMobileNumberTextBox.Text = EmpModel.AlternateMobileNumber.ToString();
            Address1TextBox.Text = EmpModel.Address1;
            Address2TextBox.Text = EmpModel.Address2;
            Current_CountryTextBox.Text = EmpModel.Current_Country;
            Home_CountryTextBox.Text = EmpModel.Home_Country;
            ZipCodeTextBox.Text = EmpModel.ZipCode.ToString();
        }

        protected void EmailTextBox_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Address1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void First_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Address2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void AlternateMobileNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }
