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
            if (!IsPostBack)
            {
                ProjectAccess obj = new ProjectAccess();
                List<int> EmpIDList = obj.GetEmployeeID();
                int i = 0;
                foreach (int EmpID in EmpIDList)
                {
                    EmployeeIDDropDownList.Items.Insert(i, new ListItem(EmpID.ToString()));
                    i++;
                }
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            Project_NameTextBox.Text = string.Empty;
            Client_NameTextBox.Text = string.Empty;
            LocationTextBox.Text = string.Empty;
            RolesTextBox.Text = string.Empty;
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectModel model = new ProjectModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    Project_Name = Project_NameTextBox.Text,
                    Client_Name = Client_NameTextBox.Text,
                    Location = LocationTextBox.Text,
                    Roles = RolesTextBox.Text
                  
                };
                ProjectAccess access = new ProjectAccess();
                string Editpro=access.EditProject(model);
                if (Editpro.Equals("Success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values: '" + ex.Message+"); </script >");
            }
        }

        protected void ProjectIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectModel projectModel = new ProjectModel();
            ProjectAccess projAccess = new ProjectAccess();
            projectModel = projAccess.GetProject(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            Project_NameTextBox.Text = projectModel.Project_Name;
            Client_NameTextBox.Text = projectModel.Client_Name;
            LocationTextBox.Text = projectModel.Location;
            RolesTextBox.Text = projectModel.Roles;
        }

        protected void AddProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectModel projectmodel = new ProjectModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.Text),
                    Project_Name = Project_NameTextBox.Text,
                    Client_Name = Client_NameTextBox.Text,
                    Location = LocationTextBox.Text,
                    Roles = RolesTextBox.Text,
                };
                ProjectAccess projectdata = new ProjectAccess();
               string Saveproj= projectdata.SaveProject(projectmodel);
                if (Saveproj.Equals("Success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values: '" + ex.Message+"); </ script > ");
            }
        }
    }
}