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
    public partial class CompanyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CompanyAccess obj = new CompanyAccess();
                List<int> EmpIDList = obj.GetEmployeeID();
                int i = 0;
                foreach (int EmpID in EmpIDList)
                {
                    EmployeeIDDropDownList.Items.Insert(i, new ListItem(EmpID.ToString()));
                    i++;
                }
            }
        }

        protected void WebsiteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void AddCompanyButton_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyModel companymodel = new CompanyModel()
                {
                    Employer_Name = Employer_NameTextBox.Text,
                    Contact_Number = Convert.ToInt64(Contact_NumberTextBox.Text),
                    Location = LocationTextBox.Text,
                    Website = WebsiteTextBox.Text,
                };
                CompanyAccess companydata = new CompanyAccess();
                companydata.SaveCompany1(companymodel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values: " + ex.Message);
            }
        }

        protected void LocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Contact_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyModel model = new CompanyModel()
                {

                    Employer_Name = Employer_NameTextBox.Text,
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    Contact_Number = Convert.ToInt64(Contact_NumberTextBox.Text),
                    Location = LocationTextBox.Text,
                    Website = WebsiteTextBox.Text,
                };
                CompanyAccess access = new CompanyAccess();
                access.EditCompany(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values: " + ex.Message);
            }
        }

       /* protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyModel companymodel = new CompanyModel();
            CompanyAccess companyaccess = new CompanyAccess();
            companymodel = companyaccess.GetCompany(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            Employer_NameTextBox.Text = companymodel.Employer_Name;
            Contact_NumberTextBox.Text = companymodel.Contact_Number.ToString();
            LocationTextBox.Text = companymodel.Location;
            WebsiteTextBox.Text = companymodel.Website;

    
    
        }*/

        protected void EmployeeIDDropDownList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            CompanyModel companymodel = new CompanyModel();
            CompanyAccess companyaccess = new CompanyAccess();
            companymodel = companyaccess.GetCompany(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            Employer_NameTextBox.Text = companymodel.Employer_Name;
            Contact_NumberTextBox.Text = companymodel.Contact_Number.ToString();
            LocationTextBox.Text = companymodel.Location;
            WebsiteTextBox.Text = companymodel.Website;
        }
    }
}

    

