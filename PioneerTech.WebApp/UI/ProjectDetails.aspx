<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.ProjectDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table id="Project_Details">
        
        <tr id ="EmployeeIDROW">
                <td style="width: 138px">EmployeeID</td>
            <td style="width: 200px">
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged" ></asp:DropDownList>
            </td>
            </tr>
     <tr id="Project_NameRow">
            <td style="width: 51px">Project_Name</td>
            <td style="width: 200px">
          <asp:TextBox ID="Project_NameTextBox" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr id="Client_NameRow">
            <td style="width: 51px">Client_Name</td>
            <td style="width: 200px">
          <asp:TextBox ID="Client_NameTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>
        </tr>
        <tr id="LocationRow">
            <td style="width: 51px">Location</td>
            <td style="width: 200px">
          <asp:TextBox ID="LocationTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>
        </tr>
         <tr id="RolesRow">
            <td style="width: 51px">Roles</td>
            <td style="width: 200px">
          <asp:TextBox ID="RolesTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>

        </tr>
        
           
        <tr>
            <td>    
            <asp:Button ID="AddProjectButton" runat="server" OnClick="AddProjectButton_Click" Text="AddProject" /></td>
                <td style="width: 200px"><asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" /></td>
                <td><asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" />
           
            </td>
          
            </tr>
        </table>  
</asp:Content>
