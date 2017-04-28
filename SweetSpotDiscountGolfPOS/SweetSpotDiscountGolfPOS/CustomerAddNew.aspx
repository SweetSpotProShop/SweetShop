﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerAddNew.aspx.cs" Inherits="SweetSpotDiscountGolfPOS.CustomerAddNew" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SPMaster" runat="server">
</asp:Content>--%>

<asp:Content ID="CustomerAddNewPageContent" ContentPlaceHolderID="IndividualPageContent" runat="server">
    <div id="NewCustomer">
        <%--Textboxes and Labels for user to enter customer info--%>
        <h2>Customer Information</h2>
        <asp:SqlDataSource ID="sqlCountry" runat="server" ConnectionString="<%$ ConnectionStrings:SweetSpotDevConnectionString %>" SelectCommand="SELECT [countryID], [countryDesc] FROM [tbl_country]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="sqlProvince" runat="server" ConnectionString="<%$ ConnectionStrings:SweetSpotDevConnectionString %>" SelectCommand="SELECT [provStateID], [provName] FROM [tbl_provState] WHERE ([countryID] = @countryID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCountry" DefaultValue="0" Name="countryID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" ValidateRequestMode="Enabled" ViewStateMode="Enabled"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" ValidateRequestMode="Enabled" ViewStateMode="Enabled"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPrimaryAddress" runat="server" Text="Primary Address: "></asp:Label>
        <asp:TextBox ID="txtPrimaryAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblBillingAddress" runat="server" Text="Billing Address: "></asp:Label>
        <asp:TextBox ID="txtBillingAddress" runat="server"></asp:TextBox>
        <asp:CheckBox ID="chkBillingSame" runat="server" Text="Check if Billing Address is the same as Primary Address" />
        <br />
        <br />
        <asp:Label ID="lblSecondaryAddress" runat="server" Text="Secondary Address: "></asp:Label>
        <asp:TextBox ID="txtSecondaryAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPrimaryPhoneNumber" runat="server" Text="Primary Phone Number: "></asp:Label>
        <asp:TextBox ID="txtPrimaryPhoneNumber" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbSecondaryPhoneNumber" runat="server" Text="Secondary Phone Number: "></asp:Label>
        <asp:TextBox ID="txtSecondaryPhoneNumber" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblProvince" runat="server" Text="Province: "></asp:Label>
        <asp:DropDownList ID="ddlProvince" runat="server" DataSourceID="sqlProvince" DataTextField="provName" DataValueField="provStateID"></asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblCountry" runat="server" Text="Country: "></asp:Label>
        <asp:DropDownList ID="ddlCountry" runat="server" DataSourceID="sqlCountry" DataTextField="countryDesc" DataValueField="countryID"></asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblPostalCode" runat="server" Text="PostalCode: "></asp:Label>
        <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAddCustomer" runat="server" Text="Save and Return" OnClick="btnAddCustomer_Click" />
        <br />
        <br />
    </div>
</asp:Content>
