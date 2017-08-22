<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="Employee_Details" style="width: 585px">
        <tr id="Employee Details">
            <td style="width: 51px">Employee Details</td>
            <td style="width: 389px">
                </td>
            </tr>
            <tr id ="EmployeeIDROW">
                <td style="width: 138px">EmployeeID</td>
            <td style="width: 389px">
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged" ></asp:DropDownList>
            </td>
            </tr>

        
       <tr id ="First_NameRow">
            <td style="width: 138px">First Name</td>
            <td style="width: 389px">
                <asp:TextBox ID="First_NameTextBox" runat="server" OnTextChanged="First_NameTextBox_TextChanged" ></asp:TextBox>
                
            </td>
        </tr>
        <tr id="Last_NameRow">
            <td style="width: 138px">Last Name</td>
            <td style="width: 389px">
                <asp:TextBox ID="Last_NameTextBox" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="Last_NameRequiredFieldValidator" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="Last_NameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="EmailRow">
            <td style="width: 138px">Email</td>
            <td style="width: 389px">
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="Please Enter in Proper Format" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

            </td>
        </tr>
        <tr id="Mobile_NumberRow">
            <td style="width: 138px">Mobile Number</td>
            <td style="width: 389px">
                <asp:TextBox ID="Mobile_NumberTextBox" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="Mobile_NumberRegularExpressionValidator" runat="server" ErrorMessage="Number must be in US Format" ControlToValidate="Mobile_NumberTextBox" ValidationExpression="((\(\d{3}\) ?)|(\d{3}))?\d{3}\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr id="AlternateContactNumberRow">
            <td style="width: 138px">AlternateMobileNumber</td>
            <td style="width: 389px">
                <asp:TextBox ID="AlternateMobileNumberTextBox" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="AlternateMobileNumberTextBoxRegularExpressionValidator" runat="server" ErrorMessage="It must be in US Format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}))?\d{3}\d{4}" ControlToValidate="AlternateMobileNumberTextBox"></asp:RegularExpressionValidator>    
            </td>
        </tr>
         <tr id ="Address1Row">
             <td style="width: 138px">Address1</td>
             <td style="width: 389px">
                 <asp:TextBox ID="Address1TextBox" runat="server" OnTextChanged="Address1TextBox_TextChanged"></asp:TextBox>
             </td>
         </tr>
        <tr id ="Address2Row">
            <td style="width: 138px">Address2</td>
            <td style="width: 389px">
                <asp:TextBox ID="Address2TextBox" runat="server" OnTextChanged="Address2TextBox_TextChanged" ></asp:TextBox>
            </td>
        </tr>
        <tr id="CurrentCountryRow">
            <td style="width: 138px">Current Country</td>
            <td style="width: 389px">
                <asp:TextBox ID="Current_CountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="HomeCountryRow">
            <td style="width: 138px">Home Country</td>
            <td style="width: 389px">
                <asp:TextBox ID="Home_CountryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="ZipCodeRow">
            <td style="width: 138px">ZipCode</td>
            <td style="width: 389px">
                <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
            <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" /></td>
            <td style="width: 389px"> <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear"/></td>
            <td><asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" /></td>
        </tr>
    </table>

</asp:Content>
