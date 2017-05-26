﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SettingsHomePage.aspx.cs" Inherits="SweetSpotDiscountGolfPOS.SettingsHomePage" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SPMaster" runat="server">
</asp:Content>--%>

<asp:Content ID="SettingsPageContent" ContentPlaceHolderID="IndividualPageContent" runat="server">
    <div id="Settings">
        <h2>Employee Information</h2>
        <hr />
        <%--Enter search text to find matching Employees information--%>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <hr />
        <asp:Button ID="btnEmployeeSearch" runat="server" Width="150" Text="Employee Search" OnClick="btnEmployeeSearch_Click" />
        <div class="divider" />
        <asp:Button ID="btnAddNewEmployee" runat="server" Width="150" Text="Add New Employee" OnClick="btnAddNewEmployee_Click" />
        <hr />
        <asp:GridView ID="grdEmployeesSearched" AutoGenerateColumns="false" runat="server" OnRowCommand="grdEmployeesSearched_RowCommand">
            <Columns>                
                <asp:TemplateField HeaderText="View Profile">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnViewEmployee" CommandName="ViewProfile" CommandArgument='<%#Eval("employeeID") %>' Text="View Profile" runat="server">View Profile</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee Number">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("employeeID") %>' ID="key"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee Name">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("firstName") + " " + Eval("lastName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee Address">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("primaryAddress") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Phone Number">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("primaryContactNumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%#Eval("city") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No current employee data, please search for a employee
            </EmptyDataTemplate>
        </asp:GridView>
        <br />
        <hr />
        <h2>Taxes</h2>
        <hr />

    </div>
</asp:Content>
