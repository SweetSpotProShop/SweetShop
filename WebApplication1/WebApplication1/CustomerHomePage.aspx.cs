﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCustomerSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAddNew.aspx");
        }
    }
}