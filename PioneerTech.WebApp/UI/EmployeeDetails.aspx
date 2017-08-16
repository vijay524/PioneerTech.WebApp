<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="Employee_Details">
        <tr id="Employee Details">
            <td style="width: 51px">Employee Details</td>
            <td>

        
        <tr id ="First_NameRow">
            <td style="width: 138px">First_Name</td>
            <td>
                <asp:TextBox ID="First_NameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Last_NameRow">
            <td style="width: 138px">Last_Name</td>
            <td>
                <asp:TextBox ID="Last_NameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="EmailRow">
            <td style="width: 138px">Email</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Mobile_NumberRow">
            <td style="width: 138px">Mobile_Number</td>
            <td>
                <asp:TextBox ID="Mobile_NumberTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="AlternateContactNumberRow">
            <td style="width: 138px">AlternateMobileNumber</td>
            <td>
                <asp:TextBox ID="AlternateMobileNumberTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr id ="Address1Row">
             <td style="width: 138px">Address1</td>
             <td>
                 <asp:TextBox ID="Address1TextBox" runat="server"></asp:TextBox>
             </td>
         </tr>
        <tr id ="Address2Row">
            <td style="width: 138px">Address2</td>
            <td>
                <asp:TextBox ID="Address2TextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="CurrentCountryRow">
            <td style="width: 138px">Current_Country</td>
            <td>
                <asp:TextBox ID="Current_CountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="HomeCountryRow">
            <td style="width: 138px">Home_Country</td>
            <td>
                <asp:TextBox ID="Home_CountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="ZipCodeRow">
            <td style="width: 138px">ZipCode</td>
            <td>
                <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
        </tr>
    </table>

</asp:Content>
