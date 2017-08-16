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
                projectdata.SaveTech(TechDe);
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