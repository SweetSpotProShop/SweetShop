﻿using SweetShop;
using SweetSpotDiscountGolfPOS.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SweetSpotDiscountGolfPOS
{
    public partial class CustomerAddNew : System.Web.UI.Page
    {
        SweetShopManager ssm = new SweetShopManager();
        LocationManager lm = new LocationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["key"] != null)
            {
                if (!IsPostBack)
                {
                    int custNum = (int)(Convert.ToInt32(Session["key"].ToString()));
                    Customer c = ssm.GetCustomerbyCustomerNumber(custNum);

                    lblFirstNameDisplay.Text = c.firstName.ToString();
                    lblLastNameDisplay.Text = c.lastName.ToString();
                    lblPrimaryAddressDisplay.Text = c.primaryAddress.ToString();
                    lblBillingAddressDisplay.Text = c.billingAddress.ToString();
                    lblSecondaryAddressDisplay.Text = c.secondaryAddress.ToString();
                    lblPrimaryPhoneNumberDisplay.Text = c.primaryPhoneNumber.ToString();
                    lblSecondaryPhoneNumberDisplay.Text = c.secondaryPhoneNumber.ToString();
                    lblEmailDisplay.Text = c.email.ToString();
                    lblCityDisplay.Text = c.city.ToString();
                    lblProvinceDisplay.Text = lm.provinceName(c.province);
                    lblCountryDisplay.Text = lm.countryName(c.country);
                    lblPostalCodeDisplay.Text = c.postalCode.ToString();
                }
            }
            else
            {
                txtFirstName.Visible = true;
                lblFirstNameDisplay.Visible = false;

                txtLastName.Visible = true;
                lblLastNameDisplay.Visible = false;

                txtPrimaryAddress.Visible = true;
                lblPrimaryAddressDisplay.Visible = false;

                txtBillingAddress.Visible = true;
                lblBillingAddressDisplay.Visible = false;

                txtSecondaryAddress.Visible = true;
                lblSecondaryAddressDisplay.Visible = false;

                txtPrimaryPhoneNumber.Visible = true;
                lblPrimaryPhoneNumberDisplay.Visible = false;

                txtSecondaryPhoneNumber.Visible = true;
                lblSecondaryPhoneNumberDisplay.Visible = false;

                txtEmail.Visible = true;
                lblEmailDisplay.Visible = false;

                txtCity.Visible = true;
                lblCityDisplay.Visible = false;

                ddlProvince.Visible = true;
                lblProvinceDisplay.Visible = false;

                ddlCountry.Visible = true;
                lblCountryDisplay.Visible = false;

                txtPostalCode.Visible = true;
                lblPostalCodeDisplay.Visible = false;

                btnSaveCustomer.Visible = false;
                btnAddCustomer.Visible = true;
                pnlDefaultButton.DefaultButton = "btnAddCustomer";
                btnEditCustomer.Visible = false;
                btnCancel.Visible = false;
                btnBackToSearch.Visible = true;
            }

        }
        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.firstName = txtFirstName.Text;
            c.lastName = txtLastName.Text;
            c.primaryAddress = txtPrimaryAddress.Text;
            c.secondaryAddress = txtSecondaryAddress.Text;
            c.primaryPhoneNumber = txtPrimaryPhoneNumber.Text;
            c.secondaryPhoneNumber = txtSecondaryPhoneNumber.Text;
            c.billingAddress = txtBillingAddress.Text;
            c.email = txtEmail.Text;
            c.city = txtCity.Text;
            c.province = Convert.ToInt32(ddlProvince.SelectedValue);
            c.country = Convert.ToInt32(ddlCountry.SelectedValue);
            c.postalCode = txtPostalCode.Text;

            Session["key"] = ssm.addCustomer(c);
            Response.Redirect(Request.RawUrl);
        }
        protected void btnEditCustomer_Click(object sender, EventArgs e)
        {

            txtFirstName.Text = lblFirstNameDisplay.Text;
            txtFirstName.Visible = true;
            lblFirstNameDisplay.Visible = false;

            txtLastName.Text = lblLastNameDisplay.Text;
            txtLastName.Visible = true;
            lblLastNameDisplay.Visible = false;

            txtPrimaryAddress.Text = lblPrimaryAddressDisplay.Text;
            txtPrimaryAddress.Visible = true;
            lblPrimaryAddressDisplay.Visible = false;

            txtBillingAddress.Text = lblBillingAddressDisplay.Text;
            txtBillingAddress.Visible = true;
            lblBillingAddressDisplay.Visible = false;

            txtSecondaryAddress.Text = lblSecondaryAddressDisplay.Text;
            txtSecondaryAddress.Visible = true;
            lblSecondaryAddressDisplay.Visible = false;

            txtPrimaryPhoneNumber.Text = lblPrimaryPhoneNumberDisplay.Text;
            txtPrimaryPhoneNumber.Visible = true;
            lblPrimaryPhoneNumberDisplay.Visible = false;

            txtSecondaryPhoneNumber.Text = lblSecondaryPhoneNumberDisplay.Text;
            txtSecondaryPhoneNumber.Visible = true;
            lblSecondaryPhoneNumberDisplay.Visible = false;

            txtEmail.Text = lblEmailDisplay.Text;
            txtEmail.Visible = true;
            lblEmailDisplay.Visible = false;

            txtCity.Text = lblCityDisplay.Text;
            txtCity.Visible = true;
            lblCityDisplay.Visible = false;

            ddlProvince.SelectedValue = lm.pronvinceID(lblProvinceDisplay.Text).ToString();
            ddlProvince.Visible = true;
            lblProvinceDisplay.Visible = false;

            ddlCountry.SelectedValue = lm.countryID(lblCountryDisplay.Text).ToString();
            ddlCountry.Visible = true;
            lblCountryDisplay.Visible = false;

            txtPostalCode.Text = lblPostalCodeDisplay.Text;
            txtPostalCode.Visible = true;
            lblPostalCodeDisplay.Visible = false;

            btnSaveCustomer.Visible = true;
            pnlDefaultButton.DefaultButton = "btnSaveCustomer";
            btnEditCustomer.Visible = false;
            btnAddCustomer.Visible = false;
            btnCancel.Visible = true;
            btnBackToSearch.Visible = false;

        }
        protected void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.customerId = (int)(Convert.ToInt32(Session["key"].ToString()));
            c.firstName = txtFirstName.Text;
            c.lastName = txtLastName.Text;
            c.primaryAddress = txtPrimaryAddress.Text;
            c.secondaryAddress = txtSecondaryAddress.Text;
            c.primaryPhoneNumber = txtPrimaryPhoneNumber.Text;
            c.secondaryPhoneNumber = txtSecondaryPhoneNumber.Text;
            c.billingAddress = txtBillingAddress.Text;
            c.email = txtEmail.Text;
            c.city = txtCity.Text;
            c.province = Convert.ToInt32(ddlProvince.SelectedValue);
            c.country = Convert.ToInt32(ddlCountry.SelectedValue);
            c.postalCode = txtPostalCode.Text;

            ssm.updateCustomer(c);

            txtFirstName.Visible = false;
            lblFirstNameDisplay.Visible = true;
            txtLastName.Visible = false;
            lblLastNameDisplay.Visible = true;
            txtPrimaryAddress.Visible = false;
            lblPrimaryAddressDisplay.Visible = true;
            txtBillingAddress.Visible = false;
            lblBillingAddressDisplay.Visible = true;
            txtSecondaryAddress.Visible = false;
            lblSecondaryAddressDisplay.Visible = true;
            txtPrimaryPhoneNumber.Visible = false;
            lblPrimaryPhoneNumberDisplay.Visible = true;
            txtSecondaryPhoneNumber.Visible = false;
            lblSecondaryPhoneNumberDisplay.Visible = true;
            txtEmail.Visible = false;
            lblEmailDisplay.Visible = true;
            txtCity.Visible = false;
            lblCityDisplay.Visible = true;
            ddlProvince.Visible = false;
            lblProvinceDisplay.Visible = true;
            ddlCountry.Visible = false;
            lblCountryDisplay.Visible = true;
            txtPostalCode.Visible = false;
            lblPostalCodeDisplay.Visible = true;
            btnSaveCustomer.Visible = false;
            btnEditCustomer.Visible = true;
            btnCancel.Visible = false;
            btnAddCustomer.Visible = false;
            btnBackToSearch.Visible = true;

            btnSaveCustomer.Visible = false;
            btnEditCustomer.Visible = true;
            pnlDefaultButton.DefaultButton = "btnEditCustomer";
            btnCancel.Visible = false;
            btnAddCustomer.Visible = false;
            btnBackToSearch.Visible = true;

            Response.Redirect(Request.RawUrl);

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }
        protected void btnBackToSearch_Click(object sender, EventArgs e)
        {
            Session["key"] = null;
            Response.Redirect("CustomerHomePage.aspx");
        }
    }
}