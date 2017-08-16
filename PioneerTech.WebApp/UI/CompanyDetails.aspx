<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;<table id="Company_Details">
        
        <tr id ="EmployeeIDRow">
            <td style="width: 138px">EmployeeID</td>
            <td>
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged1"></asp:DropDownList>
            </td>

        <tr id="Employer_NameRow">
            <td style="width: 51px">Employer_Name</td>
            <td>
          <asp:TextBox ID="Employer_NameTextBox" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr id="Contact_NumberRow">
            <td style="width: 51px">Contact_Number</td>
            <td>
          <asp:TextBox ID="Contact_NumberTextBox" runat="server" style="margin-left: 0px" OnTextChanged="Contact_NumberTextBox_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr id="LocationRow">
            <td style="width: 51px">Location</td>
            <td>
          <asp:TextBox ID="LocationTextBox" runat="server" style="margin-left: 0px" OnTextChanged="LocationTextBox_TextChanged"></asp:TextBox>
            </td>
        </tr>
         <tr id="WebsiteRow">
            <td style="width: 51px">Website</td>
            <td>
          <asp:TextBox ID="WebsiteTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>

        </tr>
        
           
        <tr>
            <td>    
                <asp:Button ID="AddCompanyButton" runat="server" OnClick="AddCompanyButton_Click" Text="AddCompany"/></td>
               <td> <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear"/></td>
                <td><asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" /></td>
           
            
          
            </tr>
      </table>
           
</asp:Content>
            
