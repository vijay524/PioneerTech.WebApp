<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="EmployeeDetail">
        <td>Employee Details</td>

        
        <tr id ="FirstNameRow">
            <td style="width: 138px">FirstName</td>
            <td>
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="LastNameRow">
            <td style="width: 138px">LastName</td>
            <td>
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="EmailRow">
            <td style="width: 138px">Email</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="MobileNumberRow">
            <td style="width: 138px">MobileNumber</td>
            <td>
                <asp:TextBox ID="MobileNumberTextBox" runat="server"></asp:TextBox>
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
            <td style="width: 138px">CurrentCountry</td>
            <td>
                <asp:TextBox ID="CurrentCountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="HomeCountryRow">
            <td style="width: 138px">HomeCountry</td>
            <td>
                <asp:TextBox ID="HomeCountryTextBox" runat="server"></asp:TextBox>
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
