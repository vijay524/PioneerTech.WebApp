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
                educationdata.SaveEducation(education);
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
    }
}