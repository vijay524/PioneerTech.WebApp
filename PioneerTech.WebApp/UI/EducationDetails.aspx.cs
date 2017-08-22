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
    public partial class EducationDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EducationAccess obj = new EducationAccess();
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

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                EducationModel education = new EducationModel()
                {
                    CourseType = CourseTypeTextBox.Text,
                    CourseSpecialisation = CourseSpecialisationTextBox.Text,
                    YearOfPass = Convert.ToInt32(YearOfPassTextBox.Text),
                };
                EducationAccess educationdata = new EducationAccess();
                string Edu= educationdata.SaveEducation(education);
                if(Edu.Equals("Success"))
                {
                    Response.Write("<script>alert('Details have been saved successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter the values: '" + ex.Message+");</script>");
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            CourseTypeTextBox.Text = string.Empty;
            YearOfPassTextBox.Text = string.Empty;
            CourseSpecialisationTextBox.Text = string.Empty;
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                EducationModel EduModel = new EducationModel()
                {
                    EmployeeID = Convert.ToInt32(EmployeeIDDropDownList.SelectedValue),
                    CourseType = CourseTypeTextBox.Text,
                    YearOfPass = Convert.ToInt32(YearOfPassTextBox.Text),
                    CourseSpecialisation = CourseSpecialisationTextBox.Text
                };
                EducationAccess EduAccess = new EducationAccess();
                string EditEdu= EduAccess.EditEducation(EduModel);
                if(EditEdu.Equals("Success"))
                {
                    {
                        Response.Write("<script>alert('Details have been Updated successfully');</script>");
                    }
                }
            }
            catch (Exception Ex)
            {
                Response.Write("<script>alert('Error at EditEducation: '" + Ex.Message+");</script>");
            }
        }

        protected void EmployeeIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EducationModel EduModel = new EducationModel();
            EducationAccess EduAccess = new EducationAccess();
            EduModel = EduAccess.GetEmployee(Convert.ToInt32(EmployeeIDDropDownList.SelectedValue));
            CourseTypeTextBox.Text = EduModel.CourseType;
            YearOfPassTextBox.Text = EduModel.YearOfPass.ToString();
            CourseSpecialisationTextBox.Text = EduModel.CourseSpecialisation;
        }

        protected void CourseSpecialisationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}








