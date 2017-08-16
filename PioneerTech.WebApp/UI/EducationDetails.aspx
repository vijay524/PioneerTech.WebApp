<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EducationDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.EducationDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table id="Education Details" style="width: 107px">
    
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
            <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
            <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" />
                <asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" />
           
            </td>
          
            </tr>

</table>
</asp:Content>
