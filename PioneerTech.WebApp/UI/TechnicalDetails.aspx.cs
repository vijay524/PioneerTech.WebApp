using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerTestConsultancySys.Model;
using EmployeeDataAcces;
using System.Windows.Forms;

namespace PioneerTech.WebApp.UI
{
    public partial class TechnicalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TechnicalAccess obj = new TechnicalAccess();
                List<int> EmpIDList = obj.GetEmployeeID();
                int i = 0;
                foreach (int EmpID in EmpIDList)
                {
                    EmployeeIDDropDownList.Items.Insert(i, new ListItem(EmpID.ToString()));
                    i++;
                }
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                TehnicalModel TechDe = new TehnicalModel()
                {
                    Programming_Languages = Programming_LanguagesTextBox.Text,
                ORM_Technologies = ORM_TechnologiesTextBox.Text,
                    UI = UITextBox.Text,
                    Databases = DatabasesTextBox.Text,
                    
                };
                TechnicalAccess projectdata = new TechnicalAccess();
                string SaveTe=projectdata.SaveTech(TechDe);
                if (SaveTe.Equals("Success"))

                {
                    Response.Write("<script>alert('Details have been saved successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(('Please enter the values:' " + ex.Message+");</script>");
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            Programming_LanguagesTextBox.Text = string.Empty;
            DatabasesTextBox.Text = string.Empty;
            ORM_TechnologiesTextBox.Text = string.Empty;
            UITextBox.Text = string.Empty;
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                TehnicalModel model = new TehnicalModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    Programming_Languages = Programming_LanguagesTextBox.Text,
                    Databases = DatabasesTextBox.Text,
                    ORM_Technologies = ORM_TechnologiesTextBox.Text,
                    UI = UITextBox.Text,
                };
                TechnicalAccess access = new TechnicalAccess();
                string EditTech=access.EditTechnical(model);
                if (EditTech.Equals("Success"))

                {
                    Response.Write("<script>alert('Details have been Updated successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(('Please enter the values:' " + ex.Message + ");</script>");
            }
        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TehnicalModel model = new TehnicalModel();
            TechnicalAccess Technicaccess = new TechnicalAccess();
            model = Technicaccess.GetTechnical(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            Programming_LanguagesTextBox.Text = model.Programming_Languages;
            DatabasesTextBox.Text = model.Databases;
            ORM_TechnologiesTextBox.Text = model.ORM_Technologies;
            UITextBox.Text = model.UI;
        }
    }
}