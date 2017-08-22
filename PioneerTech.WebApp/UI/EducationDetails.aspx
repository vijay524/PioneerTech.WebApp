<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EducationDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EducationDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table id="Education Details" style="width: 469px">
    <tr id ="EmployeeIDRow">
        <td style="width: 138px">EmployeeID</td>
            <td>
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged"></asp:DropDownList>
            </td>
    </tr>
    
  <tr id ="CourseTypeRow">
            <td style="width: 138px">CourseType</td>
            <td>
                <asp:TextBox ID="CourseTypeTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="YearOfPassRow">
            <td style="width: 138px">YearOfPass</td>
            <td>
                <asp:TextBox ID="YearOfPassTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="YearOfPassRequiredFieldValidator" runat="server" ErrorMessage="Year of pass is required" ControlToValidate="YearOfPassTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="CourseSpecialisationRow">
            <td style="width: 138px">CourseSpecialisation</td>
            <td>
                <asp:TextBox ID="CourseSpecialisationTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>        
    <tr>
            <td>    
            <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" /></td>
            <td><asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" /></td>
               <td> <asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" /></td>
           
            
          
            </tr>

</table>
</asp:Content>
