<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="TechnicalDetails.aspx.cs" Inherits="PioneerTech.WebApp.UI.TechnicalDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table id="Technical Details">
         <tr id ="EmployeeIDRow">
            <td style="width: 138px">EmployeeID</td>
            <td>
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged1"></asp:DropDownList>
            </td>
        
        <tr id ="Programming_LanguagesRow">
            <td style="width: 138px">Programming Languages</td>
            <td>
                <asp:TextBox ID="Programming_LanguagesTextBox" runat="server" ></asp:TextBox>
            </td>
     <tr id="DatabasesRow">
            <td style="width: 51px">Databases</td>
            <td>
          <asp:TextBox ID="DatabasesTextBox" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr id="ORM_TechnologiesRow">
            <td style="width: 51px">ORM Technologies</td>
            <td>
          <asp:TextBox ID="ORM_TechnologiesTextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>
            <tr id="UIRow">
            <td style="width: 51px">UI</td>
            <td>
          <asp:TextBox ID="UITextBox" runat="server" style="margin-left: 0px" ></asp:TextBox>
            </td>
                <tr>
            <td>    
                <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save"/></td>
               <td> <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear"/></td>
                <td><asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Edit" /></td>
           
            
          
            </tr>
         </table>
</asp:Content>
