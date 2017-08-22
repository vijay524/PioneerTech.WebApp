using PioneerTestConsultancySys.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace EmployeeDataAcces
{
    public class EmployeeAccess
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
        protected void CloseConncetion(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }
        public string SaveEmployee(EmployeeModel employee)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspSaveEmployeeDetails";

                sqlCommand.Parameters.Add("@First_name", SqlDbType.VarChar).Value = employee.First_Name;
                sqlCommand.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = employee.Last_Name;
                sqlCommand.Parameters.Add("@Mobile_Number", SqlDbType.VarChar).Value = employee.Mobile_Number;
                sqlCommand.Parameters.Add("@AlternateMobileNumber", SqlDbType.VarChar).Value = employee.AlternateMobileNumber;
                sqlCommand.Parameters.Add("@Address1", SqlDbType.VarChar).Value = employee.Address1;
                sqlCommand.Parameters.Add("@Address2", SqlDbType.VarChar).Value = employee.Address2;
                sqlCommand.Parameters.Add("@Current_Country", SqlDbType.VarChar).Value = employee.Current_Country;
                sqlCommand.Parameters.Add("@Home_Country", SqlDbType.VarChar).Value = employee.Home_Country;
                sqlCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = employee.ZipCode;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {

                    return "Sucess";
                    
                }
                
                return "Failed";
                
            }

            catch (Exception ex)
            {
                return "An error has been occured, please contact the administartor: " + ex.Message;
            }
            finally
            {
                CloseConncetion(sqlConnection);
            }

            
        }
        public List<int> GetEmployeeID()
        {
            try
            { 
            List<int> empIDE = new List<int>();
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetEmployeeID";
                SqlDataReader employeeiddata = sqlCommand.ExecuteReader();
                while(employeeiddata.Read())
                {
                    empIDE.Add(
                        employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))
                        );
                }

                sqlCommand.Dispose();
                return empIDE;
        }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                CloseConncetion(sqlConnection);
            }
        }
        public EmployeeModel GetEmployee(int employeeid)
        {
            EmployeeModel model = new EmployeeModel();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetEmployeeDetails";
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Convert.ToInt32(employeeid);
            SqlDataReader Employeedatareader = sqlCommand.ExecuteReader();
                while (Employeedatareader.Read())
                {

                    model.EmployeeID = Employeedatareader.GetInt32(Employeedatareader.GetOrdinal("EmployeeID"));
                    model.First_Name = Employeedatareader.GetString(Employeedatareader.GetOrdinal("First_Name"));
                    model.Last_Name = Employeedatareader.GetString(Employeedatareader.GetOrdinal("Last_Name"));
                    model.Email = Employeedatareader.GetString(Employeedatareader.GetOrdinal("Email"));
                    model.Mobile_Number = Employeedatareader.GetInt64(Employeedatareader.GetOrdinal("Mobile_Number"));
                    model.AlternateMobileNumber = Employeedatareader.GetInt64(Employeedatareader.GetOrdinal("AlternateMobileNumber"));
                    model.Address1 = Employeedatareader.GetString(Employeedatareader.GetOrdinal("Address1"));
                    model.Address2 = Employeedatareader.GetString(Employeedatareader.GetOrdinal("Address2"));
                    model.Current_Country = Employeedatareader.GetString(Employeedatareader.GetOrdinal("Current_Country"));
                    model.Home_Country = Employeedatareader.GetString(Employeedatareader.GetOrdinal("Home_Country"));
                    model.ZipCode = Employeedatareader.GetInt64(Employeedatareader.GetOrdinal("ZipCode"));





                }

            CloseConncetion(sqlConnection);
            return model;
            }
        public string EditEmployee(EmployeeModel emmodel)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspEditEmployeeDetails";
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = emmodel.EmployeeID.ToString();
                sqlCommand.Parameters.Add("@First_name", SqlDbType.VarChar).Value = emmodel.First_Name;
                sqlCommand.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = emmodel.Last_Name;
                sqlCommand.Parameters.Add("@Mobile_Number", SqlDbType.VarChar).Value = emmodel.Mobile_Number;
                sqlCommand.Parameters.Add("@AlternateMobileNumber", SqlDbType.VarChar).Value = emmodel.AlternateMobileNumber;
                sqlCommand.Parameters.Add("@Address1", SqlDbType.VarChar).Value = emmodel.Address1;
                sqlCommand.Parameters.Add("@Address2", SqlDbType.VarChar).Value = emmodel.Address2;
                sqlCommand.Parameters.Add("@Current_Country", SqlDbType.VarChar).Value = emmodel.Current_Country;
                sqlCommand.Parameters.Add("@Home_Country", SqlDbType.VarChar).Value = emmodel.Home_Country;
                sqlCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = emmodel.ZipCode;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Details have been updated:";
                }
                return "Failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }
           
            finally
            {
                CloseConncetion(sqlConnection);
            }
        }
        }

    public class ProjectAccess

    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
        protected void CloseConncetion(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }
        public string SaveProject(ProjectModel ProjM)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspSaveProjectDetails";
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = ProjM.EmployeeID.ToString();
                sqlCommand.Parameters.Add("@Project_Name", SqlDbType.VarChar).Value = ProjM.Project_Name;
                sqlCommand.Parameters.Add("@Client_Name", SqlDbType.VarChar).Value = ProjM.Client_Name;
                sqlCommand.Parameters.Add("@Location", SqlDbType.VarChar).Value = ProjM.Location;
                sqlCommand.Parameters.Add("@Role", SqlDbType.VarChar).Value = ProjM.Roles;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Data have save Successfully.Thank you";
                }
                
                return "Failed";
            }

            catch (Exception ex)
            {
                return "An error has been occured, please contact the administartor: " + ex.Message;
            }

            finally
            {
                CloseConncetion(sqlConnection);
            }
        }

        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetEmployeeID";
            SqlDataReader employeeiddata = sqlCommand.ExecuteReader();
                while (employeeiddata.Read())
                {
                    empid.Add(
                        employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                    );

                }

            CloseConncetion(sqlConnection);

            return empid;
        }
        public ProjectModel GetProject(int employeeid)
        {
            ProjectModel details = new ProjectModel();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetProjectDetails";
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Convert.ToInt32(employeeid);
            SqlDataReader companydatareader = sqlCommand.ExecuteReader();
                while (companydatareader.Read())
                {
                    details.EmployeeID = companydatareader.GetInt32(companydatareader.GetOrdinal("EmployeeID"));
                    details.Project_Name = companydatareader.GetString(companydatareader.GetOrdinal("Project_Name"));
                    details.Client_Name = companydatareader.GetString(companydatareader.GetOrdinal("Client_Name"));
                    details.Location = companydatareader.GetString(companydatareader.GetOrdinal("Location"));
                    details.Roles = companydatareader.GetString(companydatareader.GetOrdinal("Roles"));
                }

           
            return details;
        }
        public string EditProject(ProjectModel Project)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspEditProjectDetails";
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Project.EmployeeID;
                sqlCommand.Parameters.Add("@Project_Name", SqlDbType.VarChar).Value = Project.Project_Name;
                sqlCommand.Parameters.Add("@Client_Name", SqlDbType.VarChar).Value = Project.Client_Name;
                sqlCommand.Parameters.Add("@Location", SqlDbType.VarChar).Value = Project.Location;
                sqlCommand.Parameters.Add("@Roles", SqlDbType.VarChar).Value = Project.Roles;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Details have been updated:";
                }

                return "Failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }

            finally
            {
                CloseConncetion(sqlConnection);
            }
        }


    }


    public class EducationAccess
    {

        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
        protected void CloseConncetion(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }
        public string SaveEducation(EducationModel EduModel)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspSaveEducationDetails";
                sqlCommand.Parameters.Add("@CourseType", SqlDbType.VarChar).Value = EduModel.CourseType;
                sqlCommand.Parameters.Add("@YearOfPass", SqlDbType.Int).Value = EduModel.YearOfPass.ToString();
                sqlCommand.Parameters.Add("@CourseSpecialisation", SqlDbType.VarChar).Value = EduModel.CourseSpecialisation;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return"Success";
                }
                return "Failed";
                
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact the administartor: " + ex.Message;
            }
            finally
            {
                CloseConncetion(sqlConnection);
            }


        }
        public List<int> GetEmployeeID()
        {
            List<int> empIDE = new List<int>();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetEmployeeID";
            SqlDataReader employeeiddata = sqlCommand.ExecuteReader();
                while (employeeiddata.Read())
                {
                    empIDE.Add(
                        employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))
                        );
                }
            CloseConncetion(sqlConnection);
            return empIDE;
        }
        public EducationModel GetEmployee(int employeeid)
        {
            EducationModel Edumodel = new EducationModel();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetEducationDetails";
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Convert.ToInt32(employeeid);
            SqlDataReader Educationdatareader = sqlCommand.ExecuteReader();
                while (Educationdatareader.Read())
                {

                    Edumodel.EmployeeID = Educationdatareader.GetInt32(Educationdatareader.GetOrdinal("EmployeeID"));
                    Edumodel.CourseType = Educationdatareader.GetString(Educationdatareader.GetOrdinal("CourseType"));
                    Edumodel.YearOfPass = Educationdatareader.GetInt32(Educationdatareader.GetOrdinal("YearOfPass"));
                    Edumodel.CourseSpecialisation = Educationdatareader.GetString(Educationdatareader.GetOrdinal("CourseSpecialisation"));
                    





                }
            CloseConncetion(sqlConnection);

            return Edumodel;
        }
        public string EditEducation(EducationModel EduModel)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspEditEducationDetails";
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EduModel.EmployeeID.ToString();
                sqlCommand.Parameters.Add("@CourseType", SqlDbType.VarChar).Value = EduModel.CourseType;
                sqlCommand.Parameters.Add("@YearOfPass", SqlDbType.Int).Value = EduModel.YearOfPass.ToString();
                sqlCommand.Parameters.Add("@CourseSpecialisation", SqlDbType.VarChar).Value = EduModel.CourseSpecialisation;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Details have been updated:";
                }

                return "Failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }

            finally
            {
                CloseConncetion(sqlConnection);
            }
        }
    }



    public class TechnicalAccess
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
        protected void CloseConncetion(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }
        public string SaveTech(TehnicalModel TechModel)
        {
            int result = 0;
            
                try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspSaveTechnicalDetails";
                sqlCommand.Parameters.Add("@UI", SqlDbType.VarChar).Value = TechModel.UI;
                sqlCommand.Parameters.Add("Programming_Languages", SqlDbType.VarChar).Value = TechModel.Programming_Languages;
                sqlCommand.Parameters.Add("ORM_Technologies", SqlDbType.VarChar).Value = TechModel.ORM_Technologies;
                sqlCommand.Parameters.Add("Databases", SqlDbType.VarChar).Value = TechModel.Databases;

                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Success";
                }
                 return "Failed";

        }
            catch (Exception ex)
            {
                return "An error has been occured, please contact the administartor: " + ex.Message;
            }
            finally
            {
                CloseConncetion(sqlConnection);
            }
        }

        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetEmployeeID";
            SqlDataReader employeeiddata = sqlCommand.ExecuteReader();
                while (employeeiddata.Read())
                {
                    empid.Add(
                        employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                    );

                }

            CloseConncetion(sqlConnection);
            return empid;
        }
        public TehnicalModel GetTechnical(int employeeid)
        {
            TehnicalModel details = new TehnicalModel();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetTechnicalDetails";
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Convert.ToInt32(employeeid);
            SqlDataReader Technicaldatareader = sqlCommand.ExecuteReader();
                while (Technicaldatareader.Read())
                {
                    details.EmployeeID = Technicaldatareader.GetInt32(Technicaldatareader.GetOrdinal("EmployeeID"));
                    details.Programming_Languages = Technicaldatareader.GetString(Technicaldatareader.GetOrdinal("Programming_Languages"));
                    details.Databases = Technicaldatareader.GetString(Technicaldatareader.GetOrdinal("Databases"));
                    details.ORM_Technologies = Technicaldatareader.GetString(Technicaldatareader.GetOrdinal("ORM_Technologies"));
                    details.UI = Technicaldatareader.GetString(Technicaldatareader.GetOrdinal("UI"));
                }
            CloseConncetion(sqlConnection);

            return details;
        }
        public string EditTechnical(TehnicalModel Tech)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspEditTechnicalDetails";
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Tech.EmployeeID;
                sqlCommand.Parameters.Add("@UI", SqlDbType.VarChar).Value = Tech.UI;
                sqlCommand.Parameters.Add("Programming_Languages", SqlDbType.VarChar).Value = Tech.Programming_Languages;
                sqlCommand.Parameters.Add("ORM_Technologies", SqlDbType.VarChar).Value = Tech.ORM_Technologies;
                sqlCommand.Parameters.Add("Databases", SqlDbType.VarChar).Value = Tech.Databases;
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "Update:";
                }
                return "Failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator EditTechnical:" + ex.Message;
            }

            finally
            {
                CloseConncetion(sqlConnection);
            }
        }

    }



    public class CompanyAccess
    {

        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GQMFKE5\SQLEXPRESS;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
        protected void CloseConncetion(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }
        public string SaveCompany1(CompanyModel Comp)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspSaveCompanyDetails";
                sqlCommand.Parameters.Add("Employer_Name", SqlDbType.VarChar).Value = Comp.Employer_Name;
                sqlCommand.Parameters.Add("Contact_Number", SqlDbType.VarChar).Value = Comp.Contact_Number;
                sqlCommand.Parameters.Add("Location", SqlDbType.VarChar).Value = Comp.Location;
                sqlCommand.Parameters.Add("Website", SqlDbType.VarChar).Value = Comp.Website;

                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return"Data have save Successfully.Thank you";
                }
                
                return "Failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact the administartor: " + ex.Message;
            }
            finally
            {
                CloseConncetion(sqlConnection);
            }

        }


        public List<int> GetEmployeeID()
        {

            List<int> empid = new List<int>();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetEmployeeID";
            SqlDataReader employeeiddata = sqlCommand.ExecuteReader();
                while (employeeiddata.Read())
                {
                    empid.Add(
                        employeeiddata.GetInt32(employeeiddata.GetOrdinal("EmployeeID"))

                    );

                }

            CloseConncetion(sqlConnection);
            return empid;
        }
        public CompanyModel GetCompany(int employeeid)
        {
            CompanyModel details = new CompanyModel();
            sqlConnection = OpenConnection();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "uspGetCompanyDetails";
            sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Convert.ToInt32(employeeid);
            SqlDataReader companydatareader = sqlCommand.ExecuteReader();
                while (companydatareader.Read())
                {
                    details.EmployeeID = companydatareader.GetInt32(companydatareader.GetOrdinal("EmployeeID"));
                    details.Employer_Name = companydatareader.GetString(companydatareader.GetOrdinal("Employer_Name"));
                    details.Contact_Number = companydatareader.GetInt64(companydatareader.GetOrdinal("Contact_Number"));
                    details.Location = companydatareader.GetString(companydatareader.GetOrdinal("Location"));
                    details.Website = companydatareader.GetString(companydatareader.GetOrdinal("Website"));
                }

            CloseConncetion(sqlConnection);
            return details;
        }
        public string EditCompany(CompanyModel Comp)
        {
            int result = 0;
            try
            {
                sqlConnection = OpenConnection();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspEditCompanyDetails";
                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = Comp.EmployeeID.ToString();
                sqlCommand.Parameters.Add("@Employer_Name", SqlDbType.VarChar).Value = Comp.Employer_Name;
                sqlCommand.Parameters.Add("@Contact_Number", SqlDbType.VarChar).Value = Comp.Contact_Number;
                sqlCommand.Parameters.Add("@Location", SqlDbType.VarChar).Value = Comp.Location;
                sqlCommand.Parameters.Add("@Website", SqlDbType.VarChar).Value = Comp.Website;
                
                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    return "updated:";
                }
                return "Failed";
            }
            catch (Exception ex)
            {
                return "An error has been occured, please contact administrator:" + ex.Message;
            }

            finally
            {
                CloseConncetion(sqlConnection);
            }
        }

    }
}








