<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.ProjectDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table id="Project_Details">
        
        <tr id ="EmployeeIDRow">
            <td style="width: 138px">EmployeeID</td>
            <td>
                <asp:TextBox ID="EmployeeIDTextBox" runat="server" ></asp:TextBox>
            </td>
     <tr id="Project_NameRow">
            <td style="width: 51px">Project_Name</td>
            <td>
          <asp:TextBox ID="Project_NameTextBox" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr id="Client_NameRow">
            <td style="width: 51px">Client_Name</td>
            <td>
          <asp:TextBox ID="Client_NameTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>
        </tr>
        <tr id="LocationRow">
            <td style="width: 51px">Location</td>
            <td>
          <asp:TextBox ID="LocationTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>
        </tr>
         <tr id="RolesRow">
            <td style="width: 51px">Roles</td>
            <td>
          <asp:TextBox ID="RolesTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>

        </tr>
        
           
        <tr>
            <td>    
            <asp:Button ID="AddCompanyButton" runat="server" OnClick="AddCompanyButton_Click" Text="AddCompany" />
                <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" />
                <asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" />
           
            </td>
          
            </tr>
</asp:Content>
