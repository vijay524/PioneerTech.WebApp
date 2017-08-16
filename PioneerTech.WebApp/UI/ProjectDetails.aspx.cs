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
    public partial class ProjectDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddCompanyButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectModel projectmodel = new ProjectModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDTextBox.Text),
                    Project_Name = Project_NameTextBox.Text,
                    Client_Name = Client_NameTextBox.Text,
                    Location = LocationTextBox.Text,
                    Roles = RolesTextBox.Text,
                };
                ProjectAccess projectdata = new ProjectAccess();
                projectdata.SaveProject(projectmodel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values: " + ex.Message);
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {

        }

        protected void EditButton_Click(object sender, EventArgs e)
        {

        }

        protected void ProjectIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}